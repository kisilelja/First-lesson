Console.WriteLine("Как тебя зовут?");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine ("Машуля, красотуля!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine( username);

}