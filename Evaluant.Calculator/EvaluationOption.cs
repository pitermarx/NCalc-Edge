﻿using System;

namespace NCalc
{
    // Summary:
    //     Provides enumerated values to use to set evaluation options.
    [Flags]
    public enum EvaluateOptions
    {
		/// <summary>
		/// Specifies that no options are set.
		/// </summary>
		None = 1,
		/// <summary>
		/// Specifies case-insensitive matching.
		/// </summary>
		IgnoreCase = 2,
		/// <summary>
		/// No-cache mode. Ingores any pre-compiled expression in the cache.
		/// </summary>
		NoCache = 4,
		/// <summary>
		/// Treats parameters as arrays and result a set of results.
		/// </summary>
		IterateParameters = 8,
		/// <summary>
		/// When using Round(), if a number is halfway between two others, it is rounded toward the nearest number that is away from zero. 
		/// </summary>
		RoundAwayFromZero = 16,
		/// <summary>
		/// Causes incompatible type comparisons to evaluate to false instead of throwing an EvaluationException.
		/// </summary>
		WeakTypeChecking = 32
	}
}
