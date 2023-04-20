
using ZaverecnyProjektPolanskyMatej;

Metody metody = new Metody();
while (true)
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Evidence pojištěných");
    Console.WriteLine("-------------------------------");
    Console.WriteLine();
    Console.WriteLine("Vyberte možnost:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledání pojištěného");
    Console.WriteLine("4 - Konec");

    int volba;
    while (!int.TryParse(Console.ReadLine(), out volba))
    {
        Console.WriteLine("Neplatná volba. Zadejte číslo od 1 do 4.");
    }
    switch (volba)
    {
        case 1:
            Console.Write("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();

            Console.Write("Zadejte příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();

            Console.Write("Zadejte věk pojištěného: ");
            int vek = int.Parse(Console.ReadLine());

            Console.Write("Zadejte telefonní číslo pojištěného: ");
            string telefon = Console.ReadLine();

            metody.VytvorPojisteneho(jmeno, prijmeni, vek, telefon);
            Console.ReadKey();
            break;
        case 2:
            metody.VypisSeznamPojistenych();
            Console.ReadKey();
            break;
        case 3:
            Console.Write("Zadejte jméno a příjmení pojištěného oddělené mezerou: ");
            string[] jmenoPrijmeni = Console.ReadLine().Split(" ");

            metody.NajdiPojisteneho(jmenoPrijmeni[0], jmenoPrijmeni[1]);
            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine("Konec programu.");
            return;
        default:
            Console.WriteLine("Neplatná volba.");
            break;
    }
}