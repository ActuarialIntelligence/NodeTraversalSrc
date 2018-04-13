using ActuarialIntelligence.NodeTraversal;
using System.Collections.Generic;

namespace ActuarialIntelligence.Tests.TestData
{
    public static class NodesTestData
    {
        public static IList<HierarchyNodeType> GetHierarchyNodes()
        {
            return new List<HierarchyNodeType>()
            {
                new HierarchyNodeType(){ nodeNameField="fieldValue1",hierarchyNodeField=null},
                new HierarchyNodeType(){ nodeNameField="fieldValue2",hierarchyNodeField =
                new List<HierarchyNodeType>(){
                new HierarchyNodeType(){ nodeNameField="fieldValue3",hierarchyNodeField=null},
                new HierarchyNodeType(){ nodeNameField="fieldValue4",hierarchyNodeField =  new List<HierarchyNodeType>(){
                new HierarchyNodeType(){ nodeNameField="fieldValue5",hierarchyNodeField=null}}}
            }} };
        }
    }
}
