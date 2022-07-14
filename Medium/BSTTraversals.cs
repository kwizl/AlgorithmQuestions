using Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class BSTTraversals
    {
        // O(n) - Time
        // O(n) - Space
        public int[] InOrderTraversal(Node root, int[] arr)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left, arr);
                arr.Append(root.Value);
                InOrderTraversal(root.Right, arr);
            }
            return arr;
        }

        // O(n) - Time
        // O(n) - Space
        public int[] PreOrderTraversal(Node root, int[] arr)
        {
            if (root != null)
            {
                arr.Append(root.Value);
                PreOrderTraversal(root.Left, arr);
                PreOrderTraversal(root.Right, arr);
            }
            return arr;
        }

        // O(n) - Time
        // O(n) - Space
        public int[] PostOrderTraversal(Node root, int[] arr)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left, arr);
                PostOrderTraversal(root.Right, arr);
                arr.Append(root.Value);
            }
            return arr;
        }
    }
}
