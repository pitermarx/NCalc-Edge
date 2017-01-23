#tool "nuget:?package=NUnit.ConsoleRunner"
#tool "nuget:?package=GitVersion.CommandLine"

var configuration = Argument("configuration", "Debug");
var target = Argument("target", "Default");
string version = null;
Task("Restore")
    .Does(() => 
{
    NuGetRestore("NCalc.sln");
});

Task("Clean")
    .Does(() => 
{
    CleanDirectory("./nuget");
    CleanDirectories("./**/bin");
    CleanDirectories("./**/obj");
});

Task("UpdateAssemblyInfo")
    .Does(() => 
{
    version = GitVersion(new GitVersionSettings { UpdateAssemblyInfo = true }).NuGetVersionV2;
    if(AppVeyor.IsRunningOnAppVeyor)
    {
        AppVeyor.UpdateBuildVersion(version);
    }
});

Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .IsDependentOn("UpdateAssemblyInfo")
    .Does(() => 
{
    MSBuild("NCalc.sln", configurator =>
        configurator
            .SetConfiguration(configuration)
            .SetVerbosity(Verbosity.Minimal));
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() => 
{
    NUnit3("./**/bin/**/*.Tests.dll");
    if(AppVeyor.IsRunningOnAppVeyor)
    {
        AppVeyor.UploadTestResults("./TestResult.xml", AppVeyorTestResultsType.NUnit3);
    }
});

Task("Pack")
    .IsDependentOn("Test")
    .Does(() =>
{
    var nuGetPackSettings   = new NuGetPackSettings 
    {
        Id           = "NCalc-Edge",
        Version      = version,
        Authors      = new[] {"sebastienros", "pitermarx"},
        Description  = "NCalc is a mathematical expressions evaluator in .NET. " +
                       "NCalc can parse any expression and evaluate the result, including static or dynamic parameters and custom functions.",
        Dependencies = new [] {
            new NuSpecDependency {
                Id = "Antlr",
                Version = "3.5.0.2"
            }
        },
        ProjectUrl   = new Uri("https://github.com/pitermarx/NCalc-Edge"),
        LicenseUrl   = new Uri("http://ncalc.codeplex.com/license"),
        Tags         = new [] {"mathematical","expression","parse","evaluate"},
        Files        = new [] { 
            new NuSpecContent {
                Source = "Evaluant.Calculator/bin/Release/NCalc.dll",
                Target = "lib"
            },
        },
        BasePath        = "./",
        OutputDirectory = "./nuget"
    };

    NuGetPack(nuGetPackSettings);
    if(AppVeyor.IsRunningOnAppVeyor)
    {
        var file = GetFiles("nuget/NCalc-Edge*.nupkg").First();
        AppVeyor.UploadArtifact(file);
        AppVeyor.UploadArtifact("Evaluant.Calculator/bin/Release/NCalc.dll");
    }
});

Task("Default")
    .IsDependentOn("Pack");

RunTarget(target);