using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace leetcode_june_challenge
{
    class Day3_Two_City_Scheduling
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            List<int> list = new List<int>();
            foreach (var cost in costs) {
                list.Add(cost[0] - cost[1]);
            }

            var sortedList = list
                .Select((x, i) => new KeyValuePair<int, int>(x, i))
                .OrderBy(x => x.Key)
                .ToList();

            int result = 0;
            for(int i=0; i < sortedList.Count; i++)
            {
                if (i > sortedList.Count / 2) {
                    result += costs[sortedList[i].Value][1];
                }
                else result += costs[sortedList[i].Value][0];
            }
           

            return result;
        }
    }
}
