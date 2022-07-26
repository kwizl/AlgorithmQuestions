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

        // O(n) Time | O(h)/O9n) Space
        public int BinaryTreeDiameter(BST tree)
        {
            return getTreeInfo(tree).Diameter;
        }


        public TreeInfo getTreeInfo(BST tree)
        {
            if (tree == null)
                return new TreeInfo(0, 0);

            TreeInfo leftTreeInfo = getTreeInfo(tree.Left);
            TreeInfo rightTreeInfo = getTreeInfo(tree.Right);

            int longestPathThroughRoot = leftTreeInfo.Height + rightTreeInfo.Height;
            int maxDiameterSoFar = Math.Max(leftTreeInfo.Diameter, rightTreeInfo.Diameter);
            int currentDiameter = Math.Max(longestPathThroughRoot, maxDiameterSoFar);
            int currentHeight = 1 + Math.Max(leftTreeInfo.Height, rightTreeInfo.Height);

            return new TreeInfo(currentDiameter, currentHeight);
        }
    }
     
    public class TreeInfo
    {
        public TreeInfo Info { get; set; }

        public int Diameter { get; set; }

        public int Height { get; set; }
        
        public TreeInfo(int diameter, int height)
        {
            Diameter = diameter;
            Height = height;
        }
    }
}
