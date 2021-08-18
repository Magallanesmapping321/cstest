class RandomGenerator
{
    static void Main()
    {
      System.Random random = new System.Random(); 
      System.Console.WriteLine(random.Next(1000));
    }
}
