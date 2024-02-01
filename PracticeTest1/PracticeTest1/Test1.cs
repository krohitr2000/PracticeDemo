using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc;
using NUnit;

namespace PracticeTest1
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void sumEqualOrNot()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Add(3, 5);

            Assert.AreEqual(8, result);
        }
        [Test]

        public void MultiEqual()
        {
            MultiClass newMulti = new MultiClass();

            int res = newMulti.Multiply(5,6);
            Assert.AreEqual(30, res);
        }

        [Test]
        public void DivEqual()
        {
            Div div = new Div();

            int deivresult = div.Division(30, 6);
            Assert.AreEqual(5, deivresult);

        }
    }

    
}
