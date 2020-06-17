using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace leetcode_june_challenge
{
    class Day17_Surrounded_Regions
    {
        public void Solve(char[][] board)
        {
            bool[][] connected = new bool[board.Length][];
            for (int i = 0; i < board.Length; i++) {
                connected[i] = new bool[board[i].Length];
            }
            for (int i = 0; i < board.Length; i++) {
                for(int j=0; j < board[i].Length; j++){
                    if ((i == 0)
                        || (i == board.Length - 1)
                        || (j == 0)
                        || (j == board[i].Length - 1)) 
                    {
                        if(board[i][j] == 'O')
                            DFS(connected, board, i, j);
                    }
                }
            }

            for (int i = 0; i < board.Length; i++) {
                for (int j = 0; j < board[i].Length; j++) {
                    if (board[i][j] == 'O') {
                        board[i][j] = connected[i][j] ? 'O' : 'X';
                    }
                }
            }
        }

        private void DFS(bool[][] connected, char[][] board, int i, int j)
        {
            
            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length) return;
            if (connected[i][j]) return; 
            if (board[i][j] == 'O') {
                connected[i][j] = true;
                DFS(connected, board, i + 1, j);
                DFS(connected, board, i - 1, j);
                DFS(connected, board, i, j + 1);
                DFS(connected, board, i, j - 1);
            }
        }
    }
}
