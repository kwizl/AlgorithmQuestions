using Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class ValidateBST
    {

        public bool IsValid(Node root)
        {
            if (root == null)
            {
                return true;
            }
            return DFS(root, null, null);
        }

        public bool DFS(Node root, int? min, int? max)
        {
            if (root == null)
            {
                return true;
            }

            if ((min != null && root.Value <= min) || 
                (max != null && root.Value >= max))
            {
                return false;
            }
            return DFS(root.Left, min, root.Value) && DFS(root.Right, root.Value, max);
        }
    }
}
