using System;
using Bolster.Base;
using Bolster.Base.Interface;
using NUnit.Framework;

namespace Bolster.Test
{
    [TestFixture]
    public class TestMaybeType
    {
        public Maybe<double> DivideNumbers(double num1, double num2) {
            if (num2.Equals(0)) {
                return new Exception("Cannot divide by 0").None<double>();
            }
            return (num1 / num2).Just();
        }

        [CanFail("This can introduce a division-by-zero error")]
        public double UnsafelyDivideNumbers(double num1, double num2) {
            if (num2.Equals(0)) {
                throw new Exception("Cannot divide by 0");
            }
            return num1 / num2;
        }
        
        [Test]
        public void TestOptionalReturn() {
            var workingValue = DivideNumbers(10, 5);
            var failingValue = DivideNumbers(10, 0);
            
            Assert.AreEqual(2.0d, workingValue.Return());
            Assert.True(workingValue.HasValue);
            Assert.False(workingValue.HasError);
            
            Assert.True(failingValue.HasError);
            Assert.False(failingValue.HasValue);
            Assert.True(failingValue.GetType() == typeof(None<double>));
        }

        [Test]
        public void TestAbductFailures() {
            var value = MaybeInterface.AbductFailures(() => UnsafelyDivideNumbers(10, 0));
            
            Assert.True(value.HasError);
        }
    }
}