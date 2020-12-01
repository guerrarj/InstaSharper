namespace InstaSharper.Utils.Encryption.Engine
{
    internal class DerSequenceParser
        : Asn1SequenceParser
    {
        private readonly Asn1StreamParser _parser;

        internal DerSequenceParser(
            Asn1StreamParser parser) =>
            _parser = parser;

        public IAsn1Convertible ReadObject() => _parser.ReadObject();

        public Asn1Object ToAsn1Object() => new DerSequence(_parser.ReadVector());
    }
}