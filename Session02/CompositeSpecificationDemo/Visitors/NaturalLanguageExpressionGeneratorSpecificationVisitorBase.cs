using CompositeSpecificationDemo.Composites;
using CompositeSpecificationDemo.Leafs;

namespace CompositeSpecificationDemo.Visitors
{
    public abstract class NaturalLanguageExpressionGeneratorSpecificationVisitorBase<T> : ISpecificationVisitor<T>
    {
        private const string CompositeOperandsPlaceholderSign = "$";
        protected abstract string LeafOperandPlaceholder { get; }
        protected abstract string AndExpressionKeyword { get; }
        protected abstract string OrExpressionKeyword { get; }
        protected abstract string NotExpressionKeyword { get; }
        protected abstract string IsZeroExpressionKeyword { get; }
        protected abstract string EvenNumbersExpressionKeyword { get; }
        protected abstract string PositiveNumbersExpressionKeyword { get; }

        private readonly string _compositeLeftOperandPlaceholder = $"{CompositeOperandsPlaceholderSign}1";
        private readonly string _compositeRightOperandPlaceholder = $"{CompositeOperandsPlaceholderSign}2";
        private string _compositeOperandsPlaceholder = $"{CompositeOperandsPlaceholderSign}1";

        private string _expression = $"{CompositeOperandsPlaceholderSign}1";
        public string Expression => _expression;

        private string AndExpression => $"( {_compositeLeftOperandPlaceholder} ) {AndExpressionKeyword} ( {_compositeRightOperandPlaceholder} )";
        private string OrExpression => $"( {_compositeLeftOperandPlaceholder} ) {OrExpressionKeyword} ( {_compositeRightOperandPlaceholder} )";
        private string NotExpression => $"{NotExpressionKeyword} ( {_compositeLeftOperandPlaceholder} )";
        private string IsZeroExpression => $"{LeafOperandPlaceholder} {IsZeroExpressionKeyword}";
        private string EvenNumbersExpression => $"{LeafOperandPlaceholder} {EvenNumbersExpressionKeyword}";
        private string PositiveNumbersExpression => $"{LeafOperandPlaceholder} {PositiveNumbersExpressionKeyword}";

        public void Visit(AndSpecification<T> andSpecification)
        {
            _expression = _expression.ReplaceFirst(
                _compositeOperandsPlaceholder,
                AndExpression
            );
        }

        public void Visit(OrSpecification<T> orSpecification)
        {
            _expression = _expression.ReplaceFirst(
                _compositeOperandsPlaceholder,
                OrExpression
            );
        }

        public void Visit(NotSpecification<T> notSpecification)
        {
            _expression = _expression.ReplaceFirst(
                _compositeOperandsPlaceholder,
                NotExpression
            );
        }

        public void Visit(IsZeroSpecification isZeroSpecification)
        {
            _expression = _expression.ReplaceFirst(
                _compositeOperandsPlaceholder,
                IsZeroExpression
            );
        }

        public void Visit(EvenNumbers evenNumbers)
        {
            _expression = _expression.ReplaceFirst(
                _compositeOperandsPlaceholder,
                EvenNumbersExpression
            );
        }

        public void Visit(PositiveNumbers positiveNumbers)
        {
            _expression = _expression.ReplaceFirst(
                _compositeOperandsPlaceholder,
                PositiveNumbersExpression
            );
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