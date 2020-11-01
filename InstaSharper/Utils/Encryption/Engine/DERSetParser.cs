namespace InstaSharper.Utils.Encryption.Engine
{
    internal class DerSetParser
        : Asn1SetParser
    {
        private readonly Asn1StreamParser _parser;

        internal DerSetParser(
            Asn1StreamParser parser) =>
            _parser = parser;

        public IAsn1Convertible ReadObject() => _parser.ReadObject();

        public Asn1Object ToAsn1Object() => new DerSet(_parser.ReadVector(), false);
    }
}