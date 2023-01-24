DateTime nyt = DateTime.Now;
DateTime a = new DateTime();
int years;
int months;


Console.WriteLine("syötä päivämäärää");
string paivam=Console.ReadLine();
if (!DateTime.TryParse(paivam, out a))
{
    Console.WriteLine("Yritä uudelleen");
}
TimeSpan intervalli = nyt - a;
int days = Math.Abs(intervalli.Days-1);
Console.WriteLine("Päivät {0}",days);


