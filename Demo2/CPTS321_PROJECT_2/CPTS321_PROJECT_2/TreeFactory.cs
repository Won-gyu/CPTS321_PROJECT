using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT_2
{
    public class TreeFactory
    {
        private Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

        public TreeType GetTreeType(string name, ConsoleColor color, string description)
        {
            if (treeTypes.TryGetValue(name, out TreeType treeType))
            {
                return treeType;
            }
            treeTypes.Add(name, new TreeType() { name = name, color = color, description = description });
            return treeTypes[name];
        }
    }
}
