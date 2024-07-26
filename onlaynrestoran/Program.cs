using Microsoft.VisualBasic;
using onlaynrestoran;

public static class Program
{
   
    static void Main(string[] args)
    {
        var onlaynservice = new OnlaynServise();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Admin: ");
            Console.WriteLine("2. User: ");
            Console.WriteLine("choouse option: ");
            var choice =Console.ReadLine();
            Console.Clear();
            
            switch(choice)
            {
                case "1":
                    bool back = false;
                    Console.WriteLine("AMIN");
                    Console.WriteLine("1. Add Information: ");
                    Console.WriteLine("2. Create Kategory: ");
                    Console.WriteLine("3. Create Menu: ");
                    Console.WriteLine("4. Add or Delite order: ");
                    var admin=Console.ReadLine();
                    Console.Clear();
                    switch (admin)
                    {
                        case "1":
                            Console.WriteLine("ADMIN");
                            string info = Console.ReadLine();
                            Console.WriteLine(info);
                            Console.Clear();
                            back = true;
                            break;
                            case "2":
                            Console.WriteLine("ADMIN Kategory");
                            Console.WriteLine("1. ");
                            string kat=Console.ReadLine();
                            Console.WriteLine("2. ");
                            string kat1=Console.ReadLine();
                            Console.WriteLine("3. ");
                            string kat2=Console.ReadLine();
                            Console.WriteLine("4. ");
                            string kat3=Console.ReadLine();
                            onlaynservice.Addkategory(kat, kat1, kat2, kat3);
                            Console.Clear() ;
                            back=true; break;
                            case "3":
                            Console.WriteLine("ADMIN Menu");
                            onlaynservice.ListKategory();
                            Console.ReadKey();
                            var menu=Console.ReadLine();
                            switch(menu) 
                            { 
                                case "1":
                                    Console.WriteLine("ADMIN Menu");
                                    Console.WriteLine("1. ");
                                    string men = Console.ReadLine();
                                    Console.WriteLine("2. ");
                                    string men1 = Console.ReadLine();
                                    Console.WriteLine("3. ");
                                    string men2 = Console.ReadLine();
                                    Console.WriteLine("4. ");
                                    string men3 = Console.ReadLine();
                                    onlaynservice.AddMenu(menu, men1, men2, men3);
                                    back = true;
                                    break;
                                case "2":
                                    Console.WriteLine("ADMIN Menu");
                                    Console.WriteLine("1. ");
                                    string men0 = Console.ReadLine();
                                    Console.WriteLine("2. ");
                                    string men10 = Console.ReadLine();
                                    Console.WriteLine("3. ");
                                    string men20 = Console.ReadLine();
                                    Console.WriteLine("4. ");
                                    string men30 = Console.ReadLine();
                                    onlaynservice.AddMenu(men0, men10, men20, men30);
                                    back = true;
                                    break;
                                    case "3":
                                    Console.WriteLine("ADMIN Menu");
                                    Console.WriteLine("1. ");
                                    string men00 = Console.ReadLine();
                                    Console.WriteLine("2. ");
                                    string men100 = Console.ReadLine();
                                    Console.WriteLine("3. ");
                                    string men200 = Console.ReadLine();
                                    Console.WriteLine("4. ");
                                    string men300 = Console.ReadLine();
                                    onlaynservice.AddMenu(men00, men100, men200, men300);
                                    back = true;
                                    break;
                                    case "4":
                                    Console.WriteLine("ADMIN Menu");
                                    Console.WriteLine("1. ");
                                    string men000 = Console.ReadLine();
                                    Console.WriteLine("2. ");
                                    string men1000 = Console.ReadLine();
                                    Console.WriteLine("3. ");
                                    string men2000 = Console.ReadLine();
                                    Console.WriteLine("4. ");
                                    string men3000 = Console.ReadLine();
                                    onlaynservice.AddMenu(men000, men1000, men2000, men3000);
                                    back = true;
                                    break;


                            }
                           
                            
                            break;

                          case "4":
                          break;
                    }
                    break;
                    case "2":
                    Console.WriteLine("User: ");
                    Console.WriteLine("1. Information: ");
                    Console.WriteLine("2. Menu: ");
                    Console.WriteLine("3. Buyurtmam: ");
                    Console.WriteLine("choise option: ");
                    var option = Console.ReadLine();
                    switch (option)
                    {
                        case"1":
                            Console.WriteLine("User Information");
                            onlaynservice.Informatioon();
                            Console.ReadKey();
                            break;
                            case "2":
                            Console.WriteLine("User Menu");
                            onlaynservice.ListMenu();
                            Console.ReadKey();
                            Console.WriteLine("choose Menu: ");
                            var men= Console.ReadLine();
                            var q= Console.ReadLine();
                            onlaynservice.AddBuyurtma(q);
                            break;
                            case "3":
                            Console.WriteLine("Buyurtmam: ");
                            onlaynservice.ListBuyurtma();
                            Console.ReadKey();
                            Console.Clear();
                            back = true;
                            break;


                    }
                    break;

            }
            
        }
    }
}