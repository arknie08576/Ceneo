using Ceneo;

var products = new List<ProductInFile>();
products.Add(new ProductInFile("Suszarka do włosów"));
products.Add(new ProductInFile("Aparat"));
products.Add(new ProductInFile("Telefon"));
products.Add(new ProductInFile("Głośnik"));
products.Add(new ProductInFile("Komputer"));
products.Add(new ProductInFile("Monitor"));

foreach (var item in products)
{
    item.GradeAdded += productGradeAdded;
}
void productGradeAdded(object sender, EventArgs e)
{
    Console.WriteLine("Dodano nową ocenę");
    Console.WriteLine();

}

while (true)
{
    int j = -1;
    string name = "a";
    while (j == -1)
    {
        Console.WriteLine("Witaj w programie do oceny produktów");
        Console.WriteLine();
        Console.WriteLine("Dostępne produkty to:");
        Console.WriteLine("Suszarka do włosów");
        Console.WriteLine("Aparat");
        Console.WriteLine("Telefon");
        Console.WriteLine("Głośnik");
        Console.WriteLine("Komputer");
        Console.WriteLine("Monitor");
        Console.WriteLine();
        Console.WriteLine("Wpisz nazwę produktu, który chcesz ocenić lub wpisz e żeby zakończyć program");
        name = Console.ReadLine();
        Console.WriteLine();

        if (name == "e")
        {
            break;
        }

        switch (name)
        {
            case "Suszarka do włosów":
                j = 0;
                break;
            case "Aparat":
                j = 1;
                break;
            case "Telefon":
                j = 2;
                break;
            case "Głośnik":
                j = 3;
                break;
            case "Komputer":
                j = 4;
                break;
            case "Monitor":
                j = 5;
                break;
            default:
                j = -1;
                break;

        }

        if (j == -1)
        {
            Console.WriteLine("Nieprawidłowa nazwa");
            Console.WriteLine();
        }
    }
    if (name == "e")
    {
        break;
    }

    while (true)
    {
        Console.WriteLine("Podaj kolejną ocenę produktu w zakresie liczbowym 0 - 100");
        Console.WriteLine("wpisz q jeśli chcesz zakończyć dodawanie ocen");

        var ocena = Console.ReadLine();
        Console.WriteLine();
        if (ocena == "q")
        {
            break;
        }

        try
        {
            products[j].AddPoints(ocena);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine();
        }
    }

    Console.WriteLine(products[j].Name);
    Console.WriteLine("Min ocena: " + products[j].GetStatistics().Min);
    Console.WriteLine("Max ocena: " + products[j].GetStatistics().Max);
    Console.WriteLine("Przeciętna ocena: " + products[j].GetStatistics().Average);
    Console.WriteLine();
}