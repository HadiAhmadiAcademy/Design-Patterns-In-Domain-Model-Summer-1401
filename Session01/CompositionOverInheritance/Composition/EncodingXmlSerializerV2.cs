namespace CompositionOverInheritance.Composition
{
    public class EncodingXmlSerializerV2 : IXmlSerializerV2
    {
        private readonly IXmlSerializerV2 _serializer;
        public EncodingXmlSerializerV2(IXmlSerializerV2 serializer)
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