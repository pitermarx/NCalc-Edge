using System;

namespace NCalc.Domain
{
	public class ValueExpression : LogicalExpression
	{
        public ValueExpression(object value, ValueType type)
        {
            Value = value;
            Type = type;
        }

        public ValueExpression(object value)
        {
            switch (System.Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Boolean :
                    Type = ValueType.Boolean;
                    break;

                case TypeCode.DateTime :
                    Type = ValueType.DateTime;
                    break;

                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    Type = ValueType.Real;
                    break;

                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    Type = ValueType.Integer;
                    break;

                case TypeCode.String:
                    Type = ValueType.String;
                    break;

                default:
                    throw new EvaluationException("This value could not be handled: " + value);
            }

            Value = value;
        }

        public ValueExpression(string value)
        {
            Value = value;
            Type = ValueType.String;
        }

        public ValueExpression(long value)
        {
            Value = value;
            Type = ValueType.Integer;
        }

        public ValueExpression(double value)
        {
            Value = value;
            Type = ValueType.Real;
        }

        public ValueExpression(DateTime value)
        {
            Value = value;
            Type = ValueType.DateTime;
        }

        public ValueExpression(bool value)
        {
            Value = value;
            Type = ValueType.Boolean;
        }

        public object Value { get; set; }
        public ValueType Type { get; set; }

        public override void Accept(LogicalExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

	public enum ValueType
	{
		Integer,
		String,
		DateTime,
		Real,
		Boolean
	}
}
