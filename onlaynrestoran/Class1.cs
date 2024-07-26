namespace onlaynrestoran
{
    public class OnlaynServise
    {
        private List<Information> info = new List<Information>();

        private List<Kat> kat = new List<Kat>();

        private List<Menu> menu = new List<Menu>();

        private List<order> ord = new List<order>();

        public void AddInformation(string info)
        {
            Console.WriteLine(info);
        }
        public void Addkategory( string kat0, string kat1, string kat2, string kat3)
        {
            int id = kat.Count > 0 ? kat.Max(k => k.Id) + 1 : 1;
            kat.Add(new Kat { Id = id, Kat0 = kat0, Kat1 = kat1,  Kat2 = kat2,  Kat3 = kat3 }); ;
        }
        public void ListKategory()
        {
            foreach (var Kat in kat )
            {
                Console.WriteLine($"Kategory: {Kat.Id}, 1: {Kat.Kat0}, 2: {Kat.Kat1}, 3: {Kat.Kat2}, 4: {Kat.Kat3} ");
            }
        }
        public void AddMenu(string men, string men1, string men2, string men3)
        {
            int id = menu.Count > 0 ? menu.Max(m => m.Id) + 1 : 1;
            menu.Add(new Menu { Id = id, Men = men, Men1 = men1, Men2 = men2, Men3 = men3 }); ;
        }
        public void ListMenu()
        {
            foreach (var Menu in menu)
            {
                Console.WriteLine($"Menu: {Menu.Id}, 1: {Menu.Men}, 2: {Menu.Men1}, 3: {Menu.Men2}, 4: {Menu.Men3} ");
            }
        }
        public void Informatioon()
        {
            foreach(var Information in info)
            {
               Console.WriteLine($"Info: {Information.Inf}");

            }
        }
        public void AddBuyurtma(string n)
        {
            int id = ord.Count > 0 ? ord.Max(o => o.Id) + 1 : 1;
            ord.Add(new order { Id = id, n = n });
        }
        public void ListBuyurtma()
        {
            foreach(var order in ord)
            {
                Console.WriteLine($"Buyurtma: {order.g}");
            }
        }
    }
}
