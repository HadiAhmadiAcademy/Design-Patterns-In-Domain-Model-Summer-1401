namespace CompositeSpecificationDemo.Visitors
{
    public class EnglishTextGeneratorSpecificationVisitor<T> : NaturalLanguageExpressionGeneratorSpecificationVisitorBase<T>
    {
        protected override string LeafOperandPlaceholder => "x";
        protected override string AndExpressionKeyword => "AND";
        protected override string OrExpressionKeyword => "OR";
        protected override string NotExpressionKeyword => "NOT";
        protected override string IsZeroExpressionKeyword => "is zero";
        protected override string EvenNumbersExpressionKeyword => "is even";
        protected override string PositiveNumbersExpressionKeyword => "is positive";
    }
}