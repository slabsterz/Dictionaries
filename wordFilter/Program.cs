string[] foods = Console.ReadLine().Split().Where( x => x.Length % 2 == 0).ToArray();

foreach (string food in foods)
{
    Console.WriteLine(food);
}