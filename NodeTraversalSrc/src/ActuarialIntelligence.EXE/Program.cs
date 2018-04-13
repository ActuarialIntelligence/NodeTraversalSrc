using ActuarialIntelligence.NodeTraversal;
using ActuarialIntelligence.Tests.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActuarialIntelligence.EXE
{
    class Program
    {
        static void Main(string[] args)
        {
            var dto = new FindDto();
            NodeTraversal.NodeTraversal.forEachNodeCheck(NodesTestData.GetHierarchyNodes(), dto, "fieldValue5");
            var result = dto.found;
        }
    }
}
