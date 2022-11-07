using CompositeSpecificationDemo.Composites;
using CompositeSpecificationDemo.Leafs;

namespace CompositeSpecificationDemo.Visitors
{
    public class ExcelExpressionGeneratorSpecificationVisitor<T> : ISpecificationVisitor<T>
    {
        private const string CompositeOperandsPlaceholderSign = "$";
        private const string LeafOperandPlaceholder = "A1";
        private readonly string _compositeLeftOperandPlaceholder = $"{CompositeOperandsPlaceholderSign}1";
        private readonly string _compositeRightOperandPlaceholder = $"{CompositeOperandsPlaceholderSign}2";
        private string _compositeOperandsPlaceholder = $"{CompositeOperandsPlaceholderSign}1";
        private string _expression = $"{CompositeOperandsPlaceholderSign}1";
        public string Expression => _expression;

        private string AndExpression => $"AND ( {_compositeLeftOperandPlaceholder} , {_compositeRightOperandPlaceholder} )";
        private string OrExpression => $"OR ( {_compositeLeftOperandPlaceholder} , {_compositeRightOperandPlaceholder} )";
        private string NotExpression => $"NOT ( {_compositeLeftOperandPlaceholder} )";
        private string IsZeroExpression => $"{LeafOperandPlaceholder} = 0";
        private string EvenNumbersExpression => $"MOD( {LeafOperandPlaceholder} , 2 ) = 0";
        private string PositiveNumbersExpression => $"{LeafOperandPlaceholder} > 0";

        public void Visit(AndSpecification<T> andSpecification)
        {
            _expression = _expression.ReplaceFirst(_compositeOperandsPlaceholder, AndExpression);
        }

        public void Visit(OrSpecification<T> orSpecification)
        {
            _expression = _expression.ReplaceFirst(_compositeOperandsPlaceholder, OrExpression);
        }

        public void Visit(NotSpecification<T> notSpecification)
        {
            _expression = _expression.ReplaceFirst(_compositeOperandsPlaceholder, NotExpression);
        }

        public void Visit(IsZeroSpecification isZeroSpecification)
        {
            _expression = _expression.ReplaceFirst(_compositeOperandsPlaceholder, IsZeroExpression);
        }

        public void Visit(EvenNumbers evenNumbers)
        {
            _expression = _expression.ReplaceFirst(_compositeOperandsPlaceholder, EvenNumbersExpression);
        }

        public void Visit(PositiveNumbers positiveNumbers)
        {
            _expression = _expression.ReplaceFirst(_compositeOperandsPlaceholder, PositiveNumbersExpression);
        }

        public void PrepareToVisitRightOperand()
        {
            _compositeOperandsPlaceholder = _compositeRightOperandPlaceholder;
        }

        public void PrepareToVisitLeftOperand()
        {
            _compositeOperandsPlaceholder = _compositeLeftOperandPlaceholder;
        }
    }
}