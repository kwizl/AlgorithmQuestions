using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class TournamentWinner
    {
        // Use a HasTable or HashSet in order to avoid using nested loops. This improves the performance of the system but uses more space
        // Space Complexity - O(N)
        // Time Complexity - O(N)
        public string Winner(string[,] competitions, int[] results)
        {
            Dictionary<string, int> ht =  new Dictionary<string, int>();
            string currentBestTeam = "";

            ht.Add(currentBestTeam, 0);
            
            for (int i = 0; i < competitions.GetLength(0); i++)
            {
                int result = results[i];
                
                if (result == 0 && !ht.ContainsKey(competitions[i, 1].ToString()))
                {
                    ht.Add(competitions[i, 1].ToString(), 1);
                }
                else if (result == 1 && !ht.ContainsKey(competitions[i, 0].ToString()))
                {
                    ht.Add(competitions[i, 0].ToString(), 1);
                }
                else if (result == 0 && ht.ContainsKey(competitions[i, 1].ToString()))
                {
                    ht[competitions[i, 0].ToString()] = (int)ht[competitions[i, 1].ToString()] + 1;                    
                }
                else
                {
                    ht[competitions[i, 0].ToString()] = (int)ht[competitions[i, 0].ToString()] + 1;
                }

                if (i > 0 && result == 0 && (int)ht[competitions[i, 1].ToString()] >= (int)ht[currentBestTeam])
                {
                    string name = competitions[i, 1].ToString();
                    int t = (int)ht[competitions[i, 1].ToString()];
                    int z = (int)ht[currentBestTeam];
                    currentBestTeam = competitions[i, 1].ToString();
                }
                else if (i > 0 && result == 1 && (int)ht[competitions[i, 0].ToString()] >= (int)ht[currentBestTeam])
                {
                    string name = competitions[i, 0].ToString();
                    int t = (int)ht[competitions[i, 0].ToString()];
                    int z = (int)ht[currentBestTeam];
                    currentBestTeam = competitions[i, 0].ToString();
                }
            }
            return currentBestTeam;
        }
    }
}
