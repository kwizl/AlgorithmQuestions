using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert
{
    public class AccountMerge
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            Dictionary<int, int> idx = new Dictionary<int, int>();
            List<string> names = new List<string>();
            IList<string> swap = new List<string>();
            IList<string> sortedNames = new List<string>();
            for (int i = 0; i < accounts.Count; i++)
            {
                int x = 1;
                names.Add(accounts[i][0]);

                List<string> sortAccount = (List<string>)accounts[i];
                sortAccount.Sort();
                accounts[i] = (IList<string>)sortAccount;

                for (int j = 0; j < accounts[i].Count; j++)
                {
                    if (j == i) continue;
                    if (j + 1 == accounts.Count) break;

                    if (accounts[i][0] == accounts[j][0])
                    {
                        if (x > accounts[j].Count) continue;

                        x++;
                        if (accounts[i].Contains(accounts[j][x]))
                        {
                            idx.Add(i, j);
                            x = 1;
                            continue;
                        }
                    }
                }
                names.Sort();
                sortedNames = (IList<string>)names;
            }

            if (idx.Count != 0)
            {
                for (int i = 0; i < idx.Count; i++)
                {
                    if (idx.ContainsKey(i))
                    {
                        for (int j = 1; j < accounts[idx[i]].Count; j++)
                        {
                            accounts[i].Add(accounts[idx[i]][j]);
                        }
                        accounts.RemoveAt(idx[i]);
                    }
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (sortedNames[i] == accounts[j][0])
                    {
                        swap = accounts[i];
                        accounts[i] = accounts[j];
                        accounts[j] = swap;
                    }
                }
            }

            return accounts;
        }
    }
}
