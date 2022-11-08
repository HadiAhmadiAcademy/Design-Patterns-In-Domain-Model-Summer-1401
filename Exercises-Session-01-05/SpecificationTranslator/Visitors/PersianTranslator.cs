using System;
using System.Text;
using SpecificationTranslator.Specifications.Composites;
using SpecificationTranslator.Specifications.Leafs;

namespace SpecificationTranslator.Visitors
{
    public class PersianTranslator : IVisitor
    {
        private readonly StringBuilder _text = new StringBuilder();
        private string _verb = PersianVerbs.Bashad;
        public void Visit<T>(AndSpecification<T> spec)
        {
            _text.Append("( ");
            spec.RightSpec.Accept(this);
            _text.Append(" و ");
            spec.LeftSpec.Accept(this);
            _text.Append(" )");
        }
        public void Visit<T>(OrSpecification<T> spec)
        {
            _text.Append("( ");
            spec.RightSpec.Accept(this);
            _text.Append(" یا ");
            spec.LeftSpec.Accept(this);
            _text.Append(" )");
        }
        public void Visit<T>(NotSpecification<T> spec)
        {
            _verb = PersianVerbs.Nabashad;
            spec.TargetSpec.Accept(this);
            _verb = PersianVerbs.Bashad;
        }
        public void Visit(EvenNumbers spec)
        {
            _text.Append($"زوج {_verb}");
        }
        public void Visit(IsZeroSpecification spec)
        {
            _text.Append($"صفر {_verb}");
        }
        public void Visit(PositiveNumbers spec)
        {
            _text.Append($"مثبت {_verb}");
        }
        public string GetPersianTranslate() => _text.ToString();
    }
}