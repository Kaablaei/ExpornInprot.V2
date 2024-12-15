namespace Domain
{
    public class CodingTafsili
    {
        public int id { get; set; }
        public int CodeTafsili { get; set; }
        public string TafsiliName { get; set; }
        public string Explain { get; set; }
        public bool TafsiliStatusIaActive { get; set; }


        public string TafsiliStatusIaActiveStatuseText => TafsiliStatusIaActive ? "فعال" : "غیرفعال";



        public int GropTafsiliCode { get; set; }
        public string GropTafsiliName { get; set; }

    }


}
