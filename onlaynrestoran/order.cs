namespace onlaynrestoran
{
    internal class order
    {
        public int Id { get; set; }
        public string n { get; set; }
        public string w { get; set; }
        public string g { get; set; }
        public string i { get; set; }

        private List<order> ord = new List<order>();
    }
}