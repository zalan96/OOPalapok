using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
	internal class Ember
	{
		private double testSuly { get; set; }
		private int testMagassag { get; set; }

		public Ember(double TestSuly, int TestMagassag)
		{
			testSuly = TestSuly;
			testMagassag = TestMagassag;
		}

		public double TestTomegIndex()
		{
			double testindex = testSuly / Math.Sqrt(testMagassag / 10);
			testindex = Math.Round(testindex, 2);
			return testindex;
		}

		public bool NormalTTI()
		{
			double testtomegszam = TestTomegIndex();
			if (testtomegszam > 18.5 && testtomegszam <= 25)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override string ToString()
		{
			return $"Testsúly: {testSuly}, Testmagasság: {testMagassag}";
		}
	}
}
