using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class MinHeightBST
    {
        // O(n) - Space
        // O(n) - Time
        // [1, 2, 5, 7, 10, 13, 14, 15, 22]
        public BST Height(int[] arr)
        {
            return ConstructMinHeightBST(arr, 0, arr.Length - 1);
        }

        public BST ConstructMinHeightBST(int[] arr, int startIdx, int endIdx)
        {
            if (endIdx < startIdx)
            {
                return null;
            }

            int midIdx = (startIdx + endIdx) / 2;
            BST bst = new BST(arr[midIdx]);

            bst.Left = ConstructMinHeightBST(arr, startIdx, midIdx - 1);
            bst.Right = ConstructMinHeightBST(arr, midIdx + 1, endIdx);

            return bst;
        }

        public int KthLargest(BST root, int[] arr, int Kth)
        {
            int[] array = InOrderTraversal(root, arr);
            Array.Sort(array.Distinct().ToArray());
            return array[array.Length - (Kth - 1)];
        }

        public int[] InOrderTraversal(BST root, int[] arr)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left, arr);
                arr.Append(root.Value);
                InOrderTraversal(root.Right, arr);
            }
            return arr;
        }
    }

    public class BST
    {
        public int Value { get; set; }

        public BST Left { get; set; }

        public BST Right { get; set; }

        public BST(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public void Insert(int value)
        {
            if (value < Value)
            {
                if (Left == null)
                {
                    Left = new BST(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new BST(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }
    }
}