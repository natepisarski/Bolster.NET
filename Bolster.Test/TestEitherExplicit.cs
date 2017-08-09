using Bolster.Base;
using Bolster.Base.Interface;
using NUnit.Framework;

namespace Bolster.Test
{
    [TestFixture]
    public class TestEitherExplicit
    {
        private Either<string, int> numAsStringOrNumber(int number, bool asString)
            => asString ? number.ToString().ToLeft<string, int>() : number.ToRight<string, int>();
        
        
        [Test]
        public void TestEitherTypes() {
            var left = Either<bool, int>.Choose(5);
            
            Assert.IsTrue(left.ValueAs<int>().Return().GetType() == 5.GetType());
            Assert.IsTrue(left.ValueAs<bool>().HasError);
        }

        [Test]
        public void TestDisparateReturnValues() {
            var returnOfRunOne = numAsStringOrNumber(4, true).ValueAs<string>().Return();
            var returnOfRunTwo = numAsStringOrNumber(5, false).ValueAs<int>().Return();
            
            Assert.IsTrue(returnOfRunOne.Equals("4"));
            Assert.IsTrue(returnOfRunTwo == 5);
        }
    }
}