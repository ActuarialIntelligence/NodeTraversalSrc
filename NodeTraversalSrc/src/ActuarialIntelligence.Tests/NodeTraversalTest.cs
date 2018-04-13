using ActuarialIntelligence.NodeTraversal;
using ActuarialIntelligence.Tests.TestData;
using NUnit.Framework;

namespace ActuarialIntelligence.Tests
{
    [TestFixture]
    [Category("Domain")]
    public class NodeTraversalTest
    {
        [SetUp]
        public void BeforeEachTest()
        {
        }

        public void TestNodeFound()
        {
            var dto = new FindDto();
            NodeTraversal.NodeTraversal.forEachNodeCheck(NodesTestData.GetHierarchyNodes(), dto, "fieldValue5");
            Assert.IsTrue(dto.found.Equals("fieldValue5"));
        }
    }
}
