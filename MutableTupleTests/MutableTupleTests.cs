using System;
using System.Collections.Generic;
using NUnit.Framework;
using Ekstrand;
using System.Globalization;


namespace MutableTupleTests
{
    [TestFixture]
    public class MutableTupleTests
    {
        #region Constructors Test Sets
        // Value type doesn't matter we are just checking for
        // default initialization of the value type is what we are expecting.

        [Test]
        [Category("Constructors")]
        public void MTuple1E()
        {
            // value type doesn't matter we are just checking for
            // default initialization of the value type is what we are expecting.
            MTuple<int> items = new MTuple<int>();
            
            Assert.AreEqual(0, items.Item1);           
        }

        [Test]
        [Category("Constructors")]
        public void MTuple2E()
        {
            MTuple<int, double> items = new MTuple<int, double>();        
            Assert.AreEqual(0, items.Item1);
            Assert.AreEqual(0, items.Item2);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple3E()
        {
            MTuple<int, double, float> items = new MTuple<int, double, float>();
            Assert.AreEqual(0, items.Item1);
            Assert.AreEqual(0, items.Item2);
            Assert.AreEqual(0, items.Item3);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple4E()
        {
            MTuple<int, double, float, decimal> items = new MTuple<int, double, float, decimal>();
            Assert.AreEqual(0, items.Item1);
            Assert.AreEqual(0, items.Item2);
            Assert.AreEqual(0, items.Item3);
            Assert.AreEqual(0, items.Item4);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple5E()
        {
            MTuple<int, double, float, decimal, string> items = new MTuple<int, double, float, decimal, string>();
            Assert.AreEqual(0, items.Item1);
            Assert.AreEqual(0, items.Item2);
            Assert.AreEqual(0, items.Item3);
            Assert.AreEqual(0, items.Item4);
            Assert.AreEqual(null, items.Item5);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple6E()
        {
            MTuple<int, double, float, decimal, string, byte> items = new MTuple<int, double, float, decimal, string, byte>();
            Assert.AreEqual(0, items.Item1);
            Assert.AreEqual(0, items.Item2);
            Assert.AreEqual(0, items.Item3);
            Assert.AreEqual(0, items.Item4);
            Assert.AreEqual(null, items.Item5);
            Assert.AreEqual(0, items.Item6);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple7E()
        {
            MTuple<int, double, float, decimal, string, byte, bool> items = new MTuple<int, double, float, decimal, string, byte, bool>();
            Assert.AreEqual(0, items.Item1);
            Assert.AreEqual(0, items.Item2);
            Assert.AreEqual(0, items.Item3);
            Assert.AreEqual(0, items.Item4);
            Assert.AreEqual(null, items.Item5);
            Assert.AreEqual(0, items.Item6);
            Assert.AreEqual(false, items.Item7);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple8E()
        {          
            MTuple<int, double, float, decimal, string, byte, bool, MTuple<short>> items = new MTuple<int, double, float, decimal, string, byte, bool, MTuple<short>>();
            Assert.AreEqual(0, items.Item1);
            Assert.AreEqual(0, items.Item2);
            Assert.AreEqual(0, items.Item3);
            Assert.AreEqual(0, items.Item4);
            Assert.AreEqual(null, items.Item5);
            Assert.AreEqual(0, items.Item6);
            Assert.AreEqual(false, items.Item7);
            Assert.AreEqual(null, items.Rest); // null because there is no instance of rest yet.
        }

        #endregion

        #region Constructor with initial parameters
        // this test check if the given value is the same as the one in the constructor.
        // also this tests the properties of the mtuples as well.

        [Test]
        [Category("Constructors")]
        public void MTuple1ECP()
        {
            // value type doesn't matter we are just checking for
            // default initialization of the value type is what we are expecting.
            MTuple<int> items = new MTuple<int>(33);

            Assert.AreEqual(33, items.Item1);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple2ECP()
        {
            MTuple<int, double> items = new MTuple<int, double>(33,5);
            Assert.AreEqual(33, items.Item1);
            Assert.AreEqual(5, items.Item2);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple3ECP()
        {
            MTuple<int, double, float> items = new MTuple<int, double, float>(33,5,7);
            Assert.AreEqual(33, items.Item1);
            Assert.AreEqual(5, items.Item2);
            Assert.AreEqual(7, items.Item3);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple4ECP()
        {
            MTuple<int, double, float, decimal> items = new MTuple<int, double, float, decimal>(33,5,7,(decimal)44.5);
            Assert.AreEqual(33, items.Item1);
            Assert.AreEqual(5, items.Item2);
            Assert.AreEqual(7, items.Item3);
            Assert.AreEqual(44.5, items.Item4);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple5ECP()
        {
            MTuple<int, double, float, decimal, string> items = new MTuple<int, double, float, decimal, string>(33, 5, 7, (decimal)44.5,"hello");
            Assert.AreEqual(33, items.Item1);
            Assert.AreEqual(5, items.Item2);
            Assert.AreEqual(7, items.Item3);
            Assert.AreEqual(44.5, items.Item4);
            Assert.AreEqual("hello", items.Item5);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple6ECP()
        {
            MTuple<int, double, float, decimal, string, byte> items = new MTuple<int, double, float, decimal, string, byte>(33, 5, 7, (decimal)44.5, "hello", 2);
            Assert.AreEqual(33, items.Item1);
            Assert.AreEqual(5, items.Item2);
            Assert.AreEqual(7, items.Item3);
            Assert.AreEqual(44.5, items.Item4);
            Assert.AreEqual("hello", items.Item5);
            Assert.AreEqual(2, items.Item6);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple7ECP()
        {
            MTuple<int, double, float, decimal, string, byte, bool> items = new MTuple<int, double, float, decimal, string, byte, bool>(33, 5, 7, (decimal)44.5, "hello", 2, true);
            Assert.AreEqual(33, items.Item1);
            Assert.AreEqual(5, items.Item2);
            Assert.AreEqual(7, items.Item3);
            Assert.AreEqual(44.5, items.Item4);
            Assert.AreEqual("hello", items.Item5);
            Assert.AreEqual(2, items.Item6);
            Assert.AreEqual(true, items.Item7);
        }

        [Test]
        [Category("Constructors")]
        public void MTuple8ECP()
        {
            MTuple<int, double, float, decimal, string, byte, bool, MTuple<short>> items = new MTuple<int, double, float, decimal, string, byte, bool, MTuple<short>>(33, 5, 7, (decimal)44.5, "hello", 2, true, new MTuple<short>(5));
            Assert.AreEqual(33, items.Item1);
            Assert.AreEqual(5, items.Item2);
            Assert.AreEqual(7, items.Item3);
            Assert.AreEqual(44.5, items.Item4);
            Assert.AreEqual("hello", items.Item5);
            Assert.AreEqual(2, items.Item6);
            Assert.AreEqual(true, items.Item7);
            Assert.AreEqual(5, items.Rest.Item1);
        }

        #endregion

        #region Properties Change

        [Test]
        [Category("Properties")]
        public void MTuple1EProperties()
        {
            // value type doesn't matter we are just checking for
            // default initialization of the value type is what we are expecting.
            MTuple<int> items = new MTuple<int>(33);
            items.Item1 = 7;
            Assert.AreEqual(7, items.Item1);
        }

        [Test]
        [Category("Properties")]
        public void MTuple2EProperties()
        {
            MTuple<int, double> items = new MTuple<int, double>(33, 5);
            items.Item1 = 7;
            items.Item2 = 22.5;
            Assert.AreEqual(7, items.Item1);
            Assert.AreEqual(22.5, items.Item2);
        }

        [Test]
        [Category("Properties")]
        public void MTuple3EProperties()
        {
            MTuple<int, double, float> items = new MTuple<int, double, float>(33, 5, 7);
            items.Item1 = 7;
            items.Item2 = 22.5;
            items.Item3 = 5;
            Assert.AreEqual(7, items.Item1);
            Assert.AreEqual(22.5, items.Item2);
            Assert.AreEqual(5, items.Item3);
        }

        [Test]
        [Category("Properties")]
        public void MTuple4EProperties()
        {
            MTuple<int, double, float, decimal> items = new MTuple<int, double, float, decimal>(33, 5, 7, (decimal)44.5);
            items.Item1 = 7;
            items.Item2 = 22.5;
            items.Item3 = 5;
            items.Item4 = (decimal)6.6;
            Assert.AreEqual(7, items.Item1);
            Assert.AreEqual(22.5, items.Item2);
            Assert.AreEqual(5, items.Item3);
            Assert.AreEqual(6.6, items.Item4);
        }

        [Test]
        [Category("Properties")]
        public void MTuple5EProperties()
        {
            MTuple<int, double, float, decimal, string> items = new MTuple<int, double, float, decimal, string>(33, 5, 7, (decimal)44.5, "hello");
            items.Item1 = 7;
            items.Item2 = 22.5;
            items.Item3 = 5;
            items.Item4 = (decimal)6.6;
            items.Item5 = "bye";
            Assert.AreEqual(7, items.Item1);
            Assert.AreEqual(22.5, items.Item2);
            Assert.AreEqual(5, items.Item3);
            Assert.AreEqual(6.6, items.Item4);
            Assert.AreEqual("bye", items.Item5);
        }

        [Test]
        [Category("Properties")]
        public void MTuple6EProperties()
        {
            MTuple<int, double, float, decimal, string, byte> items = new MTuple<int, double, float, decimal, string, byte>(33, 5, 7, (decimal)44.5, "hello", 2);
            items.Item1 = 7;
            items.Item2 = 22.5;
            items.Item3 = 5;
            items.Item4 = (decimal)6.6;
            items.Item5 = "bye";
            items.Item6 = 255;
            Assert.AreEqual(7, items.Item1);
            Assert.AreEqual(22.5, items.Item2);
            Assert.AreEqual(5, items.Item3);
            Assert.AreEqual(6.6, items.Item4);
            Assert.AreEqual("bye", items.Item5);
            Assert.AreEqual(255, items.Item6);
        }

        [Test]
        [Category("Properties")]
        public void MTuple7EProperties()
        {
            MTuple<int, double, float, decimal, string, byte, bool> items = new MTuple<int, double, float, decimal, string, byte, bool>(33, 5, 7, (decimal)44.5, "hello", 2, true);

            items.Item1 = 7;
            items.Item2 = 22.5;
            items.Item3 = 5;
            items.Item4 = (decimal)6.6;
            items.Item5 = "bye";
            items.Item6 = 255;
            items.Item7 = false;
            Assert.AreEqual(7, items.Item1);
            Assert.AreEqual(22.5, items.Item2);
            Assert.AreEqual(5, items.Item3);
            Assert.AreEqual(6.6, items.Item4);
            Assert.AreEqual("bye", items.Item5);
            Assert.AreEqual(255, items.Item6);
            Assert.AreEqual(false, items.Item7);
        }

        [Test]
        [Category("Properties")]
        public void MTuple8EProperties()
        {
            MTuple<int, double, float, decimal, string, byte, bool, MTuple<short>> items = new MTuple<int, double, float, decimal, string, byte, bool, MTuple<short>>(33, 5, 7, (decimal)44.5, "hello", 2, true, new MTuple<short>(5));
            items.Item1 = 7;
            items.Item2 = 22.5;
            items.Item3 = 5;
            items.Item4 = (decimal)6.6;
            items.Item5 = "bye";
            items.Item6 = 255;
            items.Item7 = false;
            items.Rest.Item1 = 12;
            Assert.AreEqual(7, items.Item1);
            Assert.AreEqual(22.5, items.Item2);
            Assert.AreEqual(5, items.Item3);
            Assert.AreEqual(6.6, items.Item4);
            Assert.AreEqual("bye", items.Item5);
            Assert.AreEqual(255, items.Item6);
            Assert.AreEqual(false, items.Item7);
            Assert.AreEqual(12, items.Rest.Item1);
        }

        #endregion

        #region Equals
        // Value/Class type doesn't matter
        // The underlining equals is at the element value type level.

        [Test]
        [Category("Equals")]
        public void MTuple1Equals()
        {

            MTuple<int> itemsA = new MTuple<int>(45);
            MTuple<int> itemsB = new MTuple<int>(99);            
            Assert.AreEqual(false, itemsA.Equals(itemsB));

            itemsB = new MTuple<int>(45);
            Assert.AreEqual(true, itemsA.Equals(itemsB));
        }

        [Test]
        [Category("Equals")]
        public void MTuple2Equals()
        {
            MTuple<string,string> itemsA = new MTuple<string, string>("foo","fart");
            MTuple<string, string> itemsB = new MTuple<string, string>("hello","bye");
            Assert.AreEqual(false, itemsA.Equals(itemsB));

            itemsB = new MTuple<string, string>("foo", "fart");
            Assert.AreEqual(true, itemsA.Equals(itemsB));
        }

        [Test]
        [Category("Equals")]
        public void MTuple3Equals()
        {
            MTuple<decimal, decimal, decimal> itemsA = new MTuple<decimal, decimal, decimal>(33.5m, 69, .60m);
            MTuple<decimal, decimal, decimal> itemsB = new MTuple<decimal, decimal, decimal>(56.01m, 76, .001m);
            Assert.AreEqual(false, itemsA.Equals(itemsB));

            itemsB = new MTuple<decimal, decimal, decimal>(33.5m, 69, .60m);
            Assert.AreEqual(true, itemsA.Equals(itemsB));
        }

        [Test]
        [Category("Equals")]
        public void MTuple4Equals()
        {
            MTuple<byte, byte, byte, byte> itemsA = new MTuple<byte, byte, byte, byte>(0, 69, 201, 254);
            MTuple<byte, byte, byte, byte> itemsB = new MTuple<byte, byte, byte, byte>(56, 76, 1, 108);
            Assert.AreEqual(false, itemsA.Equals(itemsB));

            itemsB = new MTuple<byte, byte, byte, byte>(0, 69, 201, 254);
            Assert.AreEqual(true, itemsA.Equals(itemsB));
        }

        [Test]
        [Category("Equals")]
        public void MTuple5Equals()
        {
            MTuple<short, short, short, short, short> itemsA = new MTuple<short, short, short, short, short>(-1, 69, 201, 254, 32767);
            MTuple<short, short, short, short, short> itemsB = new MTuple<short, short, short, short, short>(56, 76, 1, 108, 59);
            Assert.AreEqual(false, itemsA.Equals(itemsB));

            itemsB = new MTuple<short, short, short, short, short>(-1, 69, 201, 254, 32767);
            Assert.AreEqual(true, itemsA.Equals(itemsB));
        }

        [Test]
        [Category("Equals")]
        public void MTuple6Equals()
        {
            MTuple<long, long, long, long, long, long> itemsA = new MTuple<long, long, long, long, long, long>(1, 69, 201, 254, 32767, 999999);
            MTuple<long, long, long, long, long, long> itemsB = new MTuple<long, long, long, long, long, long>(56, 76, 1, 108, 59, 99999);
            Assert.AreEqual(false, itemsA.Equals(itemsB));

            itemsB = new MTuple<long, long, long, long, long, long>(1, 69, 201, 254, 32767, 999999);
            Assert.AreEqual(true, itemsA.Equals(itemsB));
        }

        [Test]
        [Category("Equals")]
        public void MTuple7Equals()
        {
            MTuple<uint, uint, uint, uint, uint, uint, uint> itemsA = new MTuple<uint, uint, uint, uint, uint, uint, uint>(1, 69, 201, 254, 32767, 999999, 888888);
            MTuple<uint, uint, uint, uint, uint, uint, uint> itemsB = new MTuple<uint, uint, uint, uint, uint, uint, uint>(56, 76, 1, 108, 59, 99999, 999999);
            Assert.AreEqual(false, itemsA.Equals(itemsB));

            itemsB = new MTuple<uint, uint, uint, uint, uint, uint, uint>(1, 69, 201, 254, 32767, 999999, 888888);
            Assert.AreEqual(true, itemsA.Equals(itemsB));
        }

        [Test]
        [Category("Equals")]
        public void MTuple8Equals()
        {            
            MTuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort, MTuple<bool>> itemsA = new MTuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort, MTuple<bool>>(1, 69, 201, 254, 32767, 65535, 44444, new MTuple<bool>(false));
            MTuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort, MTuple<bool>> itemsB = new MTuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort, MTuple<bool>>(56, 76, 1, 108, 59, 65535, 22222, new MTuple<bool>(true));
            Assert.AreEqual(false, itemsA.Equals(itemsB));

            itemsB = new MTuple<ushort, ushort, ushort, ushort, ushort, ushort, ushort, MTuple<bool>>(1, 69, 201, 254, 32767, 65535, 44444,new MTuple<bool>(false));
            Assert.AreEqual(true, itemsA.Equals(itemsB));
            // null because there is no instance of rest yet.
        }

        #endregion

        #region CompareTo
        // value type doesn't matter
        // The underlying value type is used to make the compareTo 

        [Test]
        [Category("CompareTo")]
        public void MTuple1CompareTo()
        {
            List<MTuple<int>> list = new List<MTuple<int>>();
            list.Add(new MTuple<int>(6));
            list.Add(new MTuple<int>(5));
            list.Sort();
            Assert.AreEqual(5, list[0].Item1);
        }

        [Test]
        [Category("CompareTo")]
        public void MTuple2CompareTo()
        {
            List<MTuple<int,int>> list = new List<MTuple<int,int>>();
            list.Add(new MTuple<int,int>(6,7));
            list.Add(new MTuple<int,int>(5,4));
            list.Add(new MTuple<int, int>(6, 8));
            list.Sort();
            Assert.AreEqual(5, list[0].Item1);
            Assert.AreEqual(7, list[1].Item2);
            Assert.AreEqual(8, list[2].Item2);
        }

        [Test]
        [Category("CompareTo")]
        public void MTuple3CompareTo()
        {
            List<MTuple<byte, byte, byte>> list = new List<MTuple<byte, byte, byte>>();
            list.Add(new MTuple<byte, byte, byte>(6, 7, 200));
            list.Add(new MTuple<byte, byte, byte>(5, 4, 240));
            list.Add(new MTuple<byte, byte, byte>(6, 8, 100));
            list.Sort();
            Assert.AreEqual(5, list[0].Item1);
            Assert.AreEqual(7, list[1].Item2);
            Assert.AreEqual(8, list[2].Item2);
        }

        [Test]
        [Category("CompareTo")]
        public void MTuple4CompareTo()
        {
            List<MTuple<byte, byte, byte, int>> list = new List<MTuple<byte, byte, byte, int>>();
            list.Add(new MTuple<byte, byte, byte, int>(6, 7, 200, -1));
            list.Add(new MTuple<byte, byte, byte, int>(5, 4, 240, -2));
            list.Add(new MTuple<byte, byte, byte, int>(6, 8, 100, -3));
            list.Sort();
            Assert.AreEqual(5, list[0].Item1);
            Assert.AreEqual(7, list[1].Item2);
            Assert.AreEqual(8, list[2].Item2);
        }

        [Test]
        [Category("CompareTo")]
        public void MTuple5CompareTo()
        {
            List<MTuple<byte, byte, byte, int, short>> list = new List<MTuple<byte, byte, byte, int, short>>();
            list.Add(new MTuple<byte, byte, byte, int, short>(6, 7, 200, -1, 2));
            list.Add(new MTuple<byte, byte, byte, int, short>(5, 4, 240, -2, 2));
            list.Add(new MTuple<byte, byte, byte, int, short>(6, 8, 100, -3, 2));
            list.Sort();
            Assert.AreEqual(5, list[0].Item1);
            Assert.AreEqual(7, list[1].Item2);
            Assert.AreEqual(8, list[2].Item2);
        }

        [Test]
        [Category("CompareTo")]
        public void MTuple6CompareTo()
        {
            List<MTuple<byte, byte, byte, int, short, long>> list = new List<MTuple<byte, byte, byte, int, short, long>>();
            list.Add(new MTuple<byte, byte, byte, int, short, long>(6, 7, 200, -1, 2, 88));
            list.Add(new MTuple<byte, byte, byte, int, short, long>(5, 4, 240, -2, 2, 91));
            list.Add(new MTuple<byte, byte, byte, int, short, long>(6, 8, 100, -3, 2, 76));
            list.Sort();
            Assert.AreEqual(5, list[0].Item1);
            Assert.AreEqual(7, list[1].Item2);
            Assert.AreEqual(8, list[2].Item2);
        }

        [Test]
        [Category("CompareTo")]
        public void MTuple7CompareTo()
        {
            List<MTuple<byte, byte, byte, int, short, long, decimal>> list = new List<MTuple<byte, byte, byte, int, short, long, decimal>>();
            list.Add(new MTuple<byte, byte, byte, int, short, long, decimal>(6, 7, 200, -1, 2, 88, 5.1m));
            list.Add(new MTuple<byte, byte, byte, int, short, long, decimal>(5, 4, 240, -2, 2, 91, 6.5m));
            list.Add(new MTuple<byte, byte, byte, int, short, long, decimal>(6, 8, 100, -3, 2, 76, 2.9m));
            list.Sort();
            Assert.AreEqual(5, list[0].Item1);
            Assert.AreEqual(7, list[1].Item2);
            Assert.AreEqual(8, list[2].Item2);
        }

        [Test]
        [Category("CompareTo")]
        public void MTuple8CompareTo()
        {
            List<MTuple<byte, byte, byte, int, short, long, decimal, MTuple<int>>> list = new List<MTuple<byte, byte, byte, int, short, long, decimal, MTuple<int>>>();
            list.Add(new MTuple<byte, byte, byte, int, short, long, decimal, MTuple<int>>( 6, 7, 200, -1, 2, 88, 5.1m, new MTuple<int>(3)));
            list.Add(new MTuple<byte, byte, byte, int, short, long, decimal, MTuple<int>>(5, 4, 240, -2, 2, 91, 6.5m, new MTuple<int>(66)));
            list.Add(new MTuple<byte, byte, byte, int, short, long, decimal, MTuple<int>>(6, 8, 100, -3, 2, 76, 2.9m, new MTuple<int>(88)));
            list.Sort();
            Assert.AreEqual(5, list[0].Item1);
            Assert.AreEqual(7, list[1].Item2);
            Assert.AreEqual(8, list[2].Item2);           
        }

        #endregion

        #region Size

        [Test]
        [Category("Size")]
        public void MTuple1Size()
        {
            // value type doesn't matter we are just checking for
            // default initialization of the value type is what we are expecting.
            MTuple<int> items = new MTuple<int>();
            
            Assert.AreEqual(1,((ITuple)items).Size );
        }

        [Test]
        [Category("Size")]
        public void MTuple2Size()
        {
            MTuple<int, double> items = new MTuple<int, double>();
            Assert.AreEqual(2, ((ITuple)items).Size);

        }

        [Test]
        [Category("Size")]
        public void MTuple3Size()
        {
            MTuple<int, double, float> items = new MTuple<int, double, float>();
            Assert.AreEqual(3, ((ITuple)items).Size);
            
        }

        [Test]
        [Category("Size")]
        public void MTuple4Size()
        {
            MTuple<int, double, float, decimal> items = new MTuple<int, double, float, decimal>();
            Assert.AreEqual(4, ((ITuple)items).Size);

        }

        [Test]
        [Category("Size")]
        public void MTuple5Size()
        {
            MTuple<int, double, float, decimal, string> items = new MTuple<int, double, float, decimal, string>();
            Assert.AreEqual(5, ((ITuple)items).Size);
            
        }

        [Test]
        [Category("Size")]
        public void MTuple6Size()
        {
            MTuple<int, double, float, decimal, string, byte> items = new MTuple<int, double, float, decimal, string, byte>();
            Assert.AreEqual(6, ((ITuple)items).Size);
            
        }

        [Test]
        [Category("Size")]
        public void MTuple7Size()
        {
            MTuple<int, double, float, decimal, string, byte, bool> items = new MTuple<int, double, float, decimal, string, byte, bool>();
            Assert.AreEqual(7, ((ITuple)items).Size);
            
        }

        [Test]
        [Category("Size")]
        public void MTuple8Size()
        {
            MTuple<int, int, int, int, int, bool, bool, MTuple<short>> items = new MTuple<int, int, int, int, int, bool, bool, MTuple<short>>(-1,2,0,45,-11,true,true,new MTuple<short>(44));

            Assert.AreEqual(8, ((ITuple)items).Size);
        }

        #endregion
    }
}
