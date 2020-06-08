using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day7_Coin_Change_2
    {
        public int Change(int amount, int[] coins)
        {
            int[][] dp = new int[coins.Length + 1][];
            for (int i = 0; i <= coins.Length; i++) {
                dp[i] = new int[amount + 1];
                dp[i][0] = 1;
            }

            for(int i=1; i <= coins.Length; i++)
            {
                for (int j = 1; j <= amount; j++) {
                    var index = j - coins[i - 1];
                    if (index >= 0) {
                        dp[i][j] = dp[i][index];
                    }
                    dp[i][j] += dp[i - 1][j];
                }
            }

            for (int i = 0; i <= coins.Length; i++) {
                for (int j = 0; j <= amount; j++) {
                    Console.Write($"{dp[i][j]} ");
                }
                Console.WriteLine();
            }

            return dp[coins.Length][amount];
        }

    }
}
