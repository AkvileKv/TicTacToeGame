using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Logic
    {
        public int boardSize;
        public string[,] boardArray = new string[8, 8];
        public int quantityX, quantityO;
        public string win = "No winner";

        public string CheckRow()
          {
              for (int i = 0; i<boardSize; i++)
              {
                  quantityX = 0;
                  quantityO = 0;

                for (int j = 0; j < boardSize; j++)
                {
                    if (boardArray[i, j] == "X")
                    {
                        quantityX++;

                        if (quantityX == 3)
                        {
                            win = "X wins!";
                        }
                    }
                    else
                    {
                        quantityX = 0;
                    }
                    if (boardArray[i, j] == "O")
                    {
                        quantityO++;

                        if (quantityO == 3)
                        {
                            win = "O wins!";
                        }                      
                    }
                    else
                    {
                        quantityO = 0;
                    }
                }
              }

            return win;
          }

        public string CheckColumn()
        {
            for (int i = 0; i < boardSize; i++)
            {
                quantityX = 0;
                quantityO = 0;

                for (int j = 0; j < boardSize; j++)
                {
                    if (boardArray[j, i] == "X")
                    {
                        quantityX++;

                        if (quantityX == 3)
                        {
                            win = "X wins!";
                        }
                    }
                    else
                    {
                        quantityX = 0;
                    }
                    if (boardArray[j, i] == "O")
                    {
                        quantityO++;

                        if (quantityO == 3)
                        {
                            win = "O wins!";
                        }
                    }
                    else
                    {
                        quantityO = 0;
                    }
                }
            }

            return win;
        }

        public string CheckCross1() 
        {
            quantityX = 0;
            quantityO = 0;

            for (int i = 0; i < boardSize; i++)
            {
                                     
                    if (boardArray[i, i] == "X")
                    {
                        quantityX++;

                        if (quantityX == 3)
                        {
                            win = "X wins!";
                        }
                    }
                    else
                    {
                        quantityX = 0;
                    }
                    if (boardArray[i, i] == "O")
                    {
                        quantityO++;

                        if (quantityO == 3)
                        {
                            win = "O wins!";
                        }
                    }
                    else
                    {
                        quantityO = 0;
                    }             
            }
            return win;
        }

        public string CheckCross2()
        {
            quantityX = 0;
            quantityO = 0;
            int j = boardSize - 1;
            for (int i = 0; i < boardSize; i++)
            {

                if (boardArray[i, j] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, j] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
                j--;
            }
            return win;
        }

        public string CheckCross3()
        {
            quantityX = 0;
            quantityO = 0;

            for (int i = 0; i < boardSize; i++)
            {

                if (boardArray[i, i+1] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, i+1] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
            }
            return win;
        }

        public string CheckCross4()
        {
            quantityX = 0;
            quantityO = 0;

            for (int i = 1; i < boardSize; i++)
            {

                if (boardArray[i, i-1] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, i-1] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
            }
            return win;
        }

        public string CheckCross5() // Using only for 4x4 table
        {
            quantityX = 0;
            quantityO = 0;
            int j = 3;
            for (int i = 1; i < boardSize; i++)
            {

                if (boardArray[i, j] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, j] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
                j--;
            }
            return win;
        }

        public string CheckCross6()
        {
            quantityX = 0;
            quantityO = 0;
            int j = 0;
            for (int i = 2; i >= 0; i--)
            {

                if (boardArray[i, j] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, j] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
                j++;
            }
            return win;
        }

        public string CheckCross7()
        {
            quantityX = 0;
            quantityO = 0;
            int j = 0;
            for (int i = 2; i <=boardSize; i++)
            {

                if (boardArray[i, j] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, j] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
                j++;
            }
            return win;
        }


        public string CheckCross8()
        {
            quantityX = 0;
            quantityO = 0;
            int j = 2;
            for (int i = 0; i <= boardSize; i++)
            {

                if (boardArray[i, j] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, j] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
                j++;
            }
            return win;
        }

        public string CheckCross9()
        {
            quantityX = 0;
            quantityO = 0;
            int j = 1;
            for (int i = 4; i >= 0; i--)
            {

                if (boardArray[i, j] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, j] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
                j++;
            }
            return win;
        }

        public string CheckCross10()
        {
            quantityX = 0;
            quantityO = 0;
            int j = 2;
            for (int i = 4; i >= 0; i--)
            {

                if (boardArray[i, j] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, j] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
                j++;
            }
            return win;
        }

        public string CheckCross11()
        {
            quantityX = 0;
            quantityO = 0;
            int j = 0;
            for (int i = 3; i >= 0; i--)
            {

                if (boardArray[i, j] == "X")
                {
                    quantityX++;

                    if (quantityX == 3)
                    {
                        win = "X wins!";
                    }
                }
                else
                {
                    quantityX = 0;
                }
                if (boardArray[i, j] == "O")
                {
                    quantityO++;

                    if (quantityO == 3)
                    {
                        win = "O wins!";
                    }
                }
                else
                {
                    quantityO = 0;
                }
                j++;
            }
            return win;
        }

    } 
}
