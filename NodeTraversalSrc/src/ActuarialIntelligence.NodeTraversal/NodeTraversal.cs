using System.Collections.Generic;

namespace ActuarialIntelligence.NodeTraversal
{
    public class NodeTraversal
    {
        public static void forEachNodeCheck(IList<HierarchyNodeType> hierarchyNodeTypes, FindDto dto, string find)
        {
            foreach (var type in hierarchyNodeTypes)
            {
                if (type.nodeNameField.Equals(find))
                {
                    dto.found = find;
                    break;
                }
                if (type.hierarchyNodeField != null)
                {
                    forEachNodeCheck(type.hierarchyNodeField,dto, find);
                }
            }
        }
    }
}
