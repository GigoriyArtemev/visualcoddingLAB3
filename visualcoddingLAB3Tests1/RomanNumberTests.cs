using Microsoft.VisualStudio.TestTools.UnitTesting;
using visualcoddingLAB3;
using System;

namespace visualcoddingLAB3
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            ushort n = 5;
            var Str = new RomanNumber(n);
            string expected = "V";

            Assert.AreEqual(expected, Str.ToString(), "ToString не срабатывает");
        }

        [TestMethod()]
        public void RomanNumberTest0()
        {
            
           
            string expected = "IX";

            var Constr = new RomanNumber(9);

            Assert.AreEqual(expected, Constr.ToString(), "конструктор не обрабатывает правильное входное значение");
        }

        [TestMethod()]
        public void RomanNumberTest1()
        {
                  
            ushort a = 0;

            var Constr = new RomanNumber(9);

            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(a), "исключение 0 не сработало");
        }

        [TestMethod()]
        public void RomanNumberTest2()
        {
    
            ushort k = 4000;

            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(k), "исключение на >4000 не сработало");
        }

        [TestMethod()]
        public void AddTest()
        {
            ushort a = 9;
            ushort b = 3;
            string expected = "XII";
            var Add1 = new RomanNumber(a);
            var Add2 = new RomanNumber(b);

            Assert.AreEqual(expected, (Add1 + Add2).ToString(), "сложение не сработало");
        }

        [TestMethod()]
        public void SubTest1()
        {
            ushort a = 9;
            ushort b = 3;
            string expected = "VI";
            var Sub1 = new RomanNumber(a);
            var Sub2 = new RomanNumber(b);

            Assert.AreEqual(expected, (Sub1 - Sub2).ToString(), "вычитание не сработало");
        }

        [TestMethod()]
        public void SubTest2()
        {
            ushort a = 3;
            ushort b = 9;
            var Sub1 = new RomanNumber(a);
            var Sub2 = new RomanNumber(b);

            Assert.ThrowsException<RomanNumberException>(() => (Sub1 - Sub2), "Из меньшего вычитвется большее");
        }

        [TestMethod()]
        public void SubTest3()
        {
            ushort a = 9;
            ushort b = 9;
            var Sub1 = new RomanNumber(a);
            var Sub2 = new RomanNumber(b);

            Assert.ThrowsException<RomanNumberException>(() => (Sub1 - Sub2), "вычитание двух равных");
        }

        [TestMethod()]
        public void MulTest()
        {
            ushort a = 9;
            ushort b = 3;
            string expected = "XXVII";
            var Mul1 = new RomanNumber(a);
            var Mul2 = new RomanNumber(b);

            Assert.AreEqual(expected, (Mul1 * Mul2).ToString(), "умножение не сработало");
        }

        [TestMethod()]
        public void DivTest1()
        {
            ushort a = 12;
            ushort b = 3;
            string expected = "IV";
            var Div1 = new RomanNumber(a);
            var Div2 = new RomanNumber(b);

            Assert.AreEqual(expected, (Div1 / Div2).ToString(), "деление не сработало");
        }

        [TestMethod()]
        public void DivTest2()
        {
            ushort a = 12;
            ushort b = 9;
            var Div1 = new RomanNumber(a);
            var Div2 = new RomanNumber(b);

            Assert.ThrowsException<RomanNumberException>(() => (Div1 / Div2), "целочисленое деление не сработало");
        }

        [TestMethod()]
        public void CloneTest()
        {
            ushort a = 9;
            var Clone1 = new RomanNumber(a);

            var Clone2 = (RomanNumber)Clone1.Clone();//клонируем Cl1 в Cl2

            Assert.AreNotSame(Clone1, Clone2, "Не работает Clone");//проверяем на то, что Cl1 и Cl2 ссылаются на разные объекты
        }

        [TestMethod()]
        public void CompareToTest1()
        {
            ushort a = 9;
            ushort b = 5;
            var Comp1 = new RomanNumber(a);
            RomanNumber? Comp2 = new RomanNumber(b);

            Assert.IsTrue((Comp1.CompareTo(Comp2) > 0), "Не работает CompareTo");//Comp1 > Comp2, поэтому CompareTo вернёт значение > 0

        }

        [TestMethod()]
        public void CompareToTest2()
        {
            ushort a = 9;
            var Comp1 = new RomanNumber(a);
            RomanNumber? Comp2 = null;

            Assert.ThrowsException<RomanNumberException>(() => (Comp1.CompareTo(Comp2)), "Исключение в CompareTo не работает");
        }
    }
}