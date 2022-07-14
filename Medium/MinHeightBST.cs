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
            return ConstructMinHeightBST(arr, null, 0, arr.Length - 1);
        }

        public BST ConstructMinHeightBST(int[] arr, BST bst, int startIdx, int endIdx)
        {
            if (endIdx < startIdx)
            {
                return bst;
            }
            int midIdx = (startIdx + endIdx) / 2;

            BST newBSTNode = new BST(arr[midIdx]);

            if (bst == null)
                bst = newBSTNode;
            else
            { 
                if (arr[midIdx] < bst.Value)
                {
                    bst.Left = newBSTNode;
                    bst = bst.Left;
                }
                else
                {
                    bst.Right = newBSTNode;
                    bst = bst.Right;
                }
            }
            ConstructMinHeightBST(arr, bst, startIdx, midIdx - 1);
            ConstructMinHeightBST(arr, bst, midIdx + 1, endIdx);

            return bst;
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