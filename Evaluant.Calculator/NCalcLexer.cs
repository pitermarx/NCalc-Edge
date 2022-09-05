// $ANTLR 3.5.1 NCalc.g 2022-09-05 13:30:33

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

[System.CLSCompliant(false)]
public partial class NCalcLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__48=48;
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
	public const int T__55=55;
	public const int T__56=56;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
	public const int T__72=72;
	public const int T__73=73;
	public const int T__74=74;
	public const int A=4;
	public const int AND=5;
	public const int B=6;
	public const int C=7;
	public const int D=8;
	public const int DATETIME=9;
	public const int DIGIT=10;
	public const int E=11;
	public const int EXPONENT=12;
	public const int EscapeSequence=13;
	public const int F=14;
	public const int FALSE=15;
	public const int FLOAT=16;
	public const int G=17;
	public const int H=18;
	public const int HexDigit=19;
	public const int I=20;
	public const int ID=21;
	public const int INTEGER=22;
	public const int J=23;
	public const int K=24;
	public const int L=25;
	public const int LETTER=26;
	public const int M=27;
	public const int N=28;
	public const int NAME=29;
	public const int NOT=30;
	public const int O=31;
	public const int OR=32;
	public const int P=33;
	public const int Q=34;
	public const int R=35;
	public const int S=36;
	public const int STRING=37;
	public const int T=38;
	public const int TRUE=39;
	public const int U=40;
	public const int UnicodeEscape=41;
	public const int V=42;
	public const int W=43;
	public const int WS=44;
	public const int X=45;
	public const int Y=46;
	public const int Z=47;

	// delegates
	// delegators

	public NCalcLexer()
	{
		OnCreated();
	}

	public NCalcLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public NCalcLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}

	private static readonly bool[] decisionCanBacktrack = new bool[0];
	public override string GrammarFileName { get { return "NCalc.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__48();
	partial void LeaveRule_T__48();

	// $ANTLR start "T__48"
	[GrammarRule("T__48")]
	private void mT__48()
	{
		EnterRule_T__48();
		EnterRule("T__48", 1);
		TraceIn("T__48", 1);
		try
		{
			int _type = T__48;
			int _channel = DefaultTokenChannel;
			// NCalc.g:7:7: ( '!' )
			DebugEnterAlt(1);
			// NCalc.g:7:9: '!'
			{
			DebugLocation(7, 9);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__48", 1);
			LeaveRule("T__48", 1);
			LeaveRule_T__48();
		}
	}
	// $ANTLR end "T__48"

	partial void EnterRule_T__49();
	partial void LeaveRule_T__49();

	// $ANTLR start "T__49"
	[GrammarRule("T__49")]
	private void mT__49()
	{
		EnterRule_T__49();
		EnterRule("T__49", 2);
		TraceIn("T__49", 2);
		try
		{
			int _type = T__49;
			int _channel = DefaultTokenChannel;
			// NCalc.g:8:7: ( '!=' )
			DebugEnterAlt(1);
			// NCalc.g:8:9: '!='
			{
			DebugLocation(8, 9);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__49", 2);
			LeaveRule("T__49", 2);
			LeaveRule_T__49();
		}
	}
	// $ANTLR end "T__49"

	partial void EnterRule_T__50();
	partial void LeaveRule_T__50();

	// $ANTLR start "T__50"
	[GrammarRule("T__50")]
	private void mT__50()
	{
		EnterRule_T__50();
		EnterRule("T__50", 3);
		TraceIn("T__50", 3);
		try
		{
			int _type = T__50;
			int _channel = DefaultTokenChannel;
			// NCalc.g:9:7: ( '%' )
			DebugEnterAlt(1);
			// NCalc.g:9:9: '%'
			{
			DebugLocation(9, 9);
			Match('%'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__50", 3);
			LeaveRule("T__50", 3);
			LeaveRule_T__50();
		}
	}
	// $ANTLR end "T__50"

	partial void EnterRule_T__51();
	partial void LeaveRule_T__51();

	// $ANTLR start "T__51"
	[GrammarRule("T__51")]
	private void mT__51()
	{
		EnterRule_T__51();
		EnterRule("T__51", 4);
		TraceIn("T__51", 4);
		try
		{
			int _type = T__51;
			int _channel = DefaultTokenChannel;
			// NCalc.g:10:7: ( '&&' )
			DebugEnterAlt(1);
			// NCalc.g:10:9: '&&'
			{
			DebugLocation(10, 9);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__51", 4);
			LeaveRule("T__51", 4);
			LeaveRule_T__51();
		}
	}
	// $ANTLR end "T__51"

	partial void EnterRule_T__52();
	partial void LeaveRule_T__52();

	// $ANTLR start "T__52"
	[GrammarRule("T__52")]
	private void mT__52()
	{
		EnterRule_T__52();
		EnterRule("T__52", 5);
		TraceIn("T__52", 5);
		try
		{
			int _type = T__52;
			int _channel = DefaultTokenChannel;
			// NCalc.g:11:7: ( '&' )
			DebugEnterAlt(1);
			// NCalc.g:11:9: '&'
			{
			DebugLocation(11, 9);
			Match('&'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__52", 5);
			LeaveRule("T__52", 5);
			LeaveRule_T__52();
		}
	}
	// $ANTLR end "T__52"

	partial void EnterRule_T__53();
	partial void LeaveRule_T__53();

	// $ANTLR start "T__53"
	[GrammarRule("T__53")]
	private void mT__53()
	{
		EnterRule_T__53();
		EnterRule("T__53", 6);
		TraceIn("T__53", 6);
		try
		{
			int _type = T__53;
			int _channel = DefaultTokenChannel;
			// NCalc.g:12:7: ( '(' )
			DebugEnterAlt(1);
			// NCalc.g:12:9: '('
			{
			DebugLocation(12, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__53", 6);
			LeaveRule("T__53", 6);
			LeaveRule_T__53();
		}
	}
	// $ANTLR end "T__53"

	partial void EnterRule_T__54();
	partial void LeaveRule_T__54();

	// $ANTLR start "T__54"
	[GrammarRule("T__54")]
	private void mT__54()
	{
		EnterRule_T__54();
		EnterRule("T__54", 7);
		TraceIn("T__54", 7);
		try
		{
			int _type = T__54;
			int _channel = DefaultTokenChannel;
			// NCalc.g:13:7: ( ')' )
			DebugEnterAlt(1);
			// NCalc.g:13:9: ')'
			{
			DebugLocation(13, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__54", 7);
			LeaveRule("T__54", 7);
			LeaveRule_T__54();
		}
	}
	// $ANTLR end "T__54"

	partial void EnterRule_T__55();
	partial void LeaveRule_T__55();

	// $ANTLR start "T__55"
	[GrammarRule("T__55")]
	private void mT__55()
	{
		EnterRule_T__55();
		EnterRule("T__55", 8);
		TraceIn("T__55", 8);
		try
		{
			int _type = T__55;
			int _channel = DefaultTokenChannel;
			// NCalc.g:14:7: ( '*' )
			DebugEnterAlt(1);
			// NCalc.g:14:9: '*'
			{
			DebugLocation(14, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__55", 8);
			LeaveRule("T__55", 8);
			LeaveRule_T__55();
		}
	}
	// $ANTLR end "T__55"

	partial void EnterRule_T__56();
	partial void LeaveRule_T__56();

	// $ANTLR start "T__56"
	[GrammarRule("T__56")]
	private void mT__56()
	{
		EnterRule_T__56();
		EnterRule("T__56", 9);
		TraceIn("T__56", 9);
		try
		{
			int _type = T__56;
			int _channel = DefaultTokenChannel;
			// NCalc.g:15:7: ( '+' )
			DebugEnterAlt(1);
			// NCalc.g:15:9: '+'
			{
			DebugLocation(15, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__56", 9);
			LeaveRule("T__56", 9);
			LeaveRule_T__56();
		}
	}
	// $ANTLR end "T__56"

	partial void EnterRule_T__57();
	partial void LeaveRule_T__57();

	// $ANTLR start "T__57"
	[GrammarRule("T__57")]
	private void mT__57()
	{
		EnterRule_T__57();
		EnterRule("T__57", 10);
		TraceIn("T__57", 10);
		try
		{
			int _type = T__57;
			int _channel = DefaultTokenChannel;
			// NCalc.g:16:7: ( ',' )
			DebugEnterAlt(1);
			// NCalc.g:16:9: ','
			{
			DebugLocation(16, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__57", 10);
			LeaveRule("T__57", 10);
			LeaveRule_T__57();
		}
	}
	// $ANTLR end "T__57"

	partial void EnterRule_T__58();
	partial void LeaveRule_T__58();

	// $ANTLR start "T__58"
	[GrammarRule("T__58")]
	private void mT__58()
	{
		EnterRule_T__58();
		EnterRule("T__58", 11);
		TraceIn("T__58", 11);
		try
		{
			int _type = T__58;
			int _channel = DefaultTokenChannel;
			// NCalc.g:17:7: ( '-' )
			DebugEnterAlt(1);
			// NCalc.g:17:9: '-'
			{
			DebugLocation(17, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__58", 11);
			LeaveRule("T__58", 11);
			LeaveRule_T__58();
		}
	}
	// $ANTLR end "T__58"

	partial void EnterRule_T__59();
	partial void LeaveRule_T__59();

	// $ANTLR start "T__59"
	[GrammarRule("T__59")]
	private void mT__59()
	{
		EnterRule_T__59();
		EnterRule("T__59", 12);
		TraceIn("T__59", 12);
		try
		{
			int _type = T__59;
			int _channel = DefaultTokenChannel;
			// NCalc.g:18:7: ( '/' )
			DebugEnterAlt(1);
			// NCalc.g:18:9: '/'
			{
			DebugLocation(18, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__59", 12);
			LeaveRule("T__59", 12);
			LeaveRule_T__59();
		}
	}
	// $ANTLR end "T__59"

	partial void EnterRule_T__60();
	partial void LeaveRule_T__60();

	// $ANTLR start "T__60"
	[GrammarRule("T__60")]
	private void mT__60()
	{
		EnterRule_T__60();
		EnterRule("T__60", 13);
		TraceIn("T__60", 13);
		try
		{
			int _type = T__60;
			int _channel = DefaultTokenChannel;
			// NCalc.g:19:7: ( ':' )
			DebugEnterAlt(1);
			// NCalc.g:19:9: ':'
			{
			DebugLocation(19, 9);
			Match(':'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__60", 13);
			LeaveRule("T__60", 13);
			LeaveRule_T__60();
		}
	}
	// $ANTLR end "T__60"

	partial void EnterRule_T__61();
	partial void LeaveRule_T__61();

	// $ANTLR start "T__61"
	[GrammarRule("T__61")]
	private void mT__61()
	{
		EnterRule_T__61();
		EnterRule("T__61", 14);
		TraceIn("T__61", 14);
		try
		{
			int _type = T__61;
			int _channel = DefaultTokenChannel;
			// NCalc.g:20:7: ( '<' )
			DebugEnterAlt(1);
			// NCalc.g:20:9: '<'
			{
			DebugLocation(20, 9);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__61", 14);
			LeaveRule("T__61", 14);
			LeaveRule_T__61();
		}
	}
	// $ANTLR end "T__61"

	partial void EnterRule_T__62();
	partial void LeaveRule_T__62();

	// $ANTLR start "T__62"
	[GrammarRule("T__62")]
	private void mT__62()
	{
		EnterRule_T__62();
		EnterRule("T__62", 15);
		TraceIn("T__62", 15);
		try
		{
			int _type = T__62;
			int _channel = DefaultTokenChannel;
			// NCalc.g:21:7: ( '<<' )
			DebugEnterAlt(1);
			// NCalc.g:21:9: '<<'
			{
			DebugLocation(21, 9);
			Match("<<"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__62", 15);
			LeaveRule("T__62", 15);
			LeaveRule_T__62();
		}
	}
	// $ANTLR end "T__62"

	partial void EnterRule_T__63();
	partial void LeaveRule_T__63();

	// $ANTLR start "T__63"
	[GrammarRule("T__63")]
	private void mT__63()
	{
		EnterRule_T__63();
		EnterRule("T__63", 16);
		TraceIn("T__63", 16);
		try
		{
			int _type = T__63;
			int _channel = DefaultTokenChannel;
			// NCalc.g:22:7: ( '<=' )
			DebugEnterAlt(1);
			// NCalc.g:22:9: '<='
			{
			DebugLocation(22, 9);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__63", 16);
			LeaveRule("T__63", 16);
			LeaveRule_T__63();
		}
	}
	// $ANTLR end "T__63"

	partial void EnterRule_T__64();
	partial void LeaveRule_T__64();

	// $ANTLR start "T__64"
	[GrammarRule("T__64")]
	private void mT__64()
	{
		EnterRule_T__64();
		EnterRule("T__64", 17);
		TraceIn("T__64", 17);
		try
		{
			int _type = T__64;
			int _channel = DefaultTokenChannel;
			// NCalc.g:23:7: ( '<>' )
			DebugEnterAlt(1);
			// NCalc.g:23:9: '<>'
			{
			DebugLocation(23, 9);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__64", 17);
			LeaveRule("T__64", 17);
			LeaveRule_T__64();
		}
	}
	// $ANTLR end "T__64"

	partial void EnterRule_T__65();
	partial void LeaveRule_T__65();

	// $ANTLR start "T__65"
	[GrammarRule("T__65")]
	private void mT__65()
	{
		EnterRule_T__65();
		EnterRule("T__65", 18);
		TraceIn("T__65", 18);
		try
		{
			int _type = T__65;
			int _channel = DefaultTokenChannel;
			// NCalc.g:24:7: ( '=' )
			DebugEnterAlt(1);
			// NCalc.g:24:9: '='
			{
			DebugLocation(24, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__65", 18);
			LeaveRule("T__65", 18);
			LeaveRule_T__65();
		}
	}
	// $ANTLR end "T__65"

	partial void EnterRule_T__66();
	partial void LeaveRule_T__66();

	// $ANTLR start "T__66"
	[GrammarRule("T__66")]
	private void mT__66()
	{
		EnterRule_T__66();
		EnterRule("T__66", 19);
		TraceIn("T__66", 19);
		try
		{
			int _type = T__66;
			int _channel = DefaultTokenChannel;
			// NCalc.g:25:7: ( '==' )
			DebugEnterAlt(1);
			// NCalc.g:25:9: '=='
			{
			DebugLocation(25, 9);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__66", 19);
			LeaveRule("T__66", 19);
			LeaveRule_T__66();
		}
	}
	// $ANTLR end "T__66"

	partial void EnterRule_T__67();
	partial void LeaveRule_T__67();

	// $ANTLR start "T__67"
	[GrammarRule("T__67")]
	private void mT__67()
	{
		EnterRule_T__67();
		EnterRule("T__67", 20);
		TraceIn("T__67", 20);
		try
		{
			int _type = T__67;
			int _channel = DefaultTokenChannel;
			// NCalc.g:26:7: ( '>' )
			DebugEnterAlt(1);
			// NCalc.g:26:9: '>'
			{
			DebugLocation(26, 9);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__67", 20);
			LeaveRule("T__67", 20);
			LeaveRule_T__67();
		}
	}
	// $ANTLR end "T__67"

	partial void EnterRule_T__68();
	partial void LeaveRule_T__68();

	// $ANTLR start "T__68"
	[GrammarRule("T__68")]
	private void mT__68()
	{
		EnterRule_T__68();
		EnterRule("T__68", 21);
		TraceIn("T__68", 21);
		try
		{
			int _type = T__68;
			int _channel = DefaultTokenChannel;
			// NCalc.g:27:7: ( '>=' )
			DebugEnterAlt(1);
			// NCalc.g:27:9: '>='
			{
			DebugLocation(27, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__68", 21);
			LeaveRule("T__68", 21);
			LeaveRule_T__68();
		}
	}
	// $ANTLR end "T__68"

	partial void EnterRule_T__69();
	partial void LeaveRule_T__69();

	// $ANTLR start "T__69"
	[GrammarRule("T__69")]
	private void mT__69()
	{
		EnterRule_T__69();
		EnterRule("T__69", 22);
		TraceIn("T__69", 22);
		try
		{
			int _type = T__69;
			int _channel = DefaultTokenChannel;
			// NCalc.g:28:7: ( '>>' )
			DebugEnterAlt(1);
			// NCalc.g:28:9: '>>'
			{
			DebugLocation(28, 9);
			Match(">>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__69", 22);
			LeaveRule("T__69", 22);
			LeaveRule_T__69();
		}
	}
	// $ANTLR end "T__69"

	partial void EnterRule_T__70();
	partial void LeaveRule_T__70();

	// $ANTLR start "T__70"
	[GrammarRule("T__70")]
	private void mT__70()
	{
		EnterRule_T__70();
		EnterRule("T__70", 23);
		TraceIn("T__70", 23);
		try
		{
			int _type = T__70;
			int _channel = DefaultTokenChannel;
			// NCalc.g:29:7: ( '?' )
			DebugEnterAlt(1);
			// NCalc.g:29:9: '?'
			{
			DebugLocation(29, 9);
			Match('?'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__70", 23);
			LeaveRule("T__70", 23);
			LeaveRule_T__70();
		}
	}
	// $ANTLR end "T__70"

	partial void EnterRule_T__71();
	partial void LeaveRule_T__71();

	// $ANTLR start "T__71"
	[GrammarRule("T__71")]
	private void mT__71()
	{
		EnterRule_T__71();
		EnterRule("T__71", 24);
		TraceIn("T__71", 24);
		try
		{
			int _type = T__71;
			int _channel = DefaultTokenChannel;
			// NCalc.g:30:7: ( '^' )
			DebugEnterAlt(1);
			// NCalc.g:30:9: '^'
			{
			DebugLocation(30, 9);
			Match('^'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__71", 24);
			LeaveRule("T__71", 24);
			LeaveRule_T__71();
		}
	}
	// $ANTLR end "T__71"

	partial void EnterRule_T__72();
	partial void LeaveRule_T__72();

	// $ANTLR start "T__72"
	[GrammarRule("T__72")]
	private void mT__72()
	{
		EnterRule_T__72();
		EnterRule("T__72", 25);
		TraceIn("T__72", 25);
		try
		{
			int _type = T__72;
			int _channel = DefaultTokenChannel;
			// NCalc.g:31:7: ( '|' )
			DebugEnterAlt(1);
			// NCalc.g:31:9: '|'
			{
			DebugLocation(31, 9);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__72", 25);
			LeaveRule("T__72", 25);
			LeaveRule_T__72();
		}
	}
	// $ANTLR end "T__72"

	partial void EnterRule_T__73();
	partial void LeaveRule_T__73();

	// $ANTLR start "T__73"
	[GrammarRule("T__73")]
	private void mT__73()
	{
		EnterRule_T__73();
		EnterRule("T__73", 26);
		TraceIn("T__73", 26);
		try
		{
			int _type = T__73;
			int _channel = DefaultTokenChannel;
			// NCalc.g:32:7: ( '||' )
			DebugEnterAlt(1);
			// NCalc.g:32:9: '||'
			{
			DebugLocation(32, 9);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__73", 26);
			LeaveRule("T__73", 26);
			LeaveRule_T__73();
		}
	}
	// $ANTLR end "T__73"

	partial void EnterRule_T__74();
	partial void LeaveRule_T__74();

	// $ANTLR start "T__74"
	[GrammarRule("T__74")]
	private void mT__74()
	{
		EnterRule_T__74();
		EnterRule("T__74", 27);
		TraceIn("T__74", 27);
		try
		{
			int _type = T__74;
			int _channel = DefaultTokenChannel;
			// NCalc.g:33:7: ( '~' )
			DebugEnterAlt(1);
			// NCalc.g:33:9: '~'
			{
			DebugLocation(33, 9);
			Match('~'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__74", 27);
			LeaveRule("T__74", 27);
			LeaveRule_T__74();
		}
	}
	// $ANTLR end "T__74"

	partial void EnterRule_TRUE();
	partial void LeaveRule_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		EnterRule_TRUE();
		EnterRule("TRUE", 28);
		TraceIn("TRUE", 28);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// NCalc.g:237:5: ( T R U E )
			DebugEnterAlt(1);
			// NCalc.g:237:7: T R U E
			{
			DebugLocation(237, 7);
			mT(); 
			DebugLocation(237, 9);
			mR(); 
			DebugLocation(237, 11);
			mU(); 
			DebugLocation(237, 13);
			mE(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 28);
			LeaveRule("TRUE", 28);
			LeaveRule_TRUE();
		}
	}
	// $ANTLR end "TRUE"

	partial void EnterRule_FALSE();
	partial void LeaveRule_FALSE();

	// $ANTLR start "FALSE"
	[GrammarRule("FALSE")]
	private void mFALSE()
	{
		EnterRule_FALSE();
		EnterRule("FALSE", 29);
		TraceIn("FALSE", 29);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// NCalc.g:238:6: ( F A L S E )
			DebugEnterAlt(1);
			// NCalc.g:238:8: F A L S E
			{
			DebugLocation(238, 8);
			mF(); 
			DebugLocation(238, 10);
			mA(); 
			DebugLocation(238, 12);
			mL(); 
			DebugLocation(238, 14);
			mS(); 
			DebugLocation(238, 16);
			mE(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 29);
			LeaveRule("FALSE", 29);
			LeaveRule_FALSE();
		}
	}
	// $ANTLR end "FALSE"

	partial void EnterRule_AND();
	partial void LeaveRule_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		EnterRule_AND();
		EnterRule("AND", 30);
		TraceIn("AND", 30);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// NCalc.g:239:4: ( A N D )
			DebugEnterAlt(1);
			// NCalc.g:239:6: A N D
			{
			DebugLocation(239, 6);
			mA(); 
			DebugLocation(239, 8);
			mN(); 
			DebugLocation(239, 10);
			mD(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 30);
			LeaveRule("AND", 30);
			LeaveRule_AND();
		}
	}
	// $ANTLR end "AND"

	partial void EnterRule_OR();
	partial void LeaveRule_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		EnterRule_OR();
		EnterRule("OR", 31);
		TraceIn("OR", 31);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// NCalc.g:240:3: ( O R )
			DebugEnterAlt(1);
			// NCalc.g:240:5: O R
			{
			DebugLocation(240, 5);
			mO(); 
			DebugLocation(240, 7);
			mR(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 31);
			LeaveRule("OR", 31);
			LeaveRule_OR();
		}
	}
	// $ANTLR end "OR"

	partial void EnterRule_NOT();
	partial void LeaveRule_NOT();

	// $ANTLR start "NOT"
	[GrammarRule("NOT")]
	private void mNOT()
	{
		EnterRule_NOT();
		EnterRule("NOT", 32);
		TraceIn("NOT", 32);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// NCalc.g:241:4: ( N O T )
			DebugEnterAlt(1);
			// NCalc.g:241:6: N O T
			{
			DebugLocation(241, 6);
			mN(); 
			DebugLocation(241, 8);
			mO(); 
			DebugLocation(241, 10);
			mT(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 32);
			LeaveRule("NOT", 32);
			LeaveRule_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void EnterRule_ID();
	partial void LeaveRule_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		EnterRule_ID();
		EnterRule("ID", 33);
		TraceIn("ID", 33);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// NCalc.g:244:2: ( LETTER ( LETTER | DIGIT )* )
			DebugEnterAlt(1);
			// NCalc.g:244:5: LETTER ( LETTER | DIGIT )*
			{
			DebugLocation(244, 5);
			mLETTER(); 
			DebugLocation(244, 12);
			// NCalc.g:244:12: ( LETTER | DIGIT )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_1 = input.LA(1);

				if (((LA1_1>='0' && LA1_1<='9')||(LA1_1>='A' && LA1_1<='Z')||LA1_1=='_'||(LA1_1>='a' && LA1_1<='z')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:
					{
					DebugLocation(244, 12);
					input.Consume();


					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 33);
			LeaveRule("ID", 33);
			LeaveRule_ID();
		}
	}
	// $ANTLR end "ID"

	partial void EnterRule_INTEGER();
	partial void LeaveRule_INTEGER();

	// $ANTLR start "INTEGER"
	[GrammarRule("INTEGER")]
	private void mINTEGER()
	{
		EnterRule_INTEGER();
		EnterRule("INTEGER", 34);
		TraceIn("INTEGER", 34);
		try
		{
			int _type = INTEGER;
			int _channel = DefaultTokenChannel;
			// NCalc.g:248:2: ( ( DIGIT )+ )
			DebugEnterAlt(1);
			// NCalc.g:248:4: ( DIGIT )+
			{
			DebugLocation(248, 4);
			// NCalc.g:248:4: ( DIGIT )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_1 = input.LA(1);

				if (((LA2_1>='0' && LA2_1<='9')))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:
					{
					DebugLocation(248, 4);
					input.Consume();


					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INTEGER", 34);
			LeaveRule("INTEGER", 34);
			LeaveRule_INTEGER();
		}
	}
	// $ANTLR end "INTEGER"

	partial void EnterRule_FLOAT();
	partial void LeaveRule_FLOAT();

	// $ANTLR start "FLOAT"
	[GrammarRule("FLOAT")]
	private void mFLOAT()
	{
		EnterRule_FLOAT();
		EnterRule("FLOAT", 35);
		TraceIn("FLOAT", 35);
		try
		{
			int _type = FLOAT;
			int _channel = DefaultTokenChannel;
			// NCalc.g:252:2: ( ( DIGIT )* '.' ( DIGIT )+ ( EXPONENT )? | ( DIGIT )+ EXPONENT )
			int alt7=2;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			try
			{
				alt7 = dfa7.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:252:4: ( DIGIT )* '.' ( DIGIT )+ ( EXPONENT )?
				{
				DebugLocation(252, 4);
				// NCalc.g:252:4: ( DIGIT )*
				try { DebugEnterSubRule(3);
				while (true)
				{
					int alt3=2;
					try { DebugEnterDecision(3, decisionCanBacktrack[3]);
					int LA3_1 = input.LA(1);

					if (((LA3_1>='0' && LA3_1<='9')))
					{
						alt3 = 1;
					}


					} finally { DebugExitDecision(3); }
					switch ( alt3 )
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:
						{
						DebugLocation(252, 4);
						input.Consume();


						}
						break;

					default:
						goto loop3;
					}
				}

				loop3:
					;

				} finally { DebugExitSubRule(3); }

				DebugLocation(252, 11);
				Match('.'); 
				DebugLocation(252, 15);
				// NCalc.g:252:15: ( DIGIT )+
				int cnt4=0;
				try { DebugEnterSubRule(4);
				while (true)
				{
					int alt4=2;
					try { DebugEnterDecision(4, decisionCanBacktrack[4]);
					int LA4_1 = input.LA(1);

					if (((LA4_1>='0' && LA4_1<='9')))
					{
						alt4 = 1;
					}


					} finally { DebugExitDecision(4); }
					switch (alt4)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:
						{
						DebugLocation(252, 15);
						input.Consume();


						}
						break;

					default:
						if (cnt4 >= 1)
							goto loop4;

						EarlyExitException eee4 = new EarlyExitException( 4, input );
						DebugRecognitionException(eee4);
						throw eee4;
					}
					cnt4++;
				}
				loop4:
					;

				} finally { DebugExitSubRule(4); }

				DebugLocation(252, 22);
				// NCalc.g:252:22: ( EXPONENT )?
				int alt5=2;
				try { DebugEnterSubRule(5);
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_1 = input.LA(1);

				if ((LA5_1=='E'||LA5_1=='e'))
				{
					alt5 = 1;
				}
				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:252:22: EXPONENT
					{
					DebugLocation(252, 22);
					mEXPONENT(); 

					}
					break;

				}
				} finally { DebugExitSubRule(5); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:253:4: ( DIGIT )+ EXPONENT
				{
				DebugLocation(253, 4);
				// NCalc.g:253:4: ( DIGIT )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_1 = input.LA(1);

					if (((LA6_1>='0' && LA6_1<='9')))
					{
						alt6 = 1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:
						{
						DebugLocation(253, 4);
						input.Consume();


						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }

				DebugLocation(253, 11);
				mEXPONENT(); 

				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FLOAT", 35);
			LeaveRule("FLOAT", 35);
			LeaveRule_FLOAT();
		}
	}
	// $ANTLR end "FLOAT"

	partial void EnterRule_STRING();
	partial void LeaveRule_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		EnterRule_STRING();
		EnterRule("STRING", 36);
		TraceIn("STRING", 36);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// NCalc.g:257:6: ( '\\'' ( EscapeSequence | ( options {greedy=false; } :~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\'' ) ) )* '\\'' )
			DebugEnterAlt(1);
			// NCalc.g:257:10: '\\'' ( EscapeSequence | ( options {greedy=false; } :~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\'' ) ) )* '\\''
			{
			DebugLocation(257, 10);
			Match('\''); 
			DebugLocation(257, 15);
			// NCalc.g:257:15: ( EscapeSequence | ( options {greedy=false; } :~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\'' ) ) )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=3;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_1 = input.LA(1);

				if ((LA8_1=='\\'))
				{
					alt8 = 1;
				}
				else if (((LA8_1>=' ' && LA8_1<='&')||(LA8_1>='(' && LA8_1<='[')||(LA8_1>=']' && LA8_1<='\uFFFF')))
				{
					alt8 = 2;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:257:17: EscapeSequence
					{
					DebugLocation(257, 17);
					mEscapeSequence(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// NCalc.g:257:34: ( options {greedy=false; } :~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\'' ) )
					{
					DebugLocation(257, 34);
					// NCalc.g:257:34: ( options {greedy=false; } :~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\'' ) )
					DebugEnterAlt(1);
					// NCalc.g:257:61: ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\'' )
					{
					DebugLocation(257, 61);
					input.Consume();


					}


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }

			DebugLocation(257, 103);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 36);
			LeaveRule("STRING", 36);
			LeaveRule_STRING();
		}
	}
	// $ANTLR end "STRING"

	partial void EnterRule_DATETIME();
	partial void LeaveRule_DATETIME();

	// $ANTLR start "DATETIME"
	[GrammarRule("DATETIME")]
	private void mDATETIME()
	{
		EnterRule_DATETIME();
		EnterRule("DATETIME", 37);
		TraceIn("DATETIME", 37);
		try
		{
			int _type = DATETIME;
			int _channel = DefaultTokenChannel;
			// NCalc.g:261:3: ( '#' ( options {greedy=false; } : (~ ( '#' ) )* ) '#' )
			DebugEnterAlt(1);
			// NCalc.g:261:5: '#' ( options {greedy=false; } : (~ ( '#' ) )* ) '#'
			{
			DebugLocation(261, 5);
			Match('#'); 
			DebugLocation(261, 9);
			// NCalc.g:261:9: ( options {greedy=false; } : (~ ( '#' ) )* )
			DebugEnterAlt(1);
			// NCalc.g:261:36: (~ ( '#' ) )*
			{
			DebugLocation(261, 36);
			// NCalc.g:261:36: (~ ( '#' ) )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_1 = input.LA(1);

				if (((LA9_1>='\u0000' && LA9_1<='\"')||(LA9_1>='$' && LA9_1<='\uFFFF')))
				{
					alt9 = 1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:
					{
					DebugLocation(261, 36);
					input.Consume();


					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }


			}

			DebugLocation(261, 45);
			Match('#'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DATETIME", 37);
			LeaveRule("DATETIME", 37);
			LeaveRule_DATETIME();
		}
	}
	// $ANTLR end "DATETIME"

	partial void EnterRule_NAME();
	partial void LeaveRule_NAME();

	// $ANTLR start "NAME"
	[GrammarRule("NAME")]
	private void mNAME()
	{
		EnterRule_NAME();
		EnterRule("NAME", 38);
		TraceIn("NAME", 38);
		try
		{
			int _type = NAME;
			int _channel = DefaultTokenChannel;
			// NCalc.g:264:6: ( '[' ( options {greedy=false; } : (~ ( ']' ) )* ) ']' )
			DebugEnterAlt(1);
			// NCalc.g:264:8: '[' ( options {greedy=false; } : (~ ( ']' ) )* ) ']'
			{
			DebugLocation(264, 8);
			Match('['); 
			DebugLocation(264, 12);
			// NCalc.g:264:12: ( options {greedy=false; } : (~ ( ']' ) )* )
			DebugEnterAlt(1);
			// NCalc.g:264:39: (~ ( ']' ) )*
			{
			DebugLocation(264, 39);
			// NCalc.g:264:39: (~ ( ']' ) )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_1 = input.LA(1);

				if (((LA10_1>='\u0000' && LA10_1<='\\')||(LA10_1>='^' && LA10_1<='\uFFFF')))
				{
					alt10 = 1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:
					{
					DebugLocation(264, 39);
					input.Consume();


					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }


			}

			DebugLocation(264, 48);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NAME", 38);
			LeaveRule("NAME", 38);
			LeaveRule_NAME();
		}
	}
	// $ANTLR end "NAME"

	partial void EnterRule_EXPONENT();
	partial void LeaveRule_EXPONENT();

	// $ANTLR start "EXPONENT"
	[GrammarRule("EXPONENT")]
	private void mEXPONENT()
	{
		EnterRule_EXPONENT();
		EnterRule("EXPONENT", 39);
		TraceIn("EXPONENT", 39);
		try
		{
			int _type = EXPONENT;
			int _channel = DefaultTokenChannel;
			// NCalc.g:268:2: ( ( 'E' | 'e' ) ( '+' | '-' )? ( DIGIT )+ )
			DebugEnterAlt(1);
			// NCalc.g:268:4: ( 'E' | 'e' ) ( '+' | '-' )? ( DIGIT )+
			{
			DebugLocation(268, 4);
			if (input.LA(1)=='E'||input.LA(1)=='e')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}

			DebugLocation(268, 14);
			// NCalc.g:268:14: ( '+' | '-' )?
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_1 = input.LA(1);

			if ((LA11_1=='+'||LA11_1=='-'))
			{
				alt11 = 1;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:
				{
				DebugLocation(268, 14);
				input.Consume();


				}
				break;

			}
			} finally { DebugExitSubRule(11); }

			DebugLocation(268, 25);
			// NCalc.g:268:25: ( DIGIT )+
			int cnt12=0;
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_1 = input.LA(1);

				if (((LA12_1>='0' && LA12_1<='9')))
				{
					alt12 = 1;
				}


				} finally { DebugExitDecision(12); }
				switch (alt12)
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:
					{
					DebugLocation(268, 25);
					input.Consume();


					}
					break;

				default:
					if (cnt12 >= 1)
						goto loop12;

					EarlyExitException eee12 = new EarlyExitException( 12, input );
					DebugRecognitionException(eee12);
					throw eee12;
				}
				cnt12++;
			}
			loop12:
				;

			} finally { DebugExitSubRule(12); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EXPONENT", 39);
			LeaveRule("EXPONENT", 39);
			LeaveRule_EXPONENT();
		}
	}
	// $ANTLR end "EXPONENT"

	partial void EnterRule_LETTER();
	partial void LeaveRule_LETTER();

	// $ANTLR start "LETTER"
	[GrammarRule("LETTER")]
	private void mLETTER()
	{
		EnterRule_LETTER();
		EnterRule("LETTER", 40);
		TraceIn("LETTER", 40);
		try
		{
			// NCalc.g:272:2: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(272, 2);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("LETTER", 40);
			LeaveRule("LETTER", 40);
			LeaveRule_LETTER();
		}
	}
	// $ANTLR end "LETTER"

	partial void EnterRule_DIGIT();
	partial void LeaveRule_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		EnterRule_DIGIT();
		EnterRule("DIGIT", 41);
		TraceIn("DIGIT", 41);
		try
		{
			// NCalc.g:278:2: ( '0' .. '9' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(278, 2);
			if ((input.LA(1)>='0' && input.LA(1)<='9'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("DIGIT", 41);
			LeaveRule("DIGIT", 41);
			LeaveRule_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	partial void EnterRule_EscapeSequence();
	partial void LeaveRule_EscapeSequence();

	// $ANTLR start "EscapeSequence"
	[GrammarRule("EscapeSequence")]
	private void mEscapeSequence()
	{
		EnterRule_EscapeSequence();
		EnterRule("EscapeSequence", 42);
		TraceIn("EscapeSequence", 42);
		try
		{
			// NCalc.g:282:2: ( '\\\\' ( 'n' | 'r' | 't' | '\\'' | '\\\\' | UnicodeEscape ) )
			DebugEnterAlt(1);
			// NCalc.g:282:4: '\\\\' ( 'n' | 'r' | 't' | '\\'' | '\\\\' | UnicodeEscape )
			{
			DebugLocation(282, 4);
			Match('\\'); 
			DebugLocation(283, 4);
			// NCalc.g:283:4: ( 'n' | 'r' | 't' | '\\'' | '\\\\' | UnicodeEscape )
			int alt13=6;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			switch (input.LA(1))
			{
			case 'n':
				{
				alt13 = 1;
				}
				break;
			case 'r':
				{
				alt13 = 2;
				}
				break;
			case 't':
				{
				alt13 = 3;
				}
				break;
			case '\'':
				{
				alt13 = 4;
				}
				break;
			case '\\':
				{
				alt13 = 5;
				}
				break;
			case 'u':
				{
				alt13 = 6;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 13, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:284:5: 'n'
				{
				DebugLocation(284, 5);
				Match('n'); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:285:4: 'r'
				{
				DebugLocation(285, 4);
				Match('r'); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// NCalc.g:286:4: 't'
				{
				DebugLocation(286, 4);
				Match('t'); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// NCalc.g:287:4: '\\''
				{
				DebugLocation(287, 4);
				Match('\''); 

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// NCalc.g:288:4: '\\\\'
				{
				DebugLocation(288, 4);
				Match('\\'); 

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// NCalc.g:289:4: UnicodeEscape
				{
				DebugLocation(289, 4);
				mUnicodeEscape(); 

				}
				break;

			}
			} finally { DebugExitSubRule(13); }


			}

		}
		finally
		{
			TraceOut("EscapeSequence", 42);
			LeaveRule("EscapeSequence", 42);
			LeaveRule_EscapeSequence();
		}
	}
	// $ANTLR end "EscapeSequence"

	partial void EnterRule_HexDigit();
	partial void LeaveRule_HexDigit();

	// $ANTLR start "HexDigit"
	[GrammarRule("HexDigit")]
	private void mHexDigit()
	{
		EnterRule_HexDigit();
		EnterRule("HexDigit", 43);
		TraceIn("HexDigit", 43);
		try
		{
			// NCalc.g:294:2: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(294, 2);
			if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='F')||(input.LA(1)>='a' && input.LA(1)<='f'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("HexDigit", 43);
			LeaveRule("HexDigit", 43);
			LeaveRule_HexDigit();
		}
	}
	// $ANTLR end "HexDigit"

	partial void EnterRule_UnicodeEscape();
	partial void LeaveRule_UnicodeEscape();

	// $ANTLR start "UnicodeEscape"
	[GrammarRule("UnicodeEscape")]
	private void mUnicodeEscape()
	{
		EnterRule_UnicodeEscape();
		EnterRule("UnicodeEscape", 44);
		TraceIn("UnicodeEscape", 44);
		try
		{
			// NCalc.g:298:6: ( 'u' HexDigit HexDigit HexDigit HexDigit )
			DebugEnterAlt(1);
			// NCalc.g:298:12: 'u' HexDigit HexDigit HexDigit HexDigit
			{
			DebugLocation(298, 12);
			Match('u'); 
			DebugLocation(298, 16);
			mHexDigit(); 
			DebugLocation(298, 25);
			mHexDigit(); 
			DebugLocation(298, 34);
			mHexDigit(); 
			DebugLocation(298, 43);
			mHexDigit(); 

			}

		}
		finally
		{
			TraceOut("UnicodeEscape", 44);
			LeaveRule("UnicodeEscape", 44);
			LeaveRule_UnicodeEscape();
		}
	}
	// $ANTLR end "UnicodeEscape"

	partial void EnterRule_WS();
	partial void LeaveRule_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		EnterRule_WS();
		EnterRule("WS", 45);
		TraceIn("WS", 45);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// NCalc.g:302:4: ( ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' ) )
			DebugEnterAlt(1);
			// NCalc.g:302:7: ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' )
			{
			DebugLocation(302, 7);
			if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}

			DebugLocation(302, 37);
			_channel=Hidden;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 45);
			LeaveRule("WS", 45);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	partial void EnterRule_A();
	partial void LeaveRule_A();

	// $ANTLR start "A"
	[GrammarRule("A")]
	private void mA()
	{
		EnterRule_A();
		EnterRule("A", 46);
		TraceIn("A", 46);
		try
		{
			// NCalc.g:308:11: ( 'a' | 'A' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(308, 11);
			if (input.LA(1)=='A'||input.LA(1)=='a')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("A", 46);
			LeaveRule("A", 46);
			LeaveRule_A();
		}
	}
	// $ANTLR end "A"

	partial void EnterRule_B();
	partial void LeaveRule_B();

	// $ANTLR start "B"
	[GrammarRule("B")]
	private void mB()
	{
		EnterRule_B();
		EnterRule("B", 47);
		TraceIn("B", 47);
		try
		{
			// NCalc.g:309:11: ( 'b' | 'B' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(309, 11);
			if (input.LA(1)=='B'||input.LA(1)=='b')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("B", 47);
			LeaveRule("B", 47);
			LeaveRule_B();
		}
	}
	// $ANTLR end "B"

	partial void EnterRule_C();
	partial void LeaveRule_C();

	// $ANTLR start "C"
	[GrammarRule("C")]
	private void mC()
	{
		EnterRule_C();
		EnterRule("C", 48);
		TraceIn("C", 48);
		try
		{
			// NCalc.g:310:11: ( 'c' | 'C' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(310, 11);
			if (input.LA(1)=='C'||input.LA(1)=='c')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("C", 48);
			LeaveRule("C", 48);
			LeaveRule_C();
		}
	}
	// $ANTLR end "C"

	partial void EnterRule_D();
	partial void LeaveRule_D();

	// $ANTLR start "D"
	[GrammarRule("D")]
	private void mD()
	{
		EnterRule_D();
		EnterRule("D", 49);
		TraceIn("D", 49);
		try
		{
			// NCalc.g:311:11: ( 'd' | 'D' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(311, 11);
			if (input.LA(1)=='D'||input.LA(1)=='d')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("D", 49);
			LeaveRule("D", 49);
			LeaveRule_D();
		}
	}
	// $ANTLR end "D"

	partial void EnterRule_E();
	partial void LeaveRule_E();

	// $ANTLR start "E"
	[GrammarRule("E")]
	private void mE()
	{
		EnterRule_E();
		EnterRule("E", 50);
		TraceIn("E", 50);
		try
		{
			// NCalc.g:312:11: ( 'e' | 'E' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(312, 11);
			if (input.LA(1)=='E'||input.LA(1)=='e')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("E", 50);
			LeaveRule("E", 50);
			LeaveRule_E();
		}
	}
	// $ANTLR end "E"

	partial void EnterRule_F();
	partial void LeaveRule_F();

	// $ANTLR start "F"
	[GrammarRule("F")]
	private void mF()
	{
		EnterRule_F();
		EnterRule("F", 51);
		TraceIn("F", 51);
		try
		{
			// NCalc.g:313:11: ( 'f' | 'F' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(313, 11);
			if (input.LA(1)=='F'||input.LA(1)=='f')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("F", 51);
			LeaveRule("F", 51);
			LeaveRule_F();
		}
	}
	// $ANTLR end "F"

	partial void EnterRule_G();
	partial void LeaveRule_G();

	// $ANTLR start "G"
	[GrammarRule("G")]
	private void mG()
	{
		EnterRule_G();
		EnterRule("G", 52);
		TraceIn("G", 52);
		try
		{
			// NCalc.g:314:11: ( 'g' | 'G' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(314, 11);
			if (input.LA(1)=='G'||input.LA(1)=='g')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("G", 52);
			LeaveRule("G", 52);
			LeaveRule_G();
		}
	}
	// $ANTLR end "G"

	partial void EnterRule_H();
	partial void LeaveRule_H();

	// $ANTLR start "H"
	[GrammarRule("H")]
	private void mH()
	{
		EnterRule_H();
		EnterRule("H", 53);
		TraceIn("H", 53);
		try
		{
			// NCalc.g:315:11: ( 'h' | 'H' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(315, 11);
			if (input.LA(1)=='H'||input.LA(1)=='h')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("H", 53);
			LeaveRule("H", 53);
			LeaveRule_H();
		}
	}
	// $ANTLR end "H"

	partial void EnterRule_I();
	partial void LeaveRule_I();

	// $ANTLR start "I"
	[GrammarRule("I")]
	private void mI()
	{
		EnterRule_I();
		EnterRule("I", 54);
		TraceIn("I", 54);
		try
		{
			// NCalc.g:316:11: ( 'i' | 'I' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(316, 11);
			if (input.LA(1)=='I'||input.LA(1)=='i')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("I", 54);
			LeaveRule("I", 54);
			LeaveRule_I();
		}
	}
	// $ANTLR end "I"

	partial void EnterRule_J();
	partial void LeaveRule_J();

	// $ANTLR start "J"
	[GrammarRule("J")]
	private void mJ()
	{
		EnterRule_J();
		EnterRule("J", 55);
		TraceIn("J", 55);
		try
		{
			// NCalc.g:317:11: ( 'j' | 'J' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(317, 11);
			if (input.LA(1)=='J'||input.LA(1)=='j')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("J", 55);
			LeaveRule("J", 55);
			LeaveRule_J();
		}
	}
	// $ANTLR end "J"

	partial void EnterRule_K();
	partial void LeaveRule_K();

	// $ANTLR start "K"
	[GrammarRule("K")]
	private void mK()
	{
		EnterRule_K();
		EnterRule("K", 56);
		TraceIn("K", 56);
		try
		{
			// NCalc.g:318:11: ( 'k' | 'K' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(318, 11);
			if (input.LA(1)=='K'||input.LA(1)=='k')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("K", 56);
			LeaveRule("K", 56);
			LeaveRule_K();
		}
	}
	// $ANTLR end "K"

	partial void EnterRule_L();
	partial void LeaveRule_L();

	// $ANTLR start "L"
	[GrammarRule("L")]
	private void mL()
	{
		EnterRule_L();
		EnterRule("L", 57);
		TraceIn("L", 57);
		try
		{
			// NCalc.g:319:11: ( 'l' | 'L' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(319, 11);
			if (input.LA(1)=='L'||input.LA(1)=='l')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("L", 57);
			LeaveRule("L", 57);
			LeaveRule_L();
		}
	}
	// $ANTLR end "L"

	partial void EnterRule_M();
	partial void LeaveRule_M();

	// $ANTLR start "M"
	[GrammarRule("M")]
	private void mM()
	{
		EnterRule_M();
		EnterRule("M", 58);
		TraceIn("M", 58);
		try
		{
			// NCalc.g:320:11: ( 'm' | 'M' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(320, 11);
			if (input.LA(1)=='M'||input.LA(1)=='m')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("M", 58);
			LeaveRule("M", 58);
			LeaveRule_M();
		}
	}
	// $ANTLR end "M"

	partial void EnterRule_N();
	partial void LeaveRule_N();

	// $ANTLR start "N"
	[GrammarRule("N")]
	private void mN()
	{
		EnterRule_N();
		EnterRule("N", 59);
		TraceIn("N", 59);
		try
		{
			// NCalc.g:321:11: ( 'n' | 'N' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(321, 11);
			if (input.LA(1)=='N'||input.LA(1)=='n')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("N", 59);
			LeaveRule("N", 59);
			LeaveRule_N();
		}
	}
	// $ANTLR end "N"

	partial void EnterRule_O();
	partial void LeaveRule_O();

	// $ANTLR start "O"
	[GrammarRule("O")]
	private void mO()
	{
		EnterRule_O();
		EnterRule("O", 60);
		TraceIn("O", 60);
		try
		{
			// NCalc.g:322:11: ( 'o' | 'O' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(322, 11);
			if (input.LA(1)=='O'||input.LA(1)=='o')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("O", 60);
			LeaveRule("O", 60);
			LeaveRule_O();
		}
	}
	// $ANTLR end "O"

	partial void EnterRule_P();
	partial void LeaveRule_P();

	// $ANTLR start "P"
	[GrammarRule("P")]
	private void mP()
	{
		EnterRule_P();
		EnterRule("P", 61);
		TraceIn("P", 61);
		try
		{
			// NCalc.g:323:11: ( 'p' | 'P' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(323, 11);
			if (input.LA(1)=='P'||input.LA(1)=='p')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("P", 61);
			LeaveRule("P", 61);
			LeaveRule_P();
		}
	}
	// $ANTLR end "P"

	partial void EnterRule_Q();
	partial void LeaveRule_Q();

	// $ANTLR start "Q"
	[GrammarRule("Q")]
	private void mQ()
	{
		EnterRule_Q();
		EnterRule("Q", 62);
		TraceIn("Q", 62);
		try
		{
			// NCalc.g:324:11: ( 'q' | 'Q' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(324, 11);
			if (input.LA(1)=='Q'||input.LA(1)=='q')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("Q", 62);
			LeaveRule("Q", 62);
			LeaveRule_Q();
		}
	}
	// $ANTLR end "Q"

	partial void EnterRule_R();
	partial void LeaveRule_R();

	// $ANTLR start "R"
	[GrammarRule("R")]
	private void mR()
	{
		EnterRule_R();
		EnterRule("R", 63);
		TraceIn("R", 63);
		try
		{
			// NCalc.g:325:11: ( 'r' | 'R' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(325, 11);
			if (input.LA(1)=='R'||input.LA(1)=='r')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("R", 63);
			LeaveRule("R", 63);
			LeaveRule_R();
		}
	}
	// $ANTLR end "R"

	partial void EnterRule_S();
	partial void LeaveRule_S();

	// $ANTLR start "S"
	[GrammarRule("S")]
	private void mS()
	{
		EnterRule_S();
		EnterRule("S", 64);
		TraceIn("S", 64);
		try
		{
			// NCalc.g:326:11: ( 's' | 'S' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(326, 11);
			if (input.LA(1)=='S'||input.LA(1)=='s')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("S", 64);
			LeaveRule("S", 64);
			LeaveRule_S();
		}
	}
	// $ANTLR end "S"

	partial void EnterRule_T();
	partial void LeaveRule_T();

	// $ANTLR start "T"
	[GrammarRule("T")]
	private void mT()
	{
		EnterRule_T();
		EnterRule("T", 65);
		TraceIn("T", 65);
		try
		{
			// NCalc.g:327:11: ( 't' | 'T' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(327, 11);
			if (input.LA(1)=='T'||input.LA(1)=='t')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("T", 65);
			LeaveRule("T", 65);
			LeaveRule_T();
		}
	}
	// $ANTLR end "T"

	partial void EnterRule_U();
	partial void LeaveRule_U();

	// $ANTLR start "U"
	[GrammarRule("U")]
	private void mU()
	{
		EnterRule_U();
		EnterRule("U", 66);
		TraceIn("U", 66);
		try
		{
			// NCalc.g:328:11: ( 'u' | 'U' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(328, 11);
			if (input.LA(1)=='U'||input.LA(1)=='u')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("U", 66);
			LeaveRule("U", 66);
			LeaveRule_U();
		}
	}
	// $ANTLR end "U"

	partial void EnterRule_V();
	partial void LeaveRule_V();

	// $ANTLR start "V"
	[GrammarRule("V")]
	private void mV()
	{
		EnterRule_V();
		EnterRule("V", 67);
		TraceIn("V", 67);
		try
		{
			// NCalc.g:329:11: ( 'v' | 'V' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(329, 11);
			if (input.LA(1)=='V'||input.LA(1)=='v')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("V", 67);
			LeaveRule("V", 67);
			LeaveRule_V();
		}
	}
	// $ANTLR end "V"

	partial void EnterRule_W();
	partial void LeaveRule_W();

	// $ANTLR start "W"
	[GrammarRule("W")]
	private void mW()
	{
		EnterRule_W();
		EnterRule("W", 68);
		TraceIn("W", 68);
		try
		{
			// NCalc.g:330:11: ( 'w' | 'W' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(330, 11);
			if (input.LA(1)=='W'||input.LA(1)=='w')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("W", 68);
			LeaveRule("W", 68);
			LeaveRule_W();
		}
	}
	// $ANTLR end "W"

	partial void EnterRule_X();
	partial void LeaveRule_X();

	// $ANTLR start "X"
	[GrammarRule("X")]
	private void mX()
	{
		EnterRule_X();
		EnterRule("X", 69);
		TraceIn("X", 69);
		try
		{
			// NCalc.g:331:11: ( 'x' | 'X' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(331, 11);
			if (input.LA(1)=='X'||input.LA(1)=='x')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("X", 69);
			LeaveRule("X", 69);
			LeaveRule_X();
		}
	}
	// $ANTLR end "X"

	partial void EnterRule_Y();
	partial void LeaveRule_Y();

	// $ANTLR start "Y"
	[GrammarRule("Y")]
	private void mY()
	{
		EnterRule_Y();
		EnterRule("Y", 70);
		TraceIn("Y", 70);
		try
		{
			// NCalc.g:332:11: ( 'y' | 'Y' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(332, 11);
			if (input.LA(1)=='Y'||input.LA(1)=='y')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("Y", 70);
			LeaveRule("Y", 70);
			LeaveRule_Y();
		}
	}
	// $ANTLR end "Y"

	partial void EnterRule_Z();
	partial void LeaveRule_Z();

	// $ANTLR start "Z"
	[GrammarRule("Z")]
	private void mZ()
	{
		EnterRule_Z();
		EnterRule("Z", 71);
		TraceIn("Z", 71);
		try
		{
			// NCalc.g:333:11: ( 'z' | 'Z' )
			DebugEnterAlt(1);
			// NCalc.g:
			{
			DebugLocation(333, 11);
			if (input.LA(1)=='Z'||input.LA(1)=='z')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("Z", 71);
			LeaveRule("Z", 71);
			LeaveRule_Z();
		}
	}
	// $ANTLR end "Z"

	public override void mTokens()
	{
		// NCalc.g:1:8: ( T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | TRUE | FALSE | AND | OR | NOT | ID | INTEGER | FLOAT | STRING | DATETIME | NAME | EXPONENT | WS )
		int alt14=40;
		try { DebugEnterDecision(14, decisionCanBacktrack[14]);
		try
		{
			alt14 = dfa14.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(14); }
		switch (alt14)
		{
		case 1:
			DebugEnterAlt(1);
			// NCalc.g:1:10: T__48
			{
			DebugLocation(1, 10);
			mT__48(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// NCalc.g:1:16: T__49
			{
			DebugLocation(1, 16);
			mT__49(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// NCalc.g:1:22: T__50
			{
			DebugLocation(1, 22);
			mT__50(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// NCalc.g:1:28: T__51
			{
			DebugLocation(1, 28);
			mT__51(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// NCalc.g:1:34: T__52
			{
			DebugLocation(1, 34);
			mT__52(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// NCalc.g:1:40: T__53
			{
			DebugLocation(1, 40);
			mT__53(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// NCalc.g:1:46: T__54
			{
			DebugLocation(1, 46);
			mT__54(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// NCalc.g:1:52: T__55
			{
			DebugLocation(1, 52);
			mT__55(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// NCalc.g:1:58: T__56
			{
			DebugLocation(1, 58);
			mT__56(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// NCalc.g:1:64: T__57
			{
			DebugLocation(1, 64);
			mT__57(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// NCalc.g:1:70: T__58
			{
			DebugLocation(1, 70);
			mT__58(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// NCalc.g:1:76: T__59
			{
			DebugLocation(1, 76);
			mT__59(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// NCalc.g:1:82: T__60
			{
			DebugLocation(1, 82);
			mT__60(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// NCalc.g:1:88: T__61
			{
			DebugLocation(1, 88);
			mT__61(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// NCalc.g:1:94: T__62
			{
			DebugLocation(1, 94);
			mT__62(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// NCalc.g:1:100: T__63
			{
			DebugLocation(1, 100);
			mT__63(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// NCalc.g:1:106: T__64
			{
			DebugLocation(1, 106);
			mT__64(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// NCalc.g:1:112: T__65
			{
			DebugLocation(1, 112);
			mT__65(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// NCalc.g:1:118: T__66
			{
			DebugLocation(1, 118);
			mT__66(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// NCalc.g:1:124: T__67
			{
			DebugLocation(1, 124);
			mT__67(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// NCalc.g:1:130: T__68
			{
			DebugLocation(1, 130);
			mT__68(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// NCalc.g:1:136: T__69
			{
			DebugLocation(1, 136);
			mT__69(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// NCalc.g:1:142: T__70
			{
			DebugLocation(1, 142);
			mT__70(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// NCalc.g:1:148: T__71
			{
			DebugLocation(1, 148);
			mT__71(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// NCalc.g:1:154: T__72
			{
			DebugLocation(1, 154);
			mT__72(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// NCalc.g:1:160: T__73
			{
			DebugLocation(1, 160);
			mT__73(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// NCalc.g:1:166: T__74
			{
			DebugLocation(1, 166);
			mT__74(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// NCalc.g:1:172: TRUE
			{
			DebugLocation(1, 172);
			mTRUE(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// NCalc.g:1:177: FALSE
			{
			DebugLocation(1, 177);
			mFALSE(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// NCalc.g:1:183: AND
			{
			DebugLocation(1, 183);
			mAND(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// NCalc.g:1:187: OR
			{
			DebugLocation(1, 187);
			mOR(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// NCalc.g:1:190: NOT
			{
			DebugLocation(1, 190);
			mNOT(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// NCalc.g:1:194: ID
			{
			DebugLocation(1, 194);
			mID(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// NCalc.g:1:197: INTEGER
			{
			DebugLocation(1, 197);
			mINTEGER(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// NCalc.g:1:205: FLOAT
			{
			DebugLocation(1, 205);
			mFLOAT(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// NCalc.g:1:211: STRING
			{
			DebugLocation(1, 211);
			mSTRING(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// NCalc.g:1:218: DATETIME
			{
			DebugLocation(1, 218);
			mDATETIME(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// NCalc.g:1:227: NAME
			{
			DebugLocation(1, 227);
			mNAME(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// NCalc.g:1:232: EXPONENT
			{
			DebugLocation(1, 232);
			mEXPONENT(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// NCalc.g:1:241: WS
			{
			DebugLocation(1, 241);
			mWS(); 

			}
			break;

		}

	}


	#region DFA
	DFA7 dfa7;
	DFA14 dfa14;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa7 = new DFA7(this);
		dfa14 = new DFA14(this);
	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\x4\xFFFF";
		private const string DFA7_eofS =
			"\x4\xFFFF";
		private const string DFA7_minS =
			"\x2\x2E\x2\xFFFF";
		private const string DFA7_maxS =
			"\x1\x39\x1\x65\x2\xFFFF";
		private const string DFA7_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2";
		private const string DFA7_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x1\x2\x1\xFFFF\xA\x1",
				"\x1\x2\x1\xFFFF\xA\x1\xB\xFFFF\x1\x3\x1F\xFFFF\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 7;
			this.eot = DFA7_eot;
			this.eof = DFA7_eof;
			this.min = DFA7_min;
			this.max = DFA7_max;
			this.accept = DFA7_accept;
			this.special = DFA7_special;
			this.transition = DFA7_transition;
		}

		public override string Description { get { return "251:1: FLOAT : ( ( DIGIT )* '.' ( DIGIT )+ ( EXPONENT )? | ( DIGIT )+ EXPONENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA14 : DFA
	{
		private const string DFA14_eotS =
			"\x1\xFFFF\x1\x21\x1\xFFFF\x1\x23\x8\xFFFF\x1\x27\x1\x29\x1\x2C\x2\xFFFF"+
			"\x1\x2E\x1\xFFFF\x6\x1E\x1\x36\x15\xFFFF\x3\x1E\x1\x3A\x2\x1E\x2\xFFFF"+
			"\x2\x1E\x1\x3E\x1\xFFFF\x1\x3F\x1\x40\x1\x1E\x3\xFFFF\x1\x42\x1\xFFFF";
		private const string DFA14_eofS =
			"\x43\xFFFF";
		private const string DFA14_minS =
			"\x1\x9\x1\x3D\x1\xFFFF\x1\x26\x8\xFFFF\x1\x3C\x2\x3D\x2\xFFFF\x1\x7C"+
			"\x1\xFFFF\x1\x52\x1\x41\x1\x4E\x1\x52\x1\x4F\x1\x2B\x1\x2E\x15\xFFFF"+
			"\x1\x55\x1\x4C\x1\x44\x1\x30\x1\x54\x1\x30\x2\xFFFF\x1\x45\x1\x53\x1"+
			"\x30\x1\xFFFF\x2\x30\x1\x45\x3\xFFFF\x1\x30\x1\xFFFF";
		private const string DFA14_maxS =
			"\x1\x7E\x1\x3D\x1\xFFFF\x1\x26\x8\xFFFF\x1\x3E\x1\x3D\x1\x3E\x2\xFFFF"+
			"\x1\x7C\x1\xFFFF\x1\x72\x1\x61\x1\x6E\x1\x72\x1\x6F\x1\x39\x1\x65\x15"+
			"\xFFFF\x1\x75\x1\x6C\x1\x64\x1\x7A\x1\x74\x1\x39\x2\xFFFF\x1\x65\x1\x73"+
			"\x1\x7A\x1\xFFFF\x2\x7A\x1\x65\x3\xFFFF\x1\x7A\x1\xFFFF";
		private const string DFA14_acceptS =
			"\x2\xFFFF\x1\x3\x1\xFFFF\x1\x6\x1\x7\x1\x8\x1\x9\x1\xA\x1\xB\x1\xC\x1"+
			"\xD\x3\xFFFF\x1\x17\x1\x18\x1\xFFFF\x1\x1B\x7\xFFFF\x1\x23\x1\x24\x1"+
			"\x25\x1\x26\x1\x21\x1\x28\x1\x2\x1\x1\x1\x4\x1\x5\x1\xF\x1\x10\x1\x11"+
			"\x1\xE\x1\x13\x1\x12\x1\x15\x1\x16\x1\x14\x1\x1A\x1\x19\x6\xFFFF\x1\x27"+
			"\x1\x22\x3\xFFFF\x1\x1F\x3\xFFFF\x1\x1E\x1\x20\x1\x1C\x1\xFFFF\x1\x1D";
		private const string DFA14_specialS =
			"\x43\xFFFF}>";
		private static readonly string[] DFA14_transitionS =
			{
				"\x2\x1F\x1\xFFFF\x2\x1F\x12\xFFFF\x1\x1F\x1\x1\x1\xFFFF\x1\x1C\x1\xFFFF"+
				"\x1\x2\x1\x3\x1\x1B\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x1\x1A\x1\xA"+
				"\xA\x19\x1\xB\x1\xFFFF\x1\xC\x1\xD\x1\xE\x1\xF\x1\xFFFF\x1\x15\x3\x1E"+
				"\x1\x18\x1\x14\x7\x1E\x1\x17\x1\x16\x4\x1E\x1\x13\x6\x1E\x1\x1D\x2\xFFFF"+
				"\x1\x10\x1\x1E\x1\xFFFF\x1\x15\x3\x1E\x1\x18\x1\x14\x7\x1E\x1\x17\x1"+
				"\x16\x4\x1E\x1\x13\x6\x1E\x1\xFFFF\x1\x11\x1\xFFFF\x1\x12",
				"\x1\x20",
				"",
				"\x1\x22",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x24\x1\x25\x1\x26",
				"\x1\x28",
				"\x1\x2A\x1\x2B",
				"",
				"",
				"\x1\x2D",
				"",
				"\x1\x2F\x1F\xFFFF\x1\x2F",
				"\x1\x30\x1F\xFFFF\x1\x30",
				"\x1\x31\x1F\xFFFF\x1\x31",
				"\x1\x32\x1F\xFFFF\x1\x32",
				"\x1\x33\x1F\xFFFF\x1\x33",
				"\x1\x35\x1\xFFFF\x1\x35\x2\xFFFF\xA\x34",
				"\x1\x1A\x1\xFFFF\xA\x19\xB\xFFFF\x1\x1A\x1F\xFFFF\x1\x1A",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x37\x1F\xFFFF\x1\x37",
				"\x1\x38\x1F\xFFFF\x1\x38",
				"\x1\x39\x1F\xFFFF\x1\x39",
				"\xA\x1E\x7\xFFFF\x1A\x1E\x4\xFFFF\x1\x1E\x1\xFFFF\x1A\x1E",
				"\x1\x3B\x1F\xFFFF\x1\x3B",
				"\xA\x34",
				"",
				"",
				"\x1\x3C\x1F\xFFFF\x1\x3C",
				"\x1\x3D\x1F\xFFFF\x1\x3D",
				"\xA\x1E\x7\xFFFF\x1A\x1E\x4\xFFFF\x1\x1E\x1\xFFFF\x1A\x1E",
				"",
				"\xA\x1E\x7\xFFFF\x1A\x1E\x4\xFFFF\x1\x1E\x1\xFFFF\x1A\x1E",
				"\xA\x1E\x7\xFFFF\x1A\x1E\x4\xFFFF\x1\x1E\x1\xFFFF\x1A\x1E",
				"\x1\x41\x1F\xFFFF\x1\x41",
				"",
				"",
				"",
				"\xA\x1E\x7\xFFFF\x1A\x1E\x4\xFFFF\x1\x1E\x1\xFFFF\x1A\x1E",
				""
			};

		private static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
		private static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
		private static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
		private static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
		private static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
		private static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
		private static readonly short[][] DFA14_transition;

		static DFA14()
		{
			int numStates = DFA14_transitionS.Length;
			DFA14_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA14_transition[i] = DFA.UnpackEncodedString(DFA14_transitionS[i]);
			}
		}

		public DFA14( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 14;
			this.eot = DFA14_eot;
			this.eof = DFA14_eof;
			this.min = DFA14_min;
			this.max = DFA14_max;
			this.accept = DFA14_accept;
			this.special = DFA14_special;
			this.transition = DFA14_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | TRUE | FALSE | AND | OR | NOT | ID | INTEGER | FLOAT | STRING | DATETIME | NAME | EXPONENT | WS );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion

}
