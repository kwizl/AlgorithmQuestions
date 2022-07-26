using Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class FindSuccessor
    {
        public int? Successor(Node tree, int node)
        {
            List<int> inOrderTraversalOrder = getInOrderTraversal(tree);
            int val = 0;

            for (int i = 0; i < inOrderTraversalOrder.Count; i++)
            {
                if (inOrderTraversalOrder[i] != node)
                    continue;
                else if (i == inOrderTraversalOrder.Count - 1)
                    return null;
                else
                {
                    val = inOrderTraversalOrder[i + 1];
                    break;
                }
            }
            return val;
        }

        public List<int> getInOrderTraversal(Node node, List<int> order = null)
        {
            if (node != null)
            {
                getInOrderTraversal(node.Left, order);
                order.Add(node.Value);
                getInOrderTraversal(node.Right, order);
            }

            return order;
        }
    }
}
