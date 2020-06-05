using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Random;
using MathNet.Numerics.Distributions;
using System.IO;


namespace RandomGenerator
{
    public partial class FrmRandGen : Form
    {
        public FrmRandGen()
        {
            InitializeComponent();
            CalNumber() ;
            ReadTile();
        }

        public static string Tile1 { get; private set; }
        public static string Tile2 { get; private set; }

        public static string Tile3 { get; private set; }

        private static string TileMeaning = @"..\..\..\..\..\MyAppC#\MahjongDivinationApp\MahjongOracle.txt";


        private static int CalNumber()
        {
            
            {
                Random random = new SystemRandomSource();
                 decimal MahjongNumber = (random.NextDecimal() * 42) + 1;
                Math.Round(MahjongNumber);
                return (int)MahjongNumber;
               


            }
        }

        private static string ReadTile()
        {

            string line = null;
            int lineNumber = CalNumber();
            try
            {

                using (var text = new StreamReader(TileMeaning))
                {
                    text.ReadLine();
                    for (int i = 1; i < lineNumber; i++)
                    {
                        text.ReadLine();
                        if (text.EndOfStream)
                        {
                            Console.Write($"End of File. The file contains only this number {i} of lines. ");
                            break;
                        }

                    }
                    line = text.ReadLine();
                }


            }

            catch (IOException e)
            {
                Console.WriteLine("There is an error in reading the file.");
                Console.WriteLine(e.Message);
            }

            return line;
        }
        private void btnGenRand_Click(object sender, EventArgs e)
        {
            Tile1 = ReadTile();
            Tile2 = ReadTile();
            Tile3 = ReadTile();

            //compare Tile1 and Tile2
            if ((Tile1 != Tile2) && (Tile1 != Tile3) && (Tile2 != Tile3))
            {
                MessageBox.Show( "Your Present, Past and Future Mahjong Reading: " + "\n" + "\n"+
                                 "Past   : " + Tile1 + "\n "+ "\n" +
                                "Present  : " + Tile2 + "\n "+ "\n" +
                                "Future:   : " + Tile3);

               
            }
            
           
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void FrmRandGen_Load(object sender, EventArgs e)
        {

        }
    }
}
