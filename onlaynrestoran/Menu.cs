namespace onlaynrestoran
{
    internal class Menu
    {
        public int Id { get; set; }

        public string Kat { get; set; }
        public string Men { get; set; }
        public string Men1 { get; set; }
        public string Men2 { get; set; }
        public string Men3 { get; set; }

        private List<Menu> menu = new List<Menu>();
    }
}