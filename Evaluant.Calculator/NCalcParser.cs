// $ANTLR 3.5.1 NCalc.g 2022-09-05 13:30:33

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using NCalc.Domain;


using Antlr.Runtime;
using Antlr.Runtime.Misc;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CLSCompliant(false)]
public partial class NCalcParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "A", "AND", "B", "C", "D", "DATETIME", "DIGIT", "E", "EXPONENT", "EscapeSequence", "F", "FALSE", "FLOAT", "G", "H", "HexDigit", "I", "ID", "INTEGER", "J", "K", "L", "LETTER", "M", "N", "NAME", "NOT", "O", "OR", "P", "Q", "R", "S", "STRING", "T", "TRUE", "U", "UnicodeEscape", "V", "W", "WS", "X", "Y", "Z", "'!'", "'!='", "'%'", "'&&'", "'&'", "'('", "')'", "'*'", "'+'", "','", "'-'", "'/'", "':'", "'<'", "'<<'", "'<='", "'<>'", "'='", "'=='", "'>'", "'>='", "'>>'", "'?'", "'^'", "'|'", "'||'", "'~'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public NCalcParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public NCalcParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = default(ITreeAdaptor);
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();
		OnCreated();
	}
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}

		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return NCalcParser.tokenNames; } }
	public override string GrammarFileName { get { return "NCalc.g"; } }


	private const char BS = '\\';
	private static NumberFormatInfo numberFormatInfo = new NumberFormatInfo();

	private string extractString(string text) {
	    
	    StringBuilder sb = new StringBuilder(text);
	    int startIndex = 1; // Skip initial quote
	    int slashIndex = -1;

	    while ((slashIndex = sb.ToString().IndexOf(BS, startIndex)) != -1)
	    {
	        char escapeType = sb[slashIndex + 1];
	        switch (escapeType)
	        {
	            case 'u':
	              string hcode = String.Concat(sb[slashIndex+4], sb[slashIndex+5]);
	              string lcode = String.Concat(sb[slashIndex+2], sb[slashIndex+3]);
	              char unicodeChar = Encoding.Unicode.GetChars(new byte[] { System.Convert.ToByte(hcode, 16), System.Convert.ToByte(lcode, 16)} )[0];
	              sb.Remove(slashIndex, 6).Insert(slashIndex, unicodeChar); 
	              break;
	            case 'n': sb.Remove(slashIndex, 2).Insert(slashIndex, '\n'); break;
	            case 'r': sb.Remove(slashIndex, 2).Insert(slashIndex, '\r'); break;
	            case 't': sb.Remove(slashIndex, 2).Insert(slashIndex, '\t'); break;
	            case '\'': sb.Remove(slashIndex, 2).Insert(slashIndex, '\''); break;
	            case '\\': sb.Remove(slashIndex, 2).Insert(slashIndex, '\\'); break;
	            default: throw new RecognitionException("Unvalid escape sequence: \\" + escapeType);
	        }

	        startIndex = slashIndex + 1;

	    }

	    sb.Remove(0, 1);
	    sb.Remove(sb.Length - 1, 1);

	    return sb.ToString();
	}

	public List<string> Errors { get; private set; }

	public override void DisplayRecognitionError(String[] tokenNames, RecognitionException e) {
	    
	    base.DisplayRecognitionError(tokenNames, e);
	    
	    if(Errors == null)
	    {
	    	Errors = new List<string>();
	    }
	    
	    String hdr = GetErrorHeader(e);
	    String msg = GetErrorMessage(e, tokenNames);
	    Errors.Add(msg + " at " + hdr);
	}


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public sealed partial class ncalcExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public ncalcExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_ncalcExpression();
	partial void LeaveRule_ncalcExpression();
	// $ANTLR start "ncalcExpression"
	// NCalc.g:78:1: ncalcExpression returns [LogicalExpression value] : logicalExpression EOF !;
	[GrammarRule("ncalcExpression")]
	public NCalcParser.ncalcExpression_return ncalcExpression()
	{
		EnterRule_ncalcExpression();
		EnterRule("ncalcExpression", 1);
		TraceIn("ncalcExpression", 1);
		NCalcParser.ncalcExpression_return retval = new NCalcParser.ncalcExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken EOF2 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> logicalExpression1 = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree EOF2_tree = default(CommonTree);
		try { DebugEnterRule(GrammarFileName, "ncalcExpression");
		DebugLocation(78, 1);
		try
		{
			// NCalc.g:79:2: ( logicalExpression EOF !)
			DebugEnterAlt(1);
			// NCalc.g:79:4: logicalExpression EOF !
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(79, 4);
			PushFollow(Follow._logicalExpression_in_ncalcExpression56);
			logicalExpression1=logicalExpression();
			PopFollow();

			adaptor.AddChild(root_0, logicalExpression1.Tree);
			DebugLocation(79, 25);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_ncalcExpression58); 
			DebugLocation(79, 27);
			retval.value = (logicalExpression1!=null?((NCalcParser.logicalExpression_return)logicalExpression1).value:default(LogicalExpression)); 

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ncalcExpression", 1);
			LeaveRule("ncalcExpression", 1);
			LeaveRule_ncalcExpression();
		}
		DebugLocation(80, 1);
		} finally { DebugExitRule(GrammarFileName, "ncalcExpression"); }
		return retval;

	}
	// $ANTLR end "ncalcExpression"

	private sealed partial class logicalExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public logicalExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_logicalExpression();
	partial void LeaveRule_logicalExpression();
	// $ANTLR start "logicalExpression"
	// NCalc.g:82:1: logicalExpression returns [LogicalExpression value] : left= conditionalExpression ( '?' middle= conditionalExpression ':' right= conditionalExpression )? ;
	[GrammarRule("logicalExpression")]
	private NCalcParser.logicalExpression_return logicalExpression()
	{
		EnterRule_logicalExpression();
		EnterRule("logicalExpression", 2);
		TraceIn("logicalExpression", 2);
		NCalcParser.logicalExpression_return retval = new NCalcParser.logicalExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal3 = default(IToken);
		IToken char_literal4 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> middle = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal3_tree = default(CommonTree);
		CommonTree char_literal4_tree = default(CommonTree);
		try { DebugEnterRule(GrammarFileName, "logicalExpression");
		DebugLocation(82, 1);
		try
		{
			// NCalc.g:83:2: (left= conditionalExpression ( '?' middle= conditionalExpression ':' right= conditionalExpression )? )
			DebugEnterAlt(1);
			// NCalc.g:83:4: left= conditionalExpression ( '?' middle= conditionalExpression ':' right= conditionalExpression )?
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(83, 8);
			PushFollow(Follow._conditionalExpression_in_logicalExpression78);
			left=conditionalExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(83, 31);
			 retval.value = (left!=null?((NCalcParser.conditionalExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(83, 57);
			// NCalc.g:83:57: ( '?' middle= conditionalExpression ':' right= conditionalExpression )?
			int alt1=2;
			try { DebugEnterSubRule(1);
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			int LA1_1 = input.LA(1);

			if ((LA1_1==70))
			{
				alt1 = 1;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:83:59: '?' middle= conditionalExpression ':' right= conditionalExpression
				{
				DebugLocation(83, 59);
				char_literal3=(IToken)Match(input,70,Follow._70_in_logicalExpression84); 
				char_literal3_tree = (CommonTree)adaptor.Create(char_literal3);
				adaptor.AddChild(root_0, char_literal3_tree);
				DebugLocation(83, 69);
				PushFollow(Follow._conditionalExpression_in_logicalExpression88);
				middle=conditionalExpression();
				PopFollow();

				adaptor.AddChild(root_0, middle.Tree);
				DebugLocation(83, 92);
				char_literal4=(IToken)Match(input,60,Follow._60_in_logicalExpression90); 
				char_literal4_tree = (CommonTree)adaptor.Create(char_literal4);
				adaptor.AddChild(root_0, char_literal4_tree);
				DebugLocation(83, 101);
				PushFollow(Follow._conditionalExpression_in_logicalExpression94);
				right=conditionalExpression();
				PopFollow();

				adaptor.AddChild(root_0, right.Tree);
				DebugLocation(83, 124);
				 retval.value = new TernaryExpression((left!=null?((NCalcParser.conditionalExpression_return)left).value:default(LogicalExpression)), (middle!=null?((NCalcParser.conditionalExpression_return)middle).value:default(LogicalExpression)), (right!=null?((NCalcParser.conditionalExpression_return)right).value:default(LogicalExpression))); 

				}
				break;

			}
			} finally { DebugExitSubRule(1); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logicalExpression", 2);
			LeaveRule("logicalExpression", 2);
			LeaveRule_logicalExpression();
		}
		DebugLocation(84, 1);
		} finally { DebugExitRule(GrammarFileName, "logicalExpression"); }
		return retval;

	}
	// $ANTLR end "logicalExpression"

	private sealed partial class conditionalExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public conditionalExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_conditionalExpression();
	partial void LeaveRule_conditionalExpression();
	// $ANTLR start "conditionalExpression"
	// NCalc.g:86:1: conditionalExpression returns [LogicalExpression value] : left= booleanAndExpression ( ( '||' | OR ) right= conditionalExpression )* ;
	[GrammarRule("conditionalExpression")]
	private NCalcParser.conditionalExpression_return conditionalExpression()
	{
		EnterRule_conditionalExpression();
		EnterRule("conditionalExpression", 3);
		TraceIn("conditionalExpression", 3);
		NCalcParser.conditionalExpression_return retval = new NCalcParser.conditionalExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken set5 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree set5_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "conditionalExpression");
		DebugLocation(86, 1);
		try
		{
			// NCalc.g:90:2: (left= booleanAndExpression ( ( '||' | OR ) right= conditionalExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:90:4: left= booleanAndExpression ( ( '||' | OR ) right= conditionalExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(90, 8);
			PushFollow(Follow._booleanAndExpression_in_conditionalExpression121);
			left=booleanAndExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(90, 30);
			 retval.value = (left!=null?((NCalcParser.booleanAndExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(90, 56);
			// NCalc.g:90:56: ( ( '||' | OR ) right= conditionalExpression )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_1 = input.LA(1);

				if ((LA2_1==OR||LA2_1==73))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:91:4: ( '||' | OR ) right= conditionalExpression
					{
					DebugLocation(91, 4);

					set5=(IToken)input.LT(1);
					if (input.LA(1)==OR||input.LA(1)==73)
					{
						input.Consume();
						adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set5));
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(91, 16);
					 type = BinaryExpressionType.Or; 
					DebugLocation(92, 9);
					PushFollow(Follow._conditionalExpression_in_conditionalExpression146);
					right=conditionalExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(92, 32);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.conditionalExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("conditionalExpression", 3);
			LeaveRule("conditionalExpression", 3);
			LeaveRule_conditionalExpression();
		}
		DebugLocation(94, 1);
		} finally { DebugExitRule(GrammarFileName, "conditionalExpression"); }
		return retval;

	}
	// $ANTLR end "conditionalExpression"

	private sealed partial class booleanAndExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public booleanAndExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_booleanAndExpression();
	partial void LeaveRule_booleanAndExpression();
	// $ANTLR start "booleanAndExpression"
	// NCalc.g:96:1: booleanAndExpression returns [LogicalExpression value] : left= bitwiseOrExpression ( ( '&&' | AND ) right= bitwiseOrExpression )* ;
	[GrammarRule("booleanAndExpression")]
	private NCalcParser.booleanAndExpression_return booleanAndExpression()
	{
		EnterRule_booleanAndExpression();
		EnterRule("booleanAndExpression", 4);
		TraceIn("booleanAndExpression", 4);
		NCalcParser.booleanAndExpression_return retval = new NCalcParser.booleanAndExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken set6 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree set6_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "booleanAndExpression");
		DebugLocation(96, 1);
		try
		{
			// NCalc.g:100:2: (left= bitwiseOrExpression ( ( '&&' | AND ) right= bitwiseOrExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:100:4: left= bitwiseOrExpression ( ( '&&' | AND ) right= bitwiseOrExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(100, 8);
			PushFollow(Follow._bitwiseOrExpression_in_booleanAndExpression180);
			left=bitwiseOrExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(100, 29);
			 retval.value = (left!=null?((NCalcParser.bitwiseOrExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(100, 55);
			// NCalc.g:100:55: ( ( '&&' | AND ) right= bitwiseOrExpression )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_1 = input.LA(1);

				if ((LA3_1==AND||LA3_1==51))
				{
					alt3 = 1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:101:4: ( '&&' | AND ) right= bitwiseOrExpression
					{
					DebugLocation(101, 4);

					set6=(IToken)input.LT(1);
					if (input.LA(1)==AND||input.LA(1)==51)
					{
						input.Consume();
						adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set6));
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(101, 17);
					 type = BinaryExpressionType.And; 
					DebugLocation(102, 9);
					PushFollow(Follow._bitwiseOrExpression_in_booleanAndExpression205);
					right=bitwiseOrExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(102, 30);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.bitwiseOrExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("booleanAndExpression", 4);
			LeaveRule("booleanAndExpression", 4);
			LeaveRule_booleanAndExpression();
		}
		DebugLocation(104, 1);
		} finally { DebugExitRule(GrammarFileName, "booleanAndExpression"); }
		return retval;

	}
	// $ANTLR end "booleanAndExpression"

	private sealed partial class bitwiseOrExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public bitwiseOrExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_bitwiseOrExpression();
	partial void LeaveRule_bitwiseOrExpression();
	// $ANTLR start "bitwiseOrExpression"
	// NCalc.g:106:1: bitwiseOrExpression returns [LogicalExpression value] : left= bitwiseXOrExpression ( '|' right= bitwiseOrExpression )* ;
	[GrammarRule("bitwiseOrExpression")]
	private NCalcParser.bitwiseOrExpression_return bitwiseOrExpression()
	{
		EnterRule_bitwiseOrExpression();
		EnterRule("bitwiseOrExpression", 5);
		TraceIn("bitwiseOrExpression", 5);
		NCalcParser.bitwiseOrExpression_return retval = new NCalcParser.bitwiseOrExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal7 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal7_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "bitwiseOrExpression");
		DebugLocation(106, 1);
		try
		{
			// NCalc.g:110:2: (left= bitwiseXOrExpression ( '|' right= bitwiseOrExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:110:4: left= bitwiseXOrExpression ( '|' right= bitwiseOrExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(110, 8);
			PushFollow(Follow._bitwiseXOrExpression_in_bitwiseOrExpression237);
			left=bitwiseXOrExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(110, 30);
			 retval.value = (left!=null?((NCalcParser.bitwiseXOrExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(110, 56);
			// NCalc.g:110:56: ( '|' right= bitwiseOrExpression )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_1 = input.LA(1);

				if ((LA4_1==72))
				{
					alt4 = 1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:111:4: '|' right= bitwiseOrExpression
					{
					DebugLocation(111, 4);
					char_literal7=(IToken)Match(input,72,Follow._72_in_bitwiseOrExpression246); 
					char_literal7_tree = (CommonTree)adaptor.Create(char_literal7);
					adaptor.AddChild(root_0, char_literal7_tree);
					DebugLocation(111, 8);
					 type = BinaryExpressionType.BitwiseOr; 
					DebugLocation(112, 9);
					PushFollow(Follow._bitwiseOrExpression_in_bitwiseOrExpression256);
					right=bitwiseOrExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(112, 30);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.bitwiseOrExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseOrExpression", 5);
			LeaveRule("bitwiseOrExpression", 5);
			LeaveRule_bitwiseOrExpression();
		}
		DebugLocation(114, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseOrExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseOrExpression"

	private sealed partial class bitwiseXOrExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public bitwiseXOrExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_bitwiseXOrExpression();
	partial void LeaveRule_bitwiseXOrExpression();
	// $ANTLR start "bitwiseXOrExpression"
	// NCalc.g:116:1: bitwiseXOrExpression returns [LogicalExpression value] : left= bitwiseAndExpression ( '^' right= bitwiseAndExpression )* ;
	[GrammarRule("bitwiseXOrExpression")]
	private NCalcParser.bitwiseXOrExpression_return bitwiseXOrExpression()
	{
		EnterRule_bitwiseXOrExpression();
		EnterRule("bitwiseXOrExpression", 6);
		TraceIn("bitwiseXOrExpression", 6);
		NCalcParser.bitwiseXOrExpression_return retval = new NCalcParser.bitwiseXOrExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal8 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal8_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "bitwiseXOrExpression");
		DebugLocation(116, 1);
		try
		{
			// NCalc.g:120:2: (left= bitwiseAndExpression ( '^' right= bitwiseAndExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:120:4: left= bitwiseAndExpression ( '^' right= bitwiseAndExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(120, 8);
			PushFollow(Follow._bitwiseAndExpression_in_bitwiseXOrExpression290);
			left=bitwiseAndExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(120, 30);
			 retval.value = (left!=null?((NCalcParser.bitwiseAndExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(120, 56);
			// NCalc.g:120:56: ( '^' right= bitwiseAndExpression )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_1 = input.LA(1);

				if ((LA5_1==71))
				{
					alt5 = 1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:121:4: '^' right= bitwiseAndExpression
					{
					DebugLocation(121, 4);
					char_literal8=(IToken)Match(input,71,Follow._71_in_bitwiseXOrExpression299); 
					char_literal8_tree = (CommonTree)adaptor.Create(char_literal8);
					adaptor.AddChild(root_0, char_literal8_tree);
					DebugLocation(121, 8);
					 type = BinaryExpressionType.BitwiseXOr; 
					DebugLocation(122, 9);
					PushFollow(Follow._bitwiseAndExpression_in_bitwiseXOrExpression309);
					right=bitwiseAndExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(122, 31);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.bitwiseAndExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseXOrExpression", 6);
			LeaveRule("bitwiseXOrExpression", 6);
			LeaveRule_bitwiseXOrExpression();
		}
		DebugLocation(124, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseXOrExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseXOrExpression"

	private sealed partial class bitwiseAndExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public bitwiseAndExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_bitwiseAndExpression();
	partial void LeaveRule_bitwiseAndExpression();
	// $ANTLR start "bitwiseAndExpression"
	// NCalc.g:126:1: bitwiseAndExpression returns [LogicalExpression value] : left= equalityExpression ( '&' right= equalityExpression )* ;
	[GrammarRule("bitwiseAndExpression")]
	private NCalcParser.bitwiseAndExpression_return bitwiseAndExpression()
	{
		EnterRule_bitwiseAndExpression();
		EnterRule("bitwiseAndExpression", 7);
		TraceIn("bitwiseAndExpression", 7);
		NCalcParser.bitwiseAndExpression_return retval = new NCalcParser.bitwiseAndExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal9 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal9_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "bitwiseAndExpression");
		DebugLocation(126, 1);
		try
		{
			// NCalc.g:130:2: (left= equalityExpression ( '&' right= equalityExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:130:4: left= equalityExpression ( '&' right= equalityExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(130, 8);
			PushFollow(Follow._equalityExpression_in_bitwiseAndExpression341);
			left=equalityExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(130, 28);
			 retval.value = (left!=null?((NCalcParser.equalityExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(130, 54);
			// NCalc.g:130:54: ( '&' right= equalityExpression )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_1 = input.LA(1);

				if ((LA6_1==52))
				{
					alt6 = 1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:131:4: '&' right= equalityExpression
					{
					DebugLocation(131, 4);
					char_literal9=(IToken)Match(input,52,Follow._52_in_bitwiseAndExpression350); 
					char_literal9_tree = (CommonTree)adaptor.Create(char_literal9);
					adaptor.AddChild(root_0, char_literal9_tree);
					DebugLocation(131, 8);
					 type = BinaryExpressionType.BitwiseAnd; 
					DebugLocation(132, 9);
					PushFollow(Follow._equalityExpression_in_bitwiseAndExpression360);
					right=equalityExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(132, 29);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.equalityExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseAndExpression", 7);
			LeaveRule("bitwiseAndExpression", 7);
			LeaveRule_bitwiseAndExpression();
		}
		DebugLocation(134, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseAndExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseAndExpression"

	private sealed partial class equalityExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public equalityExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_equalityExpression();
	partial void LeaveRule_equalityExpression();
	// $ANTLR start "equalityExpression"
	// NCalc.g:136:1: equalityExpression returns [LogicalExpression value] : left= relationalExpression ( ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression )* ;
	[GrammarRule("equalityExpression")]
	private NCalcParser.equalityExpression_return equalityExpression()
	{
		EnterRule_equalityExpression();
		EnterRule("equalityExpression", 8);
		TraceIn("equalityExpression", 8);
		NCalcParser.equalityExpression_return retval = new NCalcParser.equalityExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken set10 = default(IToken);
		IToken set11 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree set10_tree = default(CommonTree);
		CommonTree set11_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "equalityExpression");
		DebugLocation(136, 1);
		try
		{
			// NCalc.g:140:2: (left= relationalExpression ( ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:140:4: left= relationalExpression ( ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(140, 8);
			PushFollow(Follow._relationalExpression_in_equalityExpression394);
			left=relationalExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(140, 30);
			 retval.value = (left!=null?((NCalcParser.relationalExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(140, 56);
			// NCalc.g:140:56: ( ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_1 = input.LA(1);

				if ((LA8_1==49||(LA8_1>=64 && LA8_1<=66)))
				{
					alt8 = 1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:141:4: ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression
					{
					DebugLocation(141, 4);
					// NCalc.g:141:4: ( ( '==' | '=' ) | ( '!=' | '<>' ) )
					int alt7=2;
					try { DebugEnterSubRule(7);
					try { DebugEnterDecision(7, decisionCanBacktrack[7]);
					int LA7_1 = input.LA(1);

					if (((LA7_1>=65 && LA7_1<=66)))
					{
						alt7 = 1;
					}
					else if ((LA7_1==49||LA7_1==64))
					{
						alt7 = 2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 7, 0, input, 1);
						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(7); }
					switch (alt7)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:141:6: ( '==' | '=' )
						{
						DebugLocation(141, 6);

						set10=(IToken)input.LT(1);
						if ((input.LA(1)>=65 && input.LA(1)<=66))
						{
							input.Consume();
							adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set10));
							state.errorRecovery=false;
						}
						else
						{
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							throw mse;
						}

						DebugLocation(141, 20);
						 type = BinaryExpressionType.Equal; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:142:6: ( '!=' | '<>' )
						{
						DebugLocation(142, 6);

						set11=(IToken)input.LT(1);
						if (input.LA(1)==49||input.LA(1)==64)
						{
							input.Consume();
							adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set11));
							state.errorRecovery=false;
						}
						else
						{
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							throw mse;
						}

						DebugLocation(142, 21);
						 type = BinaryExpressionType.NotEqual; 

						}
						break;

					}
					} finally { DebugExitSubRule(7); }

					DebugLocation(143, 9);
					PushFollow(Follow._relationalExpression_in_equalityExpression441);
					right=relationalExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(143, 31);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.relationalExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("equalityExpression", 8);
			LeaveRule("equalityExpression", 8);
			LeaveRule_equalityExpression();
		}
		DebugLocation(145, 1);
		} finally { DebugExitRule(GrammarFileName, "equalityExpression"); }
		return retval;

	}
	// $ANTLR end "equalityExpression"

	private sealed partial class relationalExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public relationalExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_relationalExpression();
	partial void LeaveRule_relationalExpression();
	// $ANTLR start "relationalExpression"
	// NCalc.g:147:1: relationalExpression returns [LogicalExpression value] : left= shiftExpression ( ( '<' | '<=' | '>' | '>=' ) right= shiftExpression )* ;
	[GrammarRule("relationalExpression")]
	private NCalcParser.relationalExpression_return relationalExpression()
	{
		EnterRule_relationalExpression();
		EnterRule("relationalExpression", 9);
		TraceIn("relationalExpression", 9);
		NCalcParser.relationalExpression_return retval = new NCalcParser.relationalExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal12 = default(IToken);
		IToken string_literal13 = default(IToken);
		IToken char_literal14 = default(IToken);
		IToken string_literal15 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal12_tree = default(CommonTree);
		CommonTree string_literal13_tree = default(CommonTree);
		CommonTree char_literal14_tree = default(CommonTree);
		CommonTree string_literal15_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "relationalExpression");
		DebugLocation(147, 1);
		try
		{
			// NCalc.g:151:2: (left= shiftExpression ( ( '<' | '<=' | '>' | '>=' ) right= shiftExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:151:4: left= shiftExpression ( ( '<' | '<=' | '>' | '>=' ) right= shiftExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(151, 8);
			PushFollow(Follow._shiftExpression_in_relationalExpression474);
			left=shiftExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(151, 25);
			 retval.value = (left!=null?((NCalcParser.shiftExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(151, 51);
			// NCalc.g:151:51: ( ( '<' | '<=' | '>' | '>=' ) right= shiftExpression )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_1 = input.LA(1);

				if ((LA10_1==61||LA10_1==63||(LA10_1>=67 && LA10_1<=68)))
				{
					alt10 = 1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:152:4: ( '<' | '<=' | '>' | '>=' ) right= shiftExpression
					{
					DebugLocation(152, 4);
					// NCalc.g:152:4: ( '<' | '<=' | '>' | '>=' )
					int alt9=4;
					try { DebugEnterSubRule(9);
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					switch (input.LA(1))
					{
					case 61:
						{
						alt9 = 1;
						}
						break;
					case 63:
						{
						alt9 = 2;
						}
						break;
					case 67:
						{
						alt9 = 3;
						}
						break;
					case 68:
						{
						alt9 = 4;
						}
						break;
					default:
						{
							NoViableAltException nvae = new NoViableAltException("", 9, 0, input, 1);
							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

					} finally { DebugExitDecision(9); }
					switch (alt9)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:152:6: '<'
						{
						DebugLocation(152, 6);
						char_literal12=(IToken)Match(input,61,Follow._61_in_relationalExpression485); 
						char_literal12_tree = (CommonTree)adaptor.Create(char_literal12);
						adaptor.AddChild(root_0, char_literal12_tree);
						DebugLocation(152, 10);
						 type = BinaryExpressionType.Lesser; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:153:6: '<='
						{
						DebugLocation(153, 6);
						string_literal13=(IToken)Match(input,63,Follow._63_in_relationalExpression495); 
						string_literal13_tree = (CommonTree)adaptor.Create(string_literal13);
						adaptor.AddChild(root_0, string_literal13_tree);
						DebugLocation(153, 11);
						 type = BinaryExpressionType.LesserOrEqual; 

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// NCalc.g:154:6: '>'
						{
						DebugLocation(154, 6);
						char_literal14=(IToken)Match(input,67,Follow._67_in_relationalExpression506); 
						char_literal14_tree = (CommonTree)adaptor.Create(char_literal14);
						adaptor.AddChild(root_0, char_literal14_tree);
						DebugLocation(154, 10);
						 type = BinaryExpressionType.Greater; 

						}
						break;
					case 4:
						DebugEnterAlt(4);
						// NCalc.g:155:6: '>='
						{
						DebugLocation(155, 6);
						string_literal15=(IToken)Match(input,68,Follow._68_in_relationalExpression516); 
						string_literal15_tree = (CommonTree)adaptor.Create(string_literal15);
						adaptor.AddChild(root_0, string_literal15_tree);
						DebugLocation(155, 11);
						 type = BinaryExpressionType.GreaterOrEqual; 

						}
						break;

					}
					} finally { DebugExitSubRule(9); }

					DebugLocation(156, 9);
					PushFollow(Follow._shiftExpression_in_relationalExpression528);
					right=shiftExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(156, 26);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.shiftExpression_return)right).value:default(LogicalExpression))); 

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

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relationalExpression", 9);
			LeaveRule("relationalExpression", 9);
			LeaveRule_relationalExpression();
		}
		DebugLocation(158, 1);
		} finally { DebugExitRule(GrammarFileName, "relationalExpression"); }
		return retval;

	}
	// $ANTLR end "relationalExpression"

	private sealed partial class shiftExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public shiftExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_shiftExpression();
	partial void LeaveRule_shiftExpression();
	// $ANTLR start "shiftExpression"
	// NCalc.g:160:1: shiftExpression returns [LogicalExpression value] : left= additiveExpression ( ( '<<' | '>>' ) right= additiveExpression )* ;
	[GrammarRule("shiftExpression")]
	private NCalcParser.shiftExpression_return shiftExpression()
	{
		EnterRule_shiftExpression();
		EnterRule("shiftExpression", 10);
		TraceIn("shiftExpression", 10);
		NCalcParser.shiftExpression_return retval = new NCalcParser.shiftExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken string_literal16 = default(IToken);
		IToken string_literal17 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree string_literal16_tree = default(CommonTree);
		CommonTree string_literal17_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "shiftExpression");
		DebugLocation(160, 1);
		try
		{
			// NCalc.g:164:2: (left= additiveExpression ( ( '<<' | '>>' ) right= additiveExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:164:4: left= additiveExpression ( ( '<<' | '>>' ) right= additiveExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(164, 8);
			PushFollow(Follow._additiveExpression_in_shiftExpression560);
			left=additiveExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(164, 28);
			 retval.value = (left!=null?((NCalcParser.additiveExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(164, 54);
			// NCalc.g:164:54: ( ( '<<' | '>>' ) right= additiveExpression )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_1 = input.LA(1);

				if ((LA12_1==62||LA12_1==69))
				{
					alt12 = 1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:165:4: ( '<<' | '>>' ) right= additiveExpression
					{
					DebugLocation(165, 4);
					// NCalc.g:165:4: ( '<<' | '>>' )
					int alt11=2;
					try { DebugEnterSubRule(11);
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_1 = input.LA(1);

					if ((LA11_1==62))
					{
						alt11 = 1;
					}
					else if ((LA11_1==69))
					{
						alt11 = 2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 11, 0, input, 1);
						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(11); }
					switch (alt11)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:165:6: '<<'
						{
						DebugLocation(165, 6);
						string_literal16=(IToken)Match(input,62,Follow._62_in_shiftExpression571); 
						string_literal16_tree = (CommonTree)adaptor.Create(string_literal16);
						adaptor.AddChild(root_0, string_literal16_tree);
						DebugLocation(165, 11);
						 type = BinaryExpressionType.LeftShift; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:166:6: '>>'
						{
						DebugLocation(166, 6);
						string_literal17=(IToken)Match(input,69,Follow._69_in_shiftExpression581); 
						string_literal17_tree = (CommonTree)adaptor.Create(string_literal17);
						adaptor.AddChild(root_0, string_literal17_tree);
						DebugLocation(166, 11);
						 type = BinaryExpressionType.RightShift; 

						}
						break;

					}
					} finally { DebugExitSubRule(11); }

					DebugLocation(167, 9);
					PushFollow(Follow._additiveExpression_in_shiftExpression593);
					right=additiveExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(167, 29);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.additiveExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop12;
				}
			}

			loop12:
				;

			} finally { DebugExitSubRule(12); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("shiftExpression", 10);
			LeaveRule("shiftExpression", 10);
			LeaveRule_shiftExpression();
		}
		DebugLocation(169, 1);
		} finally { DebugExitRule(GrammarFileName, "shiftExpression"); }
		return retval;

	}
	// $ANTLR end "shiftExpression"

	private sealed partial class additiveExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public additiveExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_additiveExpression();
	partial void LeaveRule_additiveExpression();
	// $ANTLR start "additiveExpression"
	// NCalc.g:171:1: additiveExpression returns [LogicalExpression value] : left= multiplicativeExpression ( ( '+' | '-' ) right= multiplicativeExpression )* ;
	[GrammarRule("additiveExpression")]
	private NCalcParser.additiveExpression_return additiveExpression()
	{
		EnterRule_additiveExpression();
		EnterRule("additiveExpression", 11);
		TraceIn("additiveExpression", 11);
		NCalcParser.additiveExpression_return retval = new NCalcParser.additiveExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal18 = default(IToken);
		IToken char_literal19 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal18_tree = default(CommonTree);
		CommonTree char_literal19_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "additiveExpression");
		DebugLocation(171, 1);
		try
		{
			// NCalc.g:175:2: (left= multiplicativeExpression ( ( '+' | '-' ) right= multiplicativeExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:175:4: left= multiplicativeExpression ( ( '+' | '-' ) right= multiplicativeExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(175, 8);
			PushFollow(Follow._multiplicativeExpression_in_additiveExpression625);
			left=multiplicativeExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(175, 34);
			 retval.value = (left!=null?((NCalcParser.multiplicativeExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(175, 60);
			// NCalc.g:175:60: ( ( '+' | '-' ) right= multiplicativeExpression )*
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_1 = input.LA(1);

				if ((LA14_1==56||LA14_1==58))
				{
					alt14 = 1;
				}


				} finally { DebugExitDecision(14); }
				switch ( alt14 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:176:4: ( '+' | '-' ) right= multiplicativeExpression
					{
					DebugLocation(176, 4);
					// NCalc.g:176:4: ( '+' | '-' )
					int alt13=2;
					try { DebugEnterSubRule(13);
					try { DebugEnterDecision(13, decisionCanBacktrack[13]);
					int LA13_1 = input.LA(1);

					if ((LA13_1==56))
					{
						alt13 = 1;
					}
					else if ((LA13_1==58))
					{
						alt13 = 2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 13, 0, input, 1);
						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(13); }
					switch (alt13)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:176:6: '+'
						{
						DebugLocation(176, 6);
						char_literal18=(IToken)Match(input,56,Follow._56_in_additiveExpression636); 
						char_literal18_tree = (CommonTree)adaptor.Create(char_literal18);
						adaptor.AddChild(root_0, char_literal18_tree);
						DebugLocation(176, 10);
						 type = BinaryExpressionType.Plus; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:177:6: '-'
						{
						DebugLocation(177, 6);
						char_literal19=(IToken)Match(input,58,Follow._58_in_additiveExpression646); 
						char_literal19_tree = (CommonTree)adaptor.Create(char_literal19);
						adaptor.AddChild(root_0, char_literal19_tree);
						DebugLocation(177, 10);
						 type = BinaryExpressionType.Minus; 

						}
						break;

					}
					} finally { DebugExitSubRule(13); }

					DebugLocation(178, 9);
					PushFollow(Follow._multiplicativeExpression_in_additiveExpression658);
					right=multiplicativeExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(178, 35);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.multiplicativeExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop14;
				}
			}

			loop14:
				;

			} finally { DebugExitSubRule(14); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("additiveExpression", 11);
			LeaveRule("additiveExpression", 11);
			LeaveRule_additiveExpression();
		}
		DebugLocation(180, 1);
		} finally { DebugExitRule(GrammarFileName, "additiveExpression"); }
		return retval;

	}
	// $ANTLR end "additiveExpression"

	private sealed partial class multiplicativeExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public multiplicativeExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_multiplicativeExpression();
	partial void LeaveRule_multiplicativeExpression();
	// $ANTLR start "multiplicativeExpression"
	// NCalc.g:182:1: multiplicativeExpression returns [LogicalExpression value] : left= unaryExpression ( ( '*' | '/' | '%' ) right= unaryExpression )* ;
	[GrammarRule("multiplicativeExpression")]
	private NCalcParser.multiplicativeExpression_return multiplicativeExpression()
	{
		EnterRule_multiplicativeExpression();
		EnterRule("multiplicativeExpression", 12);
		TraceIn("multiplicativeExpression", 12);
		NCalcParser.multiplicativeExpression_return retval = new NCalcParser.multiplicativeExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal20 = default(IToken);
		IToken char_literal21 = default(IToken);
		IToken char_literal22 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> left = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> right = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal20_tree = default(CommonTree);
		CommonTree char_literal21_tree = default(CommonTree);
		CommonTree char_literal22_tree = default(CommonTree);

		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "multiplicativeExpression");
		DebugLocation(182, 1);
		try
		{
			// NCalc.g:186:2: (left= unaryExpression ( ( '*' | '/' | '%' ) right= unaryExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:186:4: left= unaryExpression ( ( '*' | '/' | '%' ) right= unaryExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(186, 8);
			PushFollow(Follow._unaryExpression_in_multiplicativeExpression690);
			left=unaryExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(186, 25);
			 retval.value = (left!=null?((NCalcParser.unaryExpression_return)left).value:default(LogicalExpression)); 
			DebugLocation(186, 51);
			// NCalc.g:186:51: ( ( '*' | '/' | '%' ) right= unaryExpression )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_1 = input.LA(1);

				if ((LA16_1==50||LA16_1==55||LA16_1==59))
				{
					alt16 = 1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:187:4: ( '*' | '/' | '%' ) right= unaryExpression
					{
					DebugLocation(187, 4);
					// NCalc.g:187:4: ( '*' | '/' | '%' )
					int alt15=3;
					try { DebugEnterSubRule(15);
					try { DebugEnterDecision(15, decisionCanBacktrack[15]);
					switch (input.LA(1))
					{
					case 55:
						{
						alt15 = 1;
						}
						break;
					case 59:
						{
						alt15 = 2;
						}
						break;
					case 50:
						{
						alt15 = 3;
						}
						break;
					default:
						{
							NoViableAltException nvae = new NoViableAltException("", 15, 0, input, 1);
							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

					} finally { DebugExitDecision(15); }
					switch (alt15)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:187:6: '*'
						{
						DebugLocation(187, 6);
						char_literal20=(IToken)Match(input,55,Follow._55_in_multiplicativeExpression701); 
						char_literal20_tree = (CommonTree)adaptor.Create(char_literal20);
						adaptor.AddChild(root_0, char_literal20_tree);
						DebugLocation(187, 10);
						 type = BinaryExpressionType.Times; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:188:6: '/'
						{
						DebugLocation(188, 6);
						char_literal21=(IToken)Match(input,59,Follow._59_in_multiplicativeExpression711); 
						char_literal21_tree = (CommonTree)adaptor.Create(char_literal21);
						adaptor.AddChild(root_0, char_literal21_tree);
						DebugLocation(188, 10);
						 type = BinaryExpressionType.Div; 

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// NCalc.g:189:6: '%'
						{
						DebugLocation(189, 6);
						char_literal22=(IToken)Match(input,50,Follow._50_in_multiplicativeExpression721); 
						char_literal22_tree = (CommonTree)adaptor.Create(char_literal22);
						adaptor.AddChild(root_0, char_literal22_tree);
						DebugLocation(189, 10);
						 type = BinaryExpressionType.Modulo; 

						}
						break;

					}
					} finally { DebugExitSubRule(15); }

					DebugLocation(190, 9);
					PushFollow(Follow._unaryExpression_in_multiplicativeExpression733);
					right=unaryExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(190, 26);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?((NCalcParser.unaryExpression_return)right).value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop16;
				}
			}

			loop16:
				;

			} finally { DebugExitSubRule(16); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("multiplicativeExpression", 12);
			LeaveRule("multiplicativeExpression", 12);
			LeaveRule_multiplicativeExpression();
		}
		DebugLocation(192, 1);
		} finally { DebugExitRule(GrammarFileName, "multiplicativeExpression"); }
		return retval;

	}
	// $ANTLR end "multiplicativeExpression"

	private sealed partial class unaryExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public unaryExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_unaryExpression();
	partial void LeaveRule_unaryExpression();
	// $ANTLR start "unaryExpression"
	// NCalc.g:195:1: unaryExpression returns [LogicalExpression value] : ( primaryExpression | ( '!' | NOT ) primaryExpression | ( '~' ) primaryExpression | '-' primaryExpression );
	[GrammarRule("unaryExpression")]
	private NCalcParser.unaryExpression_return unaryExpression()
	{
		EnterRule_unaryExpression();
		EnterRule("unaryExpression", 13);
		TraceIn("unaryExpression", 13);
		NCalcParser.unaryExpression_return retval = new NCalcParser.unaryExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken set24 = default(IToken);
		IToken char_literal26 = default(IToken);
		IToken char_literal28 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> primaryExpression23 = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> primaryExpression25 = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> primaryExpression27 = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> primaryExpression29 = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree set24_tree = default(CommonTree);
		CommonTree char_literal26_tree = default(CommonTree);
		CommonTree char_literal28_tree = default(CommonTree);
		try { DebugEnterRule(GrammarFileName, "unaryExpression");
		DebugLocation(195, 1);
		try
		{
			// NCalc.g:196:2: ( primaryExpression | ( '!' | NOT ) primaryExpression | ( '~' ) primaryExpression | '-' primaryExpression )
			int alt17=4;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			switch (input.LA(1))
			{
			case DATETIME:
			case FALSE:
			case FLOAT:
			case ID:
			case INTEGER:
			case NAME:
			case STRING:
			case TRUE:
			case 53:
				{
				alt17 = 1;
				}
				break;
			case NOT:
			case 48:
				{
				alt17 = 2;
				}
				break;
			case 74:
				{
				alt17 = 3;
				}
				break;
			case 58:
				{
				alt17 = 4;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 17, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:196:4: primaryExpression
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(196, 4);
				PushFollow(Follow._primaryExpression_in_unaryExpression760);
				primaryExpression23=primaryExpression();
				PopFollow();

				adaptor.AddChild(root_0, primaryExpression23.Tree);
				DebugLocation(196, 22);
				 retval.value = (primaryExpression23!=null?((NCalcParser.primaryExpression_return)primaryExpression23).value:default(LogicalExpression)); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:197:8: ( '!' | NOT ) primaryExpression
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(197, 8);

				set24=(IToken)input.LT(1);
				if (input.LA(1)==NOT||input.LA(1)==48)
				{
					input.Consume();
					adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set24));
					state.errorRecovery=false;
				}
				else
				{
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(197, 20);
				PushFollow(Follow._primaryExpression_in_unaryExpression779);
				primaryExpression25=primaryExpression();
				PopFollow();

				adaptor.AddChild(root_0, primaryExpression25.Tree);
				DebugLocation(197, 38);
				 retval.value = new UnaryExpression(UnaryExpressionType.Not, (primaryExpression25!=null?((NCalcParser.primaryExpression_return)primaryExpression25).value:default(LogicalExpression))); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// NCalc.g:198:8: ( '~' ) primaryExpression
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(198, 8);
				// NCalc.g:198:8: ( '~' )
				DebugEnterAlt(1);
				// NCalc.g:198:9: '~'
				{
				DebugLocation(198, 9);
				char_literal26=(IToken)Match(input,74,Follow._74_in_unaryExpression791); 
				char_literal26_tree = (CommonTree)adaptor.Create(char_literal26);
				adaptor.AddChild(root_0, char_literal26_tree);

				}

				DebugLocation(198, 14);
				PushFollow(Follow._primaryExpression_in_unaryExpression794);
				primaryExpression27=primaryExpression();
				PopFollow();

				adaptor.AddChild(root_0, primaryExpression27.Tree);
				DebugLocation(198, 32);
				 retval.value = new UnaryExpression(UnaryExpressionType.BitwiseNot, (primaryExpression27!=null?((NCalcParser.primaryExpression_return)primaryExpression27).value:default(LogicalExpression))); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// NCalc.g:199:8: '-' primaryExpression
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(199, 8);
				char_literal28=(IToken)Match(input,58,Follow._58_in_unaryExpression805); 
				char_literal28_tree = (CommonTree)adaptor.Create(char_literal28);
				adaptor.AddChild(root_0, char_literal28_tree);
				DebugLocation(199, 12);
				PushFollow(Follow._primaryExpression_in_unaryExpression807);
				primaryExpression29=primaryExpression();
				PopFollow();

				adaptor.AddChild(root_0, primaryExpression29.Tree);
				DebugLocation(199, 30);
				 retval.value = new UnaryExpression(UnaryExpressionType.Negate, (primaryExpression29!=null?((NCalcParser.primaryExpression_return)primaryExpression29).value:default(LogicalExpression))); 

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("unaryExpression", 13);
			LeaveRule("unaryExpression", 13);
			LeaveRule_unaryExpression();
		}
		DebugLocation(200, 1);
		} finally { DebugExitRule(GrammarFileName, "unaryExpression"); }
		return retval;

	}
	// $ANTLR end "unaryExpression"

	private sealed partial class primaryExpression_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public LogicalExpression value;
		public primaryExpression_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_primaryExpression();
	partial void LeaveRule_primaryExpression();
	// $ANTLR start "primaryExpression"
	// NCalc.g:202:1: primaryExpression returns [LogicalExpression value] : ( '(' logicalExpression ')' |expr= value | identifier ( arguments )? );
	[GrammarRule("primaryExpression")]
	private NCalcParser.primaryExpression_return primaryExpression()
	{
		EnterRule_primaryExpression();
		EnterRule("primaryExpression", 14);
		TraceIn("primaryExpression", 14);
		NCalcParser.primaryExpression_return retval = new NCalcParser.primaryExpression_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal30 = default(IToken);
		IToken char_literal32 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> expr = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> logicalExpression31 = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> identifier33 = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> arguments34 = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal30_tree = default(CommonTree);
		CommonTree char_literal32_tree = default(CommonTree);
		try { DebugEnterRule(GrammarFileName, "primaryExpression");
		DebugLocation(202, 1);
		try
		{
			// NCalc.g:203:2: ( '(' logicalExpression ')' |expr= value | identifier ( arguments )? )
			int alt19=3;
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			switch (input.LA(1))
			{
			case 53:
				{
				alt19 = 1;
				}
				break;
			case DATETIME:
			case FALSE:
			case FLOAT:
			case INTEGER:
			case STRING:
			case TRUE:
				{
				alt19 = 2;
				}
				break;
			case ID:
			case NAME:
				{
				alt19 = 3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 19, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:203:4: '(' logicalExpression ')'
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(203, 4);
				char_literal30=(IToken)Match(input,53,Follow._53_in_primaryExpression826); 
				char_literal30_tree = (CommonTree)adaptor.Create(char_literal30);
				adaptor.AddChild(root_0, char_literal30_tree);
				DebugLocation(203, 8);
				PushFollow(Follow._logicalExpression_in_primaryExpression828);
				logicalExpression31=logicalExpression();
				PopFollow();

				adaptor.AddChild(root_0, logicalExpression31.Tree);
				DebugLocation(203, 26);
				char_literal32=(IToken)Match(input,54,Follow._54_in_primaryExpression830); 
				char_literal32_tree = (CommonTree)adaptor.Create(char_literal32);
				adaptor.AddChild(root_0, char_literal32_tree);
				DebugLocation(203, 31);
				 retval.value = (logicalExpression31!=null?((NCalcParser.logicalExpression_return)logicalExpression31).value:default(LogicalExpression)); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:204:4: expr= value
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(204, 8);
				PushFollow(Follow._value_in_primaryExpression840);
				expr=value();
				PopFollow();

				adaptor.AddChild(root_0, expr.Tree);
				DebugLocation(204, 16);
				 retval.value = (expr!=null?((NCalcParser.value_return)expr).value:default(ValueExpression)); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// NCalc.g:205:4: identifier ( arguments )?
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(205, 4);
				PushFollow(Follow._identifier_in_primaryExpression848);
				identifier33=identifier();
				PopFollow();

				adaptor.AddChild(root_0, identifier33.Tree);
				DebugLocation(205, 15);
				retval.value = (LogicalExpression) (identifier33!=null?((NCalcParser.identifier_return)identifier33).value:default(Identifier)); 
				DebugLocation(205, 66);
				// NCalc.g:205:66: ( arguments )?
				int alt18=2;
				try { DebugEnterSubRule(18);
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_1 = input.LA(1);

				if ((LA18_1==53))
				{
					alt18 = 1;
				}
				} finally { DebugExitDecision(18); }
				switch (alt18)
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:205:67: arguments
					{
					DebugLocation(205, 67);
					PushFollow(Follow._arguments_in_primaryExpression853);
					arguments34=arguments();
					PopFollow();

					adaptor.AddChild(root_0, arguments34.Tree);
					DebugLocation(205, 77);
					retval.value = new Function((identifier33!=null?((NCalcParser.identifier_return)identifier33).value:default(Identifier)), ((arguments34!=null?((NCalcParser.arguments_return)arguments34).value:default(List<LogicalExpression>))).ToArray()); 

					}
					break;

				}
				} finally { DebugExitSubRule(18); }


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("primaryExpression", 14);
			LeaveRule("primaryExpression", 14);
			LeaveRule_primaryExpression();
		}
		DebugLocation(206, 1);
		} finally { DebugExitRule(GrammarFileName, "primaryExpression"); }
		return retval;

	}
	// $ANTLR end "primaryExpression"

	private sealed partial class value_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public ValueExpression value;
		public value_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_value();
	partial void LeaveRule_value();
	// $ANTLR start "value"
	// NCalc.g:208:1: value returns [ValueExpression value] : ( INTEGER | FLOAT | STRING | DATETIME | TRUE | FALSE );
	[GrammarRule("value")]
	private NCalcParser.value_return value()
	{
		EnterRule_value();
		EnterRule("value", 15);
		TraceIn("value", 15);
		NCalcParser.value_return retval = new NCalcParser.value_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken INTEGER35 = default(IToken);
		IToken FLOAT36 = default(IToken);
		IToken STRING37 = default(IToken);
		IToken DATETIME38 = default(IToken);
		IToken TRUE39 = default(IToken);
		IToken FALSE40 = default(IToken);

		CommonTree INTEGER35_tree = default(CommonTree);
		CommonTree FLOAT36_tree = default(CommonTree);
		CommonTree STRING37_tree = default(CommonTree);
		CommonTree DATETIME38_tree = default(CommonTree);
		CommonTree TRUE39_tree = default(CommonTree);
		CommonTree FALSE40_tree = default(CommonTree);
		try { DebugEnterRule(GrammarFileName, "value");
		DebugLocation(208, 1);
		try
		{
			// NCalc.g:209:2: ( INTEGER | FLOAT | STRING | DATETIME | TRUE | FALSE )
			int alt20=6;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			switch (input.LA(1))
			{
			case INTEGER:
				{
				alt20 = 1;
				}
				break;
			case FLOAT:
				{
				alt20 = 2;
				}
				break;
			case STRING:
				{
				alt20 = 3;
				}
				break;
			case DATETIME:
				{
				alt20 = 4;
				}
				break;
			case TRUE:
				{
				alt20 = 5;
				}
				break;
			case FALSE:
				{
				alt20 = 6;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 20, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:209:5: INTEGER
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(209, 5);
				INTEGER35=(IToken)Match(input,INTEGER,Follow._INTEGER_in_value873); 
				INTEGER35_tree = (CommonTree)adaptor.Create(INTEGER35);
				adaptor.AddChild(root_0, INTEGER35_tree);
				DebugLocation(209, 14);
				 try { retval.value = new ValueExpression(int.Parse((INTEGER35!=null?INTEGER35.Text:default(string)))); } catch(System.OverflowException) { retval.value = new ValueExpression(long.Parse((INTEGER35!=null?INTEGER35.Text:default(string)))); } 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:210:4: FLOAT
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(210, 4);
				FLOAT36=(IToken)Match(input,FLOAT,Follow._FLOAT_in_value881); 
				FLOAT36_tree = (CommonTree)adaptor.Create(FLOAT36);
				adaptor.AddChild(root_0, FLOAT36_tree);
				DebugLocation(210, 11);
				 retval.value = new ValueExpression(double.Parse((FLOAT36!=null?FLOAT36.Text:default(string)), NumberStyles.Float, numberFormatInfo)); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// NCalc.g:211:4: STRING
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(211, 4);
				STRING37=(IToken)Match(input,STRING,Follow._STRING_in_value889); 
				STRING37_tree = (CommonTree)adaptor.Create(STRING37);
				adaptor.AddChild(root_0, STRING37_tree);
				DebugLocation(211, 12);
				 retval.value = new ValueExpression(extractString((STRING37!=null?STRING37.Text:default(string)))); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// NCalc.g:212:5: DATETIME
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(212, 5);
				DATETIME38=(IToken)Match(input,DATETIME,Follow._DATETIME_in_value898); 
				DATETIME38_tree = (CommonTree)adaptor.Create(DATETIME38);
				adaptor.AddChild(root_0, DATETIME38_tree);
				DebugLocation(212, 14);
				 retval.value = new ValueExpression(DateTime.Parse((DATETIME38!=null?DATETIME38.Text:default(string)).Substring(1, (DATETIME38!=null?DATETIME38.Text:default(string)).Length-2))); 

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// NCalc.g:213:4: TRUE
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(213, 4);
				TRUE39=(IToken)Match(input,TRUE,Follow._TRUE_in_value905); 
				TRUE39_tree = (CommonTree)adaptor.Create(TRUE39);
				adaptor.AddChild(root_0, TRUE39_tree);
				DebugLocation(213, 10);
				 retval.value = new ValueExpression(true); 

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// NCalc.g:214:4: FALSE
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(214, 4);
				FALSE40=(IToken)Match(input,FALSE,Follow._FALSE_in_value913); 
				FALSE40_tree = (CommonTree)adaptor.Create(FALSE40);
				adaptor.AddChild(root_0, FALSE40_tree);
				DebugLocation(214, 11);
				 retval.value = new ValueExpression(false); 

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("value", 15);
			LeaveRule("value", 15);
			LeaveRule_value();
		}
		DebugLocation(215, 1);
		} finally { DebugExitRule(GrammarFileName, "value"); }
		return retval;

	}
	// $ANTLR end "value"

	private sealed partial class identifier_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public Identifier value;
		public identifier_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_identifier();
	partial void LeaveRule_identifier();
	// $ANTLR start "identifier"
	// NCalc.g:217:1: identifier returns [Identifier value] : ( ID | NAME );
	[GrammarRule("identifier")]
	private NCalcParser.identifier_return identifier()
	{
		EnterRule_identifier();
		EnterRule("identifier", 16);
		TraceIn("identifier", 16);
		NCalcParser.identifier_return retval = new NCalcParser.identifier_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken ID41 = default(IToken);
		IToken NAME42 = default(IToken);

		CommonTree ID41_tree = default(CommonTree);
		CommonTree NAME42_tree = default(CommonTree);
		try { DebugEnterRule(GrammarFileName, "identifier");
		DebugLocation(217, 1);
		try
		{
			// NCalc.g:218:2: ( ID | NAME )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_1 = input.LA(1);

			if ((LA21_1==ID))
			{
				alt21 = 1;
			}
			else if ((LA21_1==NAME))
			{
				alt21 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:218:5: ID
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(218, 5);
				ID41=(IToken)Match(input,ID,Follow._ID_in_identifier931); 
				ID41_tree = (CommonTree)adaptor.Create(ID41);
				adaptor.AddChild(root_0, ID41_tree);
				DebugLocation(218, 8);
				 retval.value = new Identifier((ID41!=null?ID41.Text:default(string))); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:219:5: NAME
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(219, 5);
				NAME42=(IToken)Match(input,NAME,Follow._NAME_in_identifier939); 
				NAME42_tree = (CommonTree)adaptor.Create(NAME42);
				adaptor.AddChild(root_0, NAME42_tree);
				DebugLocation(219, 10);
				 retval.value = new Identifier((NAME42!=null?NAME42.Text:default(string)).Substring(1, (NAME42!=null?NAME42.Text:default(string)).Length-2)); 

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("identifier", 16);
			LeaveRule("identifier", 16);
			LeaveRule_identifier();
		}
		DebugLocation(220, 1);
		} finally { DebugExitRule(GrammarFileName, "identifier"); }
		return retval;

	}
	// $ANTLR end "identifier"

	private sealed partial class expressionList_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public List<LogicalExpression> value;
		public expressionList_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_expressionList();
	partial void LeaveRule_expressionList();
	// $ANTLR start "expressionList"
	// NCalc.g:222:1: expressionList returns [List<LogicalExpression> value] : first= logicalExpression ( ',' follow= logicalExpression )* ;
	[GrammarRule("expressionList")]
	private NCalcParser.expressionList_return expressionList()
	{
		EnterRule_expressionList();
		EnterRule("expressionList", 17);
		TraceIn("expressionList", 17);
		NCalcParser.expressionList_return retval = new NCalcParser.expressionList_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal43 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> first = default(AstParserRuleReturnScope<CommonTree, IToken>);
		AstParserRuleReturnScope<CommonTree, IToken> follow = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal43_tree = default(CommonTree);

		List<LogicalExpression> expressions = new List<LogicalExpression>();

		try { DebugEnterRule(GrammarFileName, "expressionList");
		DebugLocation(222, 1);
		try
		{
			// NCalc.g:226:2: (first= logicalExpression ( ',' follow= logicalExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:226:4: first= logicalExpression ( ',' follow= logicalExpression )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(226, 9);
			PushFollow(Follow._logicalExpression_in_expressionList963);
			first=logicalExpression();
			PopFollow();

			adaptor.AddChild(root_0, first.Tree);
			DebugLocation(226, 28);
			expressions.Add((first!=null?((NCalcParser.logicalExpression_return)first).value:default(LogicalExpression)));
			DebugLocation(226, 62);
			// NCalc.g:226:62: ( ',' follow= logicalExpression )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_1 = input.LA(1);

				if ((LA22_1==57))
				{
					alt22 = 1;
				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:226:64: ',' follow= logicalExpression
					{
					DebugLocation(226, 64);
					char_literal43=(IToken)Match(input,57,Follow._57_in_expressionList970); 
					char_literal43_tree = (CommonTree)adaptor.Create(char_literal43);
					adaptor.AddChild(root_0, char_literal43_tree);
					DebugLocation(226, 74);
					PushFollow(Follow._logicalExpression_in_expressionList974);
					follow=logicalExpression();
					PopFollow();

					adaptor.AddChild(root_0, follow.Tree);
					DebugLocation(226, 93);
					expressions.Add((follow!=null?((NCalcParser.logicalExpression_return)follow).value:default(LogicalExpression)));

					}
					break;

				default:
					goto loop22;
				}
			}

			loop22:
				;

			} finally { DebugExitSubRule(22); }

			DebugLocation(227, 2);
			 retval.value = expressions; 

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressionList", 17);
			LeaveRule("expressionList", 17);
			LeaveRule_expressionList();
		}
		DebugLocation(228, 1);
		} finally { DebugExitRule(GrammarFileName, "expressionList"); }
		return retval;

	}
	// $ANTLR end "expressionList"

	private sealed partial class arguments_return : AstParserRuleReturnScope<CommonTree, IToken>
	{
		public List<LogicalExpression> value;
		public arguments_return(NCalcParser grammar) {OnCreated(grammar);}
		partial void OnCreated(NCalcParser grammar);
	}

	partial void EnterRule_arguments();
	partial void LeaveRule_arguments();
	// $ANTLR start "arguments"
	// NCalc.g:230:1: arguments returns [List<LogicalExpression> value] : '(' ( expressionList )? ')' ;
	[GrammarRule("arguments")]
	private NCalcParser.arguments_return arguments()
	{
		EnterRule_arguments();
		EnterRule("arguments", 18);
		TraceIn("arguments", 18);
		NCalcParser.arguments_return retval = new NCalcParser.arguments_return(this);
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = default(CommonTree);

		IToken char_literal44 = default(IToken);
		IToken char_literal46 = default(IToken);
		AstParserRuleReturnScope<CommonTree, IToken> expressionList45 = default(AstParserRuleReturnScope<CommonTree, IToken>);

		CommonTree char_literal44_tree = default(CommonTree);
		CommonTree char_literal46_tree = default(CommonTree);

		retval.value = new List<LogicalExpression>();

		try { DebugEnterRule(GrammarFileName, "arguments");
		DebugLocation(230, 1);
		try
		{
			// NCalc.g:234:2: ( '(' ( expressionList )? ')' )
			DebugEnterAlt(1);
			// NCalc.g:234:4: '(' ( expressionList )? ')'
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(234, 4);
			char_literal44=(IToken)Match(input,53,Follow._53_in_arguments1003); 
			char_literal44_tree = (CommonTree)adaptor.Create(char_literal44);
			adaptor.AddChild(root_0, char_literal44_tree);
			DebugLocation(234, 8);
			// NCalc.g:234:8: ( expressionList )?
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_1 = input.LA(1);

			if ((LA23_1==DATETIME||(LA23_1>=FALSE && LA23_1<=FLOAT)||(LA23_1>=ID && LA23_1<=INTEGER)||(LA23_1>=NAME && LA23_1<=NOT)||LA23_1==STRING||LA23_1==TRUE||LA23_1==48||LA23_1==53||LA23_1==58||LA23_1==74))
			{
				alt23 = 1;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:234:10: expressionList
				{
				DebugLocation(234, 10);
				PushFollow(Follow._expressionList_in_arguments1007);
				expressionList45=expressionList();
				PopFollow();

				adaptor.AddChild(root_0, expressionList45.Tree);
				DebugLocation(234, 25);
				retval.value = (expressionList45!=null?((NCalcParser.expressionList_return)expressionList45).value:default(List<LogicalExpression>));

				}
				break;

			}
			} finally { DebugExitSubRule(23); }

			DebugLocation(234, 62);
			char_literal46=(IToken)Match(input,54,Follow._54_in_arguments1014); 
			char_literal46_tree = (CommonTree)adaptor.Create(char_literal46);
			adaptor.AddChild(root_0, char_literal46_tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
			retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arguments", 18);
			LeaveRule("arguments", 18);
			LeaveRule_arguments();
		}
		DebugLocation(235, 1);
		} finally { DebugExitRule(GrammarFileName, "arguments"); }
		return retval;

	}
	// $ANTLR end "arguments"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _logicalExpression_in_ncalcExpression56 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_ncalcExpression58 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conditionalExpression_in_logicalExpression78 = new BitSet(new ulong[]{0x2UL,0x40UL});
		public static readonly BitSet _70_in_logicalExpression84 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _conditionalExpression_in_logicalExpression88 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_logicalExpression90 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _conditionalExpression_in_logicalExpression94 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _booleanAndExpression_in_conditionalExpression121 = new BitSet(new ulong[]{0x100000002UL,0x200UL});
		public static readonly BitSet _set_in_conditionalExpression130 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _conditionalExpression_in_conditionalExpression146 = new BitSet(new ulong[]{0x100000002UL,0x200UL});
		public static readonly BitSet _bitwiseOrExpression_in_booleanAndExpression180 = new BitSet(new ulong[]{0x8000000000022UL});
		public static readonly BitSet _set_in_booleanAndExpression189 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _bitwiseOrExpression_in_booleanAndExpression205 = new BitSet(new ulong[]{0x8000000000022UL});
		public static readonly BitSet _bitwiseXOrExpression_in_bitwiseOrExpression237 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _72_in_bitwiseOrExpression246 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _bitwiseOrExpression_in_bitwiseOrExpression256 = new BitSet(new ulong[]{0x2UL,0x100UL});
		public static readonly BitSet _bitwiseAndExpression_in_bitwiseXOrExpression290 = new BitSet(new ulong[]{0x2UL,0x80UL});
		public static readonly BitSet _71_in_bitwiseXOrExpression299 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _bitwiseAndExpression_in_bitwiseXOrExpression309 = new BitSet(new ulong[]{0x2UL,0x80UL});
		public static readonly BitSet _equalityExpression_in_bitwiseAndExpression341 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _52_in_bitwiseAndExpression350 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _equalityExpression_in_bitwiseAndExpression360 = new BitSet(new ulong[]{0x10000000000002UL});
		public static readonly BitSet _relationalExpression_in_equalityExpression394 = new BitSet(new ulong[]{0x2000000000002UL,0x7UL});
		public static readonly BitSet _set_in_equalityExpression405 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _set_in_equalityExpression422 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _relationalExpression_in_equalityExpression441 = new BitSet(new ulong[]{0x2000000000002UL,0x7UL});
		public static readonly BitSet _shiftExpression_in_relationalExpression474 = new BitSet(new ulong[]{0xA000000000000002UL,0x18UL});
		public static readonly BitSet _61_in_relationalExpression485 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _63_in_relationalExpression495 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _67_in_relationalExpression506 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _68_in_relationalExpression516 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _shiftExpression_in_relationalExpression528 = new BitSet(new ulong[]{0xA000000000000002UL,0x18UL});
		public static readonly BitSet _additiveExpression_in_shiftExpression560 = new BitSet(new ulong[]{0x4000000000000002UL,0x20UL});
		public static readonly BitSet _62_in_shiftExpression571 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _69_in_shiftExpression581 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _additiveExpression_in_shiftExpression593 = new BitSet(new ulong[]{0x4000000000000002UL,0x20UL});
		public static readonly BitSet _multiplicativeExpression_in_additiveExpression625 = new BitSet(new ulong[]{0x500000000000002UL});
		public static readonly BitSet _56_in_additiveExpression636 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _58_in_additiveExpression646 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _multiplicativeExpression_in_additiveExpression658 = new BitSet(new ulong[]{0x500000000000002UL});
		public static readonly BitSet _unaryExpression_in_multiplicativeExpression690 = new BitSet(new ulong[]{0x884000000000002UL});
		public static readonly BitSet _55_in_multiplicativeExpression701 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _59_in_multiplicativeExpression711 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _50_in_multiplicativeExpression721 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _unaryExpression_in_multiplicativeExpression733 = new BitSet(new ulong[]{0x884000000000002UL});
		public static readonly BitSet _primaryExpression_in_unaryExpression760 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_unaryExpression771 = new BitSet(new ulong[]{0x2000A020618200UL});
		public static readonly BitSet _primaryExpression_in_unaryExpression779 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _74_in_unaryExpression791 = new BitSet(new ulong[]{0x2000A020618200UL});
		public static readonly BitSet _primaryExpression_in_unaryExpression794 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _58_in_unaryExpression805 = new BitSet(new ulong[]{0x2000A020618200UL});
		public static readonly BitSet _primaryExpression_in_unaryExpression807 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _53_in_primaryExpression826 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _logicalExpression_in_primaryExpression828 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_primaryExpression830 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _value_in_primaryExpression840 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _identifier_in_primaryExpression848 = new BitSet(new ulong[]{0x20000000000002UL});
		public static readonly BitSet _arguments_in_primaryExpression853 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INTEGER_in_value873 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FLOAT_in_value881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_in_value889 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DATETIME_in_value898 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_value905 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_value913 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_identifier931 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NAME_in_identifier939 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicalExpression_in_expressionList963 = new BitSet(new ulong[]{0x200000000000002UL});
		public static readonly BitSet _57_in_expressionList970 = new BitSet(new ulong[]{0x42100A060618200UL,0x400UL});
		public static readonly BitSet _logicalExpression_in_expressionList974 = new BitSet(new ulong[]{0x200000000000002UL});
		public static readonly BitSet _53_in_arguments1003 = new BitSet(new ulong[]{0x46100A060618200UL,0x400UL});
		public static readonly BitSet _expressionList_in_arguments1007 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_arguments1014 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}
