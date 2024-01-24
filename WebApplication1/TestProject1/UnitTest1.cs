using System.Xml.Schema;
using WebApplication1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Model model = new();
            Assert.True(model.GetId() == 1);
        }
    }
}

