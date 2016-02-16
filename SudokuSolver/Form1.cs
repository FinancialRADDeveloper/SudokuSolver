using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            int [,] s = new int[9,9];
            
            //lets set up a grid with some values in 

            s[0, 0] = 5;
            s[0, 1] = 3;


            var SGrid = new SudokuGrid(s);

            
            

        }
    }


    class SudokuGrid
    {
        private int[,] myGrid = new int[9, 9];
        private bool[,] userEntered = new bool[9, 9];
        
        /*
        public int GridValue[int row, int column] 
        {
            
        }
         */

        public int this[int row, int column]
        {
            get
            {
                return myGrid[row, column];
            }
            set
            {
                myGrid[row, column] = value;
            }
        }


        public SudokuGrid(int[,] InitialValues)
        {
            myGrid = InitialValues;

            // find the non blank values and then set the userEntered to False for them 

        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            myGrid.GetUpperBound(1);
            

            return "Not yet implemented";
        }
    }

}
