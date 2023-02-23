using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_BingoCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constraint 1 : use string to represent elements in bingo card
            // constraint 2 : use multi dimensional array
            #region ClassB
            //// declarations
            //string[,] cContent = new string[5, 5]; // card itself
            //Random rnd = new Random();             // rng
            //int tempHolder = 0;                    // number holder
            //string tempFormat = "";                // formatted number holder
            //bool duplicate = false;                // duplicate flag

            //// processing
            //for (int x = 0; x < cContent.GetLength(0); x++) // row
            //{
            //    for (int y = 0; y < cContent.GetLength(1); y++) // column
            //    {
            //        // reset flag
            //        duplicate = false;

            //        // generating the number
            //        tempHolder = rnd.Next(1, 16);
            //        tempHolder += (15 * y);

            //        // duplicate check
            //        for(int z = 0; z < x; z++)
            //        {
            //            if (int.Parse(cContent[z,y]) == tempHolder)
            //            {
            //                duplicate = true;
            //                break;
            //            }
            //        }

            //        if (!duplicate)
            //        {
            //            // formatting the number
            //            tempFormat = tempHolder + "";

            //            while (tempFormat.Length < 3)
            //            {
            //                tempFormat = "0" + tempFormat;
            //            }

            //            // outputting the number to the array
            //            cContent[x, y] = tempFormat;
            //        }
            //        else
            //        {
            //            y--;
            //        }
            //    }
            //}

            //// output
            //Console.WriteLine(" B \t I \t N \t G \t O");
            //for (int x = 0; x < cContent.GetLength(0); x++)
            //{
            //    for (int y = 0; y < cContent.GetLength(1); y++)
            //    {
            //        Console.Write(cContent[x, y] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey(); 
            #endregion

            // constraint 1 : use int to represent the elements in the bingo card
            // constraint 2 : use jagged array

            // declare jagged array
            int[][] bCard = new int[5][];

            Random rnd = new Random();
            int tempHolder = 0; // this will temporarily hold the random number
            string numFormat = "";
            bool duplicate = false;

            // initializing the inner array
            // manually
            //bCard[0] = new int[5];
            //bCard[1] = new int[5];
            //bCard[2] = new int[5];
            //bCard[3] = new int[5];
            //bCard[4] = new int[5];
            // automated 
            for(int x = 0; x < bCard.Length; x++)
                bCard[x] = new int[5];

            // putting numbers in the array
            for(int x = 0; x < bCard.Length; x++)
            {
                for(int y = 0; y < bCard[x].Length; y++)
                {
                    tempHolder = rnd.Next(1, 16);
                    tempHolder += y * 15;

                    // duplicate check
                    duplicate = false;

                    for(int z = 0; z < x; z++)
                    {
                        if (bCard[z][y] == tempHolder)
                        {
                            duplicate = true;
                            break;
                        }
                    }

                    if (!duplicate)
                        bCard[x][y] = tempHolder;
                    else
                        y--;
                    
                }
            }

            // displaying and formatting the array
            Console.WriteLine(" B \t I \t N \t G \t O");
            for (int x = 0; x < bCard.Length; x++)
            {
                for (int y = 0; y < bCard[x].Length; y++)
                {
                    numFormat = bCard[x][y] + "";
                    while(numFormat.Length < 3)
                        numFormat = "0" + numFormat;
                    Console.Write(numFormat + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
