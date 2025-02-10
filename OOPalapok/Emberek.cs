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
	}
}
