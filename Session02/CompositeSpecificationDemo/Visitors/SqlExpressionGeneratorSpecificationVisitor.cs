using CompositeSpecificationDemo.Composites;
using CompositeSpecificationDemo.Leafs;

namespace CompositeSpecificationDemo.Visitors
{
    public class SqlExpressionGeneratorSpecificationVisitor<T> : NaturalLanguageExpressionGeneratorSpecificationVisitorBase<T>
    {
        protected override string LeafOperandPlaceholder => "x";
        protected override string AndExpressionKeyword => "AND";
        protected override string OrExpressionKeyword => "OR";
        protected override string NotExpressionKeyword => "NOT";
        protected override string IsZeroExpressionKeyword => "= 0";
        protected override string EvenNumbersExpressionKeyword => "% 2 = 0";
        protected override string PositiveNumbersExpressionKeyword => "> 0";
    }
}