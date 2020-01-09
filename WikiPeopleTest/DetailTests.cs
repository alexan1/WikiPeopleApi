using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WikiPeopleTest
{
    [TestClass]
    public class DetailTests
    {
        [TestMethod]
        public void GetDetail1()
        {
            var controller = new WikiPeopleApi.Controllers.PeopleController();

            var result = controller.GetDetail(303);

            Assert.IsNotNull(result);

        }
    }
}
