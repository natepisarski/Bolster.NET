using Bolster.API.Interface.Stateless;
using NUnit.Framework;

namespace Bolster.Test
{
    [TestFixture]
    public class TestStatus
    {
        [Test]
        public static void TestFluentInterface() {
            var didNotWork = Status.Failure.Reason("The operation did not work");
            var worked = Status.Success.Result("The operation worked");

            Assert.True(didNotWork.IsFailure);
            Assert.True(worked.IsSuccess);
        }
    }
}