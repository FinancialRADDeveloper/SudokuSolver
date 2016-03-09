using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace SudokuSolver
{
    public partial class SudokuDisplay : Form
    {
        SudokuGrid SGrid;
        Tile tile;

        public SudokuDisplay()
        {
            InitializeComponent();

            int[,] s = new int[9, 9];

            //lets set up a grid with some values in 
            s[0, 0] = 5;
            s[0, 1] = 3;
            s[0, 4] = 7;
            s[1, 0] = 6;
            s[1, 3] = 1;
            s[1, 4] = 9;


            SGrid = new SudokuGrid(s);

            txtLogDisplay.Text = SGrid.ToString();

            SGrid.UpdateDataGrid(SudokuGridView);

        }

        private void SudokuGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int val;

            if (Int32.TryParse(SudokuGridView.SelectedCells[0].Value.ToString(), out val) == true)
            {
                if (val > 0 && val <= 9)
                {
                    SGrid[e.RowIndex, e.ColumnIndex] = val;
                    FileNameLbl.Text = "";
                }
                else
                {
                    SGrid[e.RowIndex, e.ColumnIndex] = 0;
                    FileNameLbl.Text = "Please enter a number between 1 and 9";
                }

            }
            else
            {
                SGrid[e.RowIndex, e.ColumnIndex] = 0;
                FileNameLbl.Text = "Input must be an Integer bewteen 1 and 9";
            }

            SGrid.UpdateDataGrid(SudokuGridView);
            SudokuGridView.EndEdit();

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName;

            fileName = txtFileNameDisplay.Text;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                SGrid.LoadGridFromFile(fileName);
                SGrid.UpdateDataGrid(SudokuGridView);
            }
            else
            {
                fileName = "";
            }

            txtFileNameDisplay.Text = fileName;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            string FileToSave;

            saveFileDialog1.DefaultExt = "*.sdg";
            saveFileDialog1.Filter = "Sudoku Grid File(*.sdg)|*.sdg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileToSave = saveFileDialog1.FileName;
                SGrid.SaveGridToFile(FileToSave);
            }
            else
            {
                FileToSave = "";
            }

            txtFileNameDisplay.Text = FileToSave;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetTileForCell_Click(object sender, EventArgs e)
        {
            // get selected Cell and then create an Tile and then Display
            int[,] myTileArray = SGrid.GetTileArrayForCell(SudokuGridView.CurrentCell.RowIndex, SudokuGridView.CurrentCell.ColumnIndex);

            tile = SGrid.GetTileForCell(SudokuGridView.CurrentCell.RowIndex, SudokuGridView.CurrentCell.ColumnIndex);

            tile.UpdateDataGrid(TileGridView);

            int[] colForCell = SGrid.GetColumn(SudokuGridView.CurrentCell.ColumnIndex);
            int[] rowForCell = SGrid.GetRow(SudokuGridView.CurrentCell.RowIndex);


        }

        private void PopulateRowDataGridView(DataGridView myDGV)
        {


        }




        private void btnGetLowestValue_Click(object sender, EventArgs e)
        {
            int lowestNuminTile = tile.MinimumValidNumber();

            txtLowestInTile.Text = lowestNuminTile.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class SudokuGrid
    {
        private int[,] myGrid;
        private bool[,] PreSuppliedValue;

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
            PreSuppliedValue = new bool[InitialValues.GetLength(0), InitialValues.GetLength(1)];

            // find the non 0 values and then set the PreSuppliedValue to True for them 
            for (int rowCount = 0; rowCount < InitialValues.GetLength(0); rowCount++)
            {
                for (int colCount = 0; colCount < InitialValues.GetLength(1); colCount++)
                {
                    PreSuppliedValue[rowCount, colCount] = InitialValues[rowCount, colCount] > 0;
                }
            }

        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            int width, height;

            height = myGrid.GetUpperBound(0) + 1;
            width = myGrid.GetUpperBound(1) + 1;

            sb.AppendLine();

            for (int i = 0; i <= myGrid.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= myGrid.GetUpperBound(1); j++)
                {
                    sb.Append(this[i, j] + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public void UpdateDataGrid(DataGridView myDGV)
        {
            var rowCount = myGrid.GetLength(0);
            var rowLength = myGrid.GetLength(1);

            myDGV.Rows.Clear();

            myDGV.ColumnCount = rowLength;

            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new DataGridViewRow();

                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    var tmp = "";
                    var cell = new DataGridViewTextBoxCell();

                    if (myGrid[rowIndex, columnIndex] != 0)
                    {
                        tmp = myGrid[rowIndex, columnIndex].ToString();
                    }
                    else
                    {
                        tmp = "";
                    }
                    cell.Value = tmp;
                    row.Cells.Add(cell);
                }
                myDGV.Rows.Add(row);
            }
        }

        public void SaveGridToFile(string FileName)
        {
            FileStream stream = File.Create(FileName);
            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, myGrid);
            stream.Close();
        }

        public void LoadGridFromFile(string FileName)
        {

            // Restore from file
            FileStream stream = File.OpenRead(FileName);
            var formatter = new BinaryFormatter();
            myGrid = (int[,])formatter.Deserialize(stream);
            stream.Close();

        }

        public Tile GetTileForCell(int row, int column)
        {

            int RowsInTile = myGrid.GetUpperBound(0) / 3;
            int ColsInTile = myGrid.GetUpperBound(1) / 3;

            int[,] TileAsArray = GetTileArrayForCell(row, column);



            return new Tile(TileAsArray);



        }

        public int[,] GetTileArrayForCell(int row, int column)
        {

            // a Sudoku Grid may have dimensions other than 9 by 9 but it will always be made up of 9 "tiles"
            // in the scope of this current implementation.  I just don't have the patience or the will for all 
            // the weird version of the puzzle just now. 
            int RowsInTile = myGrid.GetUpperBound(0) / 3;
            int ColsInTile = myGrid.GetUpperBound(1) / 3;


            int[,] TileAsArray = new int[3, 3];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TileAsArray[i, j] = myGrid[row - (row % 3) + i, column - (column % 3) + j];
                }
            }


            return TileAsArray;

        }

        public int[] GetStartingNumbers()
        {
            return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }


        public int[] GetColumn(int column)
        {

            int[] col = new int [myGrid.GetUpperBound(1)];

            for (int i = 0; i < myGrid.GetUpperBound(1); i++ )
            {
                col[i] = myGrid[i, column];
            }

            return col;
            
        }

        public int[] GetRow(int row)
        {

            int[] r = new int[myGrid.GetUpperBound(1)];

            for (int i = 0; i < myGrid.GetUpperBound(1); i++)
            {
                r[i] = myGrid[row, i];

            }

            return r;

        }

    }


    public class SudokuBruteForce : SudokuGrid
    {

        public SudokuBruteForce(int[,] s) : base(s) { }

        public void Solve()
        {
            // look at the internal grid and see 

        }



    }

    public class Tile
    {

        private int[,] myTile;
        private bool[,] PreSuppliedValue;

        public Tile(int[,] InitialValues)
        {
            myTile = InitialValues;
            PreSuppliedValue = new bool[InitialValues.GetLength(0), InitialValues.GetLength(1)];

            // find the non 0 values and then set the PreSuppliedValue to True for them 
            for (int rowCount = 0; rowCount < InitialValues.GetLength(0); rowCount++)
            {
                for (int colCount = 0; colCount < InitialValues.GetLength(1); colCount++)
                {
                    PreSuppliedValue[rowCount, colCount] = InitialValues[rowCount, colCount] > 0;
                }
            }

        }

        public Tile()
        {

        }

        public int[,] GetArray()
        {
            return myTile;
        }

        public int this[int row, int column]
        {
            get
            {
                return myTile[row, column];
            }
            set
            {
                myTile[row, column] = value;
            }
        }

        public int MinimumValidNumber()
        {
            List<int> myList = new List<int>();
            int[,] myArray;

            myList.AddRange(GetStartingNumbers());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (myTile[i, j] != 0)
                    {
                        myList.Remove(myTile[i, j]);
                    }
                }
            }

            return myList.Min();
        }

        public int[] GetStartingNumbers()
        {
            return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            int width, height;

            height = myTile.GetUpperBound(0) + 1;
            width = myTile.GetUpperBound(1) + 1;

            sb.AppendLine();

            for (int i = 0; i <= myTile.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= myTile.GetUpperBound(1); j++)
                {
                    sb.Append(this[i, j] + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }


        public void UpdateDataGrid(DataGridView myDGV)
        {
            var rowCount = myTile.GetLength(0);
            var rowLength = myTile.GetLength(1);

            myDGV.Rows.Clear();

            myDGV.ColumnCount = rowLength;

            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new DataGridViewRow();

                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    var tmp = "";
                    var cell = new DataGridViewTextBoxCell();

                    if (myTile[rowIndex, columnIndex] != 0)
                    {
                        tmp = myTile[rowIndex, columnIndex].ToString();
                    }
                    else
                    {
                        tmp = "";
                    }
                    cell.Value = tmp;
                    row.Cells.Add(cell);
                }
                myDGV.Rows.Add(row);
            }
        }

    }

}
