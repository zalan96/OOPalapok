using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
	internal class Emberek
	{
		private int db { get; set; }
		private List<Ember> emberek = new List<Ember>();

		private Emberek(int DB)
		{
			db = DB;

		}
		public override string ToString()
		{
			return $"Testsúly (kg)\t TestMagasság (cm)\t TTI \t Testalkat";

		}
		private double randommagassag()
		{
			Random random = new Random();
			double magassag = Math.Round(random.NextDouble() + 1, 2);
			return magassag;

		}
		private double randomsuly()
		{
			Random random = new Random(); double suly = Math.Round(random.NextDouble() * 100);
			return suly;
		}
		public void Emberkeszito(Emberek emberz)
		{
			for (int i = 0; i < emberz.db; i++)
			{
				Ember ujbacsi = new Ember(randomsuly(), randommagassag());
				emberek.Add(ujbacsi);
			}
			Console.WriteLine($" {emberz.db} Bácsi hozzáadva");

		}
		public double atlagSuly()
		{
			List<double> temp = new List<double>();
			for (int i = 0; i < emberek.Count; i++) { temp.Add(emberek[i].testSuly); }
			double tempsum = temp.Sum();
			double atlag = tempsum / temp.Count();
			return atlag;

		}
		public double atlagMag()
		{
			List<double> temp = new List<double>();
			for (int i = 0; i < emberek.Count; i++) { temp.Add(emberek[i].testMagassag); }
			double tempsum = temp.Sum();
			double atlag = tempsum / temp.Count();
			return atlag;

		}
	}
}