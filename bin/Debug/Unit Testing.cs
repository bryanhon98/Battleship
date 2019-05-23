using System;
using SwinGameSDK;
using System.Collections.Generic;
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

		[Test ()]
		public void TestAddShip ()
		{
			Dictionary<ShipName, Ship> dict = new Dictionary<ShipName, Ship> ();

			SeaGrid c = new SeaGrid (dict);
			Ship ship = new Ship (ShipName.None);

			Ship [] s = new Ship [2];
			s [0] = new Ship (ShipName.Tug);
			s [1] = new Ship (ShipName.Submarine);

			Assert.AreEqual (0, c.ShipCount);

			dict.Add (ShipName.Tug, ship);
			dict.Add (ShipName.Submarine, ship);

			Assert.AreEqual (2, c.ShipCount);
		}

		[Test ()]
		public void TestRemoveShip ()
		{
			Dictionary<ShipName, Ship> dict = new Dictionary<ShipName, Ship> ();

			SeaGrid c = new SeaGrid (dict);
			Ship ship = new Ship (ShipName.None);


			Ship [] s = new Ship [2];
			s [0] = new Ship (ShipName.Tug);
			s [1] = new Ship (ShipName.Submarine);


			//dict.Add (ShipName.Tug, ship);
			//dict.Add (ShipName.Submarine, ship);
			c.AddShip (6, 7, Direction.LeftRight, s [0]);
			c.AddShip (3, 5, Direction.LeftRight, s [1]);

			//Assert.AreEqual (2, c.ShipCount);

			//ship.Remove(ShipName.Tug, ship);

			s [0].Remove ();
			s [1].Remove ();

			Assert.AreEqual (0, c.ShipCount);
			Assert.AreNotEqual (1, c.ShipCount);
		}
	}
}



