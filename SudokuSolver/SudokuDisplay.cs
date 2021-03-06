﻿using System;
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

        private List<int> dividers = new List<int>() { 2, 5 };
        private int pad = 2;

        public SudokuDisplay()
        {
            InitializeComponent();

            int[,] s = new int[9, 9];

            //lets set up a grid with some values in 
            s[0, 0] = 5; s[0, 1] = 3; s[0, 4] = 7;
            s[1, 0] = 6; s[1, 3] = 1; s[1, 4] = 9; s[1, 5] = 5;
            s[2, 1] = 9; s[2, 2] = 8; s[2, 7] = 6;
            s[3, 0] = 8; s[3, 4] = 6; s[3, 8] = 3;
            s[4, 0] = 4; s[4, 3] = 8; s[4, 5] = 3; s[4, 8] = 1;
            s[5, 0] = 7; s[5, 4] = 2; s[5, 8] = 6;
            s[6, 1] = 6; s[6, 6] = 2; s[6, 7] = 8;
            s[7, 3] = 4; s[7, 4] = 1; s[7, 5] = 9; s[7, 8] = 5;
            s[8, 4] = 8; s[8, 7] = 7; s[8, 8] = 9;

            SGrid = new SudokuGrid(s);

            txtLogDisplay.Text = SGrid.ToString();
            SGrid.UpdateDataGrid(SudokuGridView);
            InitializeDataGridView(SudokuGridView);

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


        private void btnGetTileForCell_Click(object sender, EventArgs e)
        {
            // get selected Cell and then create an Tile and then Display
            int[,] myTileArray = SGrid.GetTileArrayForCell(SudokuGridView.CurrentCell.RowIndex, SudokuGridView.CurrentCell.ColumnIndex);

            tile = SGrid.GetTileForCell(SudokuGridView.CurrentCell.RowIndex, SudokuGridView.CurrentCell.ColumnIndex);

            tile.UpdateDataGrid(TileGridView);

            int[] colForCell = SGrid.GetColumn(SudokuGridView.CurrentCell.ColumnIndex);
            int[] rowForCell = SGrid.GetRow(SudokuGridView.CurrentCell.RowIndex);

            PopulateRowDataGridView(RowForSelectedCellDGV, rowForCell);
            PopulateColDataGridView(ColForSelectedCellDGV, colForCell);
        }

        private void PopulateRowDataGridView(DataGridView myDGV, int[] rowData)
        {

            var colCount = rowData.GetLength(0);
            myDGV.Rows.Clear();
            myDGV.ColumnCount = colCount;

            var row = new DataGridViewRow();

            for (int columnIndex = 0; columnIndex < colCount; ++columnIndex)
            {
                var tmp = "";
                var cell = new DataGridViewTextBoxCell();

                if (rowData[columnIndex] != 0)
                {
                    tmp = rowData[columnIndex].ToString();
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

        private void PopulateColDataGridView(DataGridView myDGV, int[] colData)
        {

            myDGV.Rows.Clear();
            myDGV.Columns.Clear();
            myDGV.Columns.Add("RowData", "x");
            string tmp;

            for (int i = 0; i < colData.Length; i++)
            {
                if (colData[i] > 0)
                {
                    tmp = colData[i].ToString();
                }
                else
                {
                    tmp = "";
                }
                myDGV.Rows.Add(new object[] { tmp });
            }
        }

        private void btnGetLowestValue_Click(object sender, EventArgs e)
        {
            
            var myTile = SGrid.GetTileForCell(SudokuGridView.CurrentCell.RowIndex, SudokuGridView.CurrentCell.ColumnIndex);

            int lowestNumInTile = myTile.MinimumValidNumber();
            

            txtLowestInTile.Text = lowestNumInTile.ToString();

            // check lowest value in Col
            int[] colForCell = SGrid.GetColumn(SudokuGridView.CurrentCell.ColumnIndex);
            int lowestValInCol = SGrid.GetLowestValueForCol(colForCell);
            txtLowestValForCol.Text = lowestValInCol.ToString();


            //check lowest value in Row
            int[] rowForCell = SGrid.GetColumn(SudokuGridView.CurrentCell.RowIndex);
            int lowestValInRow = SGrid.GetLowestValueForArray(rowForCell);
            txtLowestValueInRow.Text = lowestValInRow.ToString();

            

            // look at the lowest value for all 3. 

            txtLowestValForCell.Text = SGrid.GetLowestValueForCell(SudokuGridView.CurrentCell.RowIndex, SudokuGridView.CurrentCell.ColumnIndex).ToString();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void SudokuGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String CellValue = SudokuGridView.SelectedCells[0].Value.ToString();
            
            btnGetLowestValues.Enabled = (CellValue == "");

        }


        private void InitializeDataGridView(DataGridView myDGV)
        {
            myDGV.AllowUserToAddRows = false;

            for (int i = 0; i < 9; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                //column.HeaderText = "c" + (i + 1);
                column.Width = 5 + (dividers.Contains(i) ? pad : 0);
                //myDGV.Columns.Add(column);
            }

            for (int i = 0; i < 9; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                //row.CreateCells(myDGV);
                row.Height = row.Height + (dividers.Contains(i) ? pad : 0);
                //myDGV.Rows.Add(row);


            }

            foreach (int div in dividers)
            {
                myDGV.Columns[div].DividerWidth = pad;
                myDGV.Rows[div].DividerHeight = pad;
            }
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

            int[] col = new int[myGrid.GetUpperBound(1)];

            for (int i = 0; i < myGrid.GetUpperBound(1); i++)
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

        public int GetLowestValueForRow(int[] row)
        {
            List<int> myList = new List<int>();
            int[,] myArray;

            myList.AddRange(GetStartingNumbers());

            for (int i = 0; i < row.GetLength(0); i++)
            {
                    if (row[i] != 0)
                    {
                        myList.Remove(row[i]);
                    }
            }

            return myList.Min();
        }


        public int GetLowestValueForArray(int[] array)
        {
            List<int> myList = new List<int>();
            int[,] myArray;

            myList.AddRange(GetStartingNumbers());

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] != 0)
                {
                    myList.Remove(array[i]);
                }
            }

            return myList.Min();
        }



        public int GetLowestValueForCol(int[] col)
        {
            // I know I could 

            List<int> myList = new List<int>();
            int[,] myArray;

            myList.AddRange(GetStartingNumbers());

            for (int i = 0; i < col.GetLength(0); i++)
            {
                if (col[i] != 0)
                {
                    myList.Remove(col[i]);
                }
            }

            return myList.Min();
        }

        public int GetLowestValueForCell(int row, int col)
        {
            var myTile = GetTileForCell(row, col);

            int lowestNumInTile = myTile.MinimumValidNumber();
            int lowestValInCol = GetLowestValueForCol(GetColumn(col));
            int lowestValInRow = GetLowestValueForArray(GetRow(row));

            List<int> myList = new List<int>();

            myList.Add(lowestNumInTile);
            myList.Add(lowestValInCol);
            myList.Add(lowestValInRow);

            return myList.Max();

            
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
