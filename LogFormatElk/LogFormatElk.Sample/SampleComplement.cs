namespace LogFormatElk.Sample
{
    using System;
    using LogFormatElk.Model;
    public class SampleComplement : ComplementBase
    {
        public SampleComplement(string proprieteComplementaire1, DateTime proprieteComplementaire2)
        {
            this.ProprieteComplementaire1 = proprieteComplementaire1;
            this.ProprieteComplementaire2 = proprieteComplementaire2;
        }

        public string ProprieteComplementaire1 { get; set; }

        public DateTime ProprieteComplementaire2 { get; set; }
    }
}
