using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.classes
{
    internal class singleGame
    {
        private string[] player = new string[] { "X", "O" };
        private bool isFinished = false;
        private string playerWinner;
        private int currentPlayer = 0;
        private Guid gameGuid = new Guid();

        public singleGame()
        {
            checkIfFinished();
        }

        internal int[] playerField { get; } = new int[]
        {
            90,91,92,93,94,95,96,97,98
        };

        internal string[] getCurrentPlayField()
        {
            string[] playField = new string[9];

            int counter = 0;
            while(counter < playField.Length)
            {
                playField[counter] = resolveIdToPlayerSymbol(playerField[counter]);
                counter++;
            }

            return playField;
        }

        private string resolveIdToPlayerSymbol(int id)
        {
            string playerSymbol = "";
            if(id <= 1)
            {
                playerSymbol = player[id];
            }

            return playerSymbol;
        }

        private void setNextPlayer()
        {
            if(currentPlayer == 0)
            {
                currentPlayer = 1;
            }else if(currentPlayer == 1)
            {
                currentPlayer = 0;
            }
        }

        internal void setPlayerOnField(int fieldID)
        {
            playerField[fieldID] = currentPlayer;
            setNextPlayer();
        }

        internal bool checkIfFinished()
        {
            int horizontalCounter = 0;
            while(horizontalCounter < playerField.Length)
            {
                if ((playerField[horizontalCounter] == playerField[horizontalCounter + 1]) && (playerField[horizontalCounter + 1] == playerField[horizontalCounter + 2]))
                {
                    isFinished = true;
                    break;
                }
                else
                {
                    horizontalCounter += 3;
                }
            }

            int verticalCounter = 0;

            while(verticalCounter < playerField.Length / 3)
            {
                if((playerField[verticalCounter] == playerField[verticalCounter + 3]) && (playerField[verticalCounter + 3] == playerField[verticalCounter + 6]))
                {
                    isFinished = true;
                    break;
                }
                else
                {
                    verticalCounter += 1;
                }
            }

            if ((playerField[0] == playerField[4]) && (playerField[4] == playerField[8]))
            {
                isFinished = true;
            }

            if ((playerField[2] == playerField[4]) && (playerField[4] == playerField[6]))
            {
                isFinished = true;
            }

            return isFinished;
        }
    }
}
