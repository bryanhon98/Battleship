using System;
using SwinGameSDK;
using NUnit.Framework;

namespace MyGame
{
	[TestFixture ()]
	public class Unit_Testing
	{
		[Test ()]
		public void TestSelectedBS ()
		{
			ShipName selectedBS = ShipName.Tug;
			ShipName select = default (ShipName);

			if (select == ShipName.None) {
				selectedBS = select;
			}

			Assert.AreEqual (select, selectedBS);
		}
	}
}


