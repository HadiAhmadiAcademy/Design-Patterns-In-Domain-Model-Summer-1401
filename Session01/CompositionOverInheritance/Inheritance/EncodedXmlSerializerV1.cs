namespace CompositionOverInheritance.Inheritance
{
    public class EncodedXmlSerializerV1 : XmlSerializerV1
    {
        public override string Serialize(object target)
        {
            //....
            return base.Serialize(target);
            //....
        }
    }

    public class CompressingEncodedXmlSerializer : EncodedXmlSerializerV1
    {
        public override string Serialize(object target)
        {
            //....
            return base.Serialize(target);
            //....
        }
    }
}