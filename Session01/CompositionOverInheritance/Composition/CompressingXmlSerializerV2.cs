namespace CompositionOverInheritance.Composition
{
    public class CompressingXmlSerializerV2 : IXmlSerializerV2
    {
        private readonly IXmlSerializerV2 _serializer;
        public CompressingXmlSerializerV2(IXmlSerializerV2 serializer)
        {
            _serializer = serializer;
        }

        public string Serialize(object target)
        {
            //....
            return _serializer.Serialize(target);
            //....
        }
    }
}