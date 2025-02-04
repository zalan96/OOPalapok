namespace OOPalapok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			double suly = Math.Round(random.NextDouble() * (150 - 50) + 50, 1);
			int randomMagassag = random.Next(150, 210);
			Ember ember = new Ember(suly, randomMagassag);
            Console.WriteLine(ember);
            Console.WriteLine($"A testömegindex {ember.TestTomegIndex()}");
			if(ember.NormalTTI())
			{
                Console.WriteLine($"A testtömeginex a normál tartományba esik: {ember.TestTomegIndex()}");
			}
			else
			{
                Console.WriteLine($"A testtömegindex nem esik bele a normál tartmányba:{ember.TestTomegIndex}");
            }
        }
	}
}
