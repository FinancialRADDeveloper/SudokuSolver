namespace SudokuSolver
{
    partial class SudokuDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SudokuGridView = new System.Windows.Forms.DataGridView();
            this.txtLogDisplay = new System.Windows.Forms.RichTextBox();
            this.PreSuppliedGridView = new System.Windows.Forms.DataGridView();
            this.FileNameLbl = new System.Windows.Forms.Label();
            this.SudokuStatusStrip = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFileNameDisplay = new System.Windows.Forms.TextBox();
            this.lblLogInfo = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGetValsForCell = new System.Windows.Forms.Button();
            this.TileGridView = new System.Windows.Forms.DataGridView();
            this.txtLowestInTile = new System.Windows.Forms.TextBox();
            this.btnGetLowestValues = new System.Windows.Forms.Button();
            this.ColumnForCellDGV = new System.Windows.Forms.DataGridView();
            this.lblColForSelectedCell = new System.Windows.Forms.Label();
            this.RowForSelectedCellDGV = new System.Windows.Forms.DataGridView();
            this.lblRowForSelectedCell = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLowestValForCol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLowestValueInRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLowestValForCell = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreSuppliedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnForCellDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowForSelectedCellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SudokuGridView
            // 
            this.SudokuGridView.AllowUserToAddRows = false;
            this.SudokuGridView.AllowUserToDeleteRows = false;
            this.SudokuGridView.AllowUserToResizeRows = false;
            this.SudokuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.SudokuGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.SudokuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SudokuGridView.ColumnHeadersVisible = false;
            this.SudokuGridView.Location = new System.Drawing.Point(12, 12);
            this.SudokuGridView.Name = "SudokuGridView";
            this.SudokuGridView.RowHeadersVisible = false;
            this.SudokuGridView.RowHeadersWidth = 18;
            this.SudokuGridView.Size = new System.Drawing.Size(272, 251);
            this.SudokuGridView.TabIndex = 0;
            this.SudokuGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SudokuGridView_CellValueChanged);
            // 
            // txtLogDisplay
            // 
            this.txtLogDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogDisplay.Location = new System.Drawing.Point(12, 306);
            this.txtLogDisplay.Name = "txtLogDisplay";
            this.txtLogDisplay.Size = new System.Drawing.Size(272, 69);
            this.txtLogDisplay.TabIndex = 1;
            this.txtLogDisplay.Text = "";
            // 
            // PreSuppliedGridView
            // 
            this.PreSuppliedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreSuppliedGridView.Location = new System.Drawing.Point(811, 40);
            this.PreSuppliedGridView.Name = "PreSuppliedGridView";
            this.PreSuppliedGridView.Size = new System.Drawing.Size(112, 109);
            this.PreSuppliedGridView.TabIndex = 2;
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.Location = new System.Drawing.Point(319, 277);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(54, 13);
            this.FileNameLbl.TabIndex = 3;
            this.FileNameLbl.Text = "FileName:";
            // 
            // SudokuStatusStrip
            // 
            this.SudokuStatusStrip.Location = new System.Drawing.Point(0, 402);
            this.SudokuStatusStrip.Name = "SudokuStatusStrip";
            this.SudokuStatusStrip.Size = new System.Drawing.Size(935, 22);
            this.SudokuStatusStrip.TabIndex = 4;
            this.SudokuStatusStrip.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(542, 346);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(104, 28);
            this.btnSaveAs.TabIndex = 6;
            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(322, 346);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(104, 28);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFileNameDisplay
            // 
            this.txtFileNameDisplay.Location = new System.Drawing.Point(322, 305);
            this.txtFileNameDisplay.Name = "txtFileNameDisplay";
            this.txtFileNameDisplay.Size = new System.Drawing.Size(324, 20);
            this.txtFileNameDisplay.TabIndex = 8;
            // 
            // lblLogInfo
            // 
            this.lblLogInfo.AutoSize = true;
            this.lblLogInfo.Location = new System.Drawing.Point(12, 277);
            this.lblLogInfo.Name = "lblLogInfo";
            this.lblLogInfo.Size = new System.Drawing.Size(80, 13);
            this.lblLogInfo.TabIndex = 9;
            this.lblLogInfo.Text = "Logging Output";
            // 
            // btnGetValsForCell
            // 
            this.btnGetValsForCell.Location = new System.Drawing.Point(371, 40);
            this.btnGetValsForCell.Name = "btnGetValsForCell";
            this.btnGetValsForCell.Size = new System.Drawing.Size(140, 31);
            this.btnGetValsForCell.TabIndex = 11;
            this.btnGetValsForCell.Text = "Get Vals for Cell";
            this.btnGetValsForCell.UseVisualStyleBackColor = true;
            this.btnGetValsForCell.Click += new System.EventHandler(this.btnGetTileForCell_Click);
            // 
            // TileGridView
            // 
            this.TileGridView.AllowUserToAddRows = false;
            this.TileGridView.AllowUserToDeleteRows = false;
            this.TileGridView.AllowUserToResizeRows = false;
            this.TileGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.TileGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.TileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TileGridView.ColumnHeadersVisible = false;
            this.TileGridView.Location = new System.Drawing.Point(371, 77);
            this.TileGridView.Name = "TileGridView";
            this.TileGridView.RowHeadersVisible = false;
            this.TileGridView.RowHeadersWidth = 18;
            this.TileGridView.Size = new System.Drawing.Size(140, 129);
            this.TileGridView.TabIndex = 12;
            // 
            // txtLowestInTile
            // 
            this.txtLowestInTile.Location = new System.Drawing.Point(533, 105);
            this.txtLowestInTile.Name = "txtLowestInTile";
            this.txtLowestInTile.Size = new System.Drawing.Size(28, 20);
            this.txtLowestInTile.TabIndex = 14;
            // 
            // btnGetLowestValues
            // 
            this.btnGetLowestValues.Location = new System.Drawing.Point(533, 42);
            this.btnGetLowestValues.Name = "btnGetLowestValues";
            this.btnGetLowestValues.Size = new System.Drawing.Size(129, 28);
            this.btnGetLowestValues.TabIndex = 15;
            this.btnGetLowestValues.Text = "Compute Lowest Values";
            this.btnGetLowestValues.UseVisualStyleBackColor = true;
            this.btnGetLowestValues.Click += new System.EventHandler(this.btnGetLowestValue_Click);
            // 
            // ColumnForCellDGV
            // 
            this.ColumnForCellDGV.AllowUserToAddRows = false;
            this.ColumnForCellDGV.AllowUserToDeleteRows = false;
            this.ColumnForCellDGV.AllowUserToResizeRows = false;
            this.ColumnForCellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.ColumnForCellDGV.BackgroundColor = System.Drawing.Color.Beige;
            this.ColumnForCellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnForCellDGV.ColumnHeadersVisible = false;
            this.ColumnForCellDGV.Location = new System.Drawing.Point(322, 40);
            this.ColumnForCellDGV.Name = "ColumnForCellDGV";
            this.ColumnForCellDGV.RowHeadersVisible = false;
            this.ColumnForCellDGV.RowHeadersWidth = 18;
            this.ColumnForCellDGV.Size = new System.Drawing.Size(33, 191);
            this.ColumnForCellDGV.TabIndex = 16;
            // 
            // lblColForSelectedCell
            // 
            this.lblColForSelectedCell.AutoSize = true;
            this.lblColForSelectedCell.Location = new System.Drawing.Point(319, 12);
            this.lblColForSelectedCell.Name = "lblColForSelectedCell";
            this.lblColForSelectedCell.Size = new System.Drawing.Size(119, 13);
            this.lblColForSelectedCell.TabIndex = 17;
            this.lblColForSelectedCell.Text = "Column for selected cell";
            // 
            // RowForSelectedCellDGV
            // 
            this.RowForSelectedCellDGV.AllowUserToAddRows = false;
            this.RowForSelectedCellDGV.AllowUserToDeleteRows = false;
            this.RowForSelectedCellDGV.AllowUserToResizeRows = false;
            this.RowForSelectedCellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.RowForSelectedCellDGV.BackgroundColor = System.Drawing.Color.Beige;
            this.RowForSelectedCellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RowForSelectedCellDGV.ColumnHeadersVisible = false;
            this.RowForSelectedCellDGV.Location = new System.Drawing.Point(371, 234);
            this.RowForSelectedCellDGV.Name = "RowForSelectedCellDGV";
            this.RowForSelectedCellDGV.RowHeadersVisible = false;
            this.RowForSelectedCellDGV.RowHeadersWidth = 18;
            this.RowForSelectedCellDGV.Size = new System.Drawing.Size(195, 29);
            this.RowForSelectedCellDGV.TabIndex = 18;
            // 
            // lblRowForSelectedCell
            // 
            this.lblRowForSelectedCell.AutoSize = true;
            this.lblRowForSelectedCell.Location = new System.Drawing.Point(368, 209);
            this.lblRowForSelectedCell.Name = "lblRowForSelectedCell";
            this.lblRowForSelectedCell.Size = new System.Drawing.Size(106, 13);
            this.lblRowForSelectedCell.TabIndex = 19;
            this.lblRowForSelectedCell.Text = "Row for selected cell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lowest Value in Tile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lowest Value in Col";
            // 
            // txtLowestValForCol
            // 
            this.txtLowestValForCol.Location = new System.Drawing.Point(533, 177);
            this.txtLowestValForCol.Name = "txtLowestValForCol";
            this.txtLowestValForCol.Size = new System.Drawing.Size(28, 20);
            this.txtLowestValForCol.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lowest Value in Row";
            // 
            // txtLowestValueInRow
            // 
            this.txtLowestValueInRow.Location = new System.Drawing.Point(673, 105);
            this.txtLowestValueInRow.Name = "txtLowestValueInRow";
            this.txtLowestValueInRow.Size = new System.Drawing.Size(28, 20);
            this.txtLowestValueInRow.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Lowest Value for Cell";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLowestValForCell
            // 
            this.txtLowestValForCell.Location = new System.Drawing.Point(673, 177);
            this.txtLowestValForCell.Name = "txtLowestValForCell";
            this.txtLowestValForCell.Size = new System.Drawing.Size(28, 20);
            this.txtLowestValForCell.TabIndex = 25;
            this.txtLowestValForCell.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SudokuDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLowestValForCell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLowestValueInRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLowestValForCol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRowForSelectedCell);
            this.Controls.Add(this.RowForSelectedCellDGV);
            this.Controls.Add(this.lblColForSelectedCell);
            this.Controls.Add(this.ColumnForCellDGV);
            this.Controls.Add(this.btnGetLowestValues);
            this.Controls.Add(this.txtLowestInTile);
            this.Controls.Add(this.TileGridView);
            this.Controls.Add(this.btnGetValsForCell);
            this.Controls.Add(this.FileNameLbl);
            this.Controls.Add(this.lblLogInfo);
            this.Controls.Add(this.txtFileNameDisplay);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.SudokuStatusStrip);
            this.Controls.Add(this.PreSuppliedGridView);
            this.Controls.Add(this.txtLogDisplay);
            this.Controls.Add(this.SudokuGridView);
            this.Name = "SudokuDisplay";
            this.Text = "Sudoku Solver - FinancialRADDeveloper";
            ((System.ComponentModel.ISupportInitialize)(this.SudokuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreSuppliedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnForCellDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowForSelectedCellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SudokuGridView;
        private System.Windows.Forms.RichTextBox txtLogDisplay;
        private System.Windows.Forms.DataGridView PreSuppliedGridView;
        private System.Windows.Forms.Label FileNameLbl;
        private System.Windows.Forms.StatusStrip SudokuStatusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFileNameDisplay;
        private System.Windows.Forms.Label lblLogInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGetValsForCell;
        private System.Windows.Forms.DataGridView TileGridView;
        private System.Windows.Forms.TextBox txtLowestInTile;
        private System.Windows.Forms.Button btnGetLowestValues;
        private System.Windows.Forms.DataGridView ColumnForCellDGV;
        private System.Windows.Forms.Label lblColForSelectedCell;
        private System.Windows.Forms.DataGridView RowForSelectedCellDGV;
        private System.Windows.Forms.Label lblRowForSelectedCell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLowestValForCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLowestValueInRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLowestValForCell;
    }
}

