using Övning2;


do
{

    switch (Myconsole.GetMeny())
    {
        case "1":
            new TicketManager().PriceInformation();
            break;
        case "2":
            new TicketManager().CalcultePrice();
            break;
        case "3":
            Myconsole.PrintMyString();
            break;
        case "4":
            new SplitString().SplitMyString();
            break;
        case "0":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Fel val");
            break;
    }



} while (true);

