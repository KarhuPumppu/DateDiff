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
if (days>=365)
{
    years= days/365;
    Console.WriteLine("Vuodet {0}", years);

}
if (days>=30)
{
    months= days/30;
    Console.WriteLine("kuukaudet {0}", months);
}
Console.WriteLine("Päivät {0}",days);


