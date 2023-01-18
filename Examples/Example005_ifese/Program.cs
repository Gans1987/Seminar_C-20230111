Console.Write("Введите имя ползователя ");
string usernam = Console.ReadLine();

if(usernam.ToLower() == "маша")
{
    Console.WriteLine("Ура это же МАША");
}
    else
    {
        Console.Write("Привет, ");
        Console.WriteLine(usernam);
    }
