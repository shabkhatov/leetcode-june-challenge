using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode_june_challenge
{
    class Day5_Random_Pick_with_Weight
    {
        public class Solution
        {
            List<KeyValuePair<int, int>> baseW;
            Dictionary<int, int> dict;
            Random rnd = new Random();

            public Solution(int[] w)
            {
                baseW =  w.Select((x, i) =>
                    new KeyValuePair<int, int>(i, x)
                )
                .OrderByDescending(x => x.Value)
                .ToList();

                dict = baseW.Select(x => x).ToDictionary(x => x.Key, x => x.Value);
            }

            public int PickIndex()
            {
                if (dict.Count == 0) {
                    dict = baseW.ToDictionary(x => x.Key, x => x.Value);
                }
                var key = rnd.Next(baseW.Count);
                
                while (!dict.ContainsKey(key)) {
                    key++;
                    if (key >= baseW.Count) {
                        key %= baseW.Count;
                    }
                }
                
                if (dict[key] <= 0) {
                    dict.Remove(key);
                    return PickIndex();
                }

                dict[key]--;
                return key;
            }
        }

    }
}
