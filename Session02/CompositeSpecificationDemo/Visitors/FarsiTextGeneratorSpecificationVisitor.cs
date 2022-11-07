using CompositeSpecificationDemo.Composites;
using CompositeSpecificationDemo.Leafs;

namespace CompositeSpecificationDemo.Visitors
{
    public class FarsiTextGeneratorSpecificationVisitor<T> : NaturalLanguageExpressionGeneratorSpecificationVisitorBase<T>
    {
        protected override string LeafOperandPlaceholder => "الف";
        protected override string AndExpressionKeyword => "و";
        protected override string OrExpressionKeyword => "یا";
        protected override string NotExpressionKeyword => "نباشد";
        protected override string IsZeroExpressionKeyword => "صفر باشد";
        protected override string EvenNumbersExpressionKeyword => "زوج باشد";
        protected override string PositiveNumbersExpressionKeyword => "مثبت باشد";
    }
}