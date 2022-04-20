using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT_2
{
    public class Forest
    {
        private TreeFactory treeFactory = new TreeFactory();
        private List<List<Tree>> trees = new List<List<Tree>>();

        public void PlantRandomTrees(int width, int height)
        {
            Random random = new Random();
            for (int i = 0; i < height; i++)
            {
                trees.Add(new List<Tree>());
                for (int j = 0; j < width; j++)
                {
                    switch (random.Next(0, 3))
                    {
                        case 0:
                            trees[i].Add(new Tree(j, i, treeFactory.GetTreeType("Red", ConsoleColor.Red, "This is a red tree.")));
                            break;
                        case 1:
                            trees[i].Add(new Tree(j, i, treeFactory.GetTreeType("Green", ConsoleColor.Green, "This is a green tree.")));
                            break;
                        case 2:
                            trees[i].Add(new Tree(j, i, treeFactory.GetTreeType("Blue", ConsoleColor.Blue, "This is a blue tree.")));
                            break;
                    }
                }
            }
        }

        public void ShowRandomTrees(int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Tree tree = trees[random.Next(trees.Count)][random.Next(trees[i].Count)];
                tree.Describe();
            }
        }

        public void Draw()
        {
            for (int i = 0; i < trees.Count; i++)
            {
                for (int j = 0; j < trees[i].Count; j++)
                {
                    trees[i][j].Draw();
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
