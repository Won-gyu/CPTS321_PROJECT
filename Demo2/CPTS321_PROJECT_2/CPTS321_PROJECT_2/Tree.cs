using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT_2
{
    public class Tree
    {
        private TreeType treeType;
        public int x;
        public int y;

        public Tree(int x, int y, TreeType treeType)
        {
            this.x = x;
            this.y = y;
            this.treeType = treeType;
        }

        public void Describe()
        {
            Console.WriteLine(treeType.description + " at x:" + x + ", y:" + y);
        }

        public void Draw()
        {
            Console.BackgroundColor = treeType.color;
            Console.Write(" ");
        }
    }
}
