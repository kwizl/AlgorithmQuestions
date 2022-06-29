using Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class NodeDepth
    {
        int sum = 0;
        int cumulativeSum = 0;

        public void TreeValues()
        {
            BinarySearchTree bst = new();
            bst.Insert(0, 1);
            bst.Insert(1, 2);
            bst.Insert(2, 3);
            bst.Insert(3, 4);
            bst.Insert(4, 5);
            bst.Insert(5, 6);
            bst.Insert(6, 7);
            bst.Insert(7, 8);
            bst.Insert(8, 9);
        }

        public int Depth(Node node, int? depth = 0)
        {
            if (depth < 1 && node == null || (depth < 1 && node.Left == null && depth < 1 && node.Right == null))
            {
                return 0;
            }

            if (depth < 1 && node != null && node.Left != null && node.Right != null)
            {
                sum += 1;
                cumulativeSum += (sum + 1) * 2;
                depth++;
                return Depth(node, depth);
            }

            if (node.Left != null && node.Right != null)
            {
                sum += 1;
                cumulativeSum += (sum + 1) * 2;
                return Depth(node);
            }
            else if (node.Left != null && node.Right == null)
            {
                sum += 1;
                cumulativeSum += sum + 1;
                return Depth(node);
            }
            else if (node.Right != null && node.Left == null)
            {
                sum += 1;
                cumulativeSum += sum + 1;
                return Depth(node);
            }

            Console.WriteLine($"{cumulativeSum}", cumulativeSum);
            return cumulativeSum;
        }

        public int DepthNodeAlgoExpert(Node root, int depth = 0)
        {
            if (root == null)
            {
                return depth;
            }

            return depth + DepthNodeAlgoExpert(root.Left, depth + 1) + DepthNodeAlgoExpert(root.Right, depth + 1);
        }
    }
}
