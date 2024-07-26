namespace onlaynrestoran
{
    public class Admin
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public string Kat { get; set; }
        public string Menu { get; set; }
        public string order { get; set; }

        private List<Kat> kat = new List<Kat>();

        private List<Menu> menu = new List<Menu>();

        private List<order> ord = new List<order>();
    }
}
