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
            this.lblTileTitle = new System.Windows.Forms.Label();
            this.btnGetTileForCell = new System.Windows.Forms.Button();
            this.TileGridView = new System.Windows.Forms.DataGridView();
            this.lblLowestValue = new System.Windows.Forms.Label();
            this.txtLowestInArray = new System.Windows.Forms.TextBox();
            this.btnGetLowestValue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreSuppliedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileGridView)).BeginInit();
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
            this.PreSuppliedGridView.Location = new System.Drawing.Point(322, 11);
            this.PreSuppliedGridView.Name = "PreSuppliedGridView";
            this.PreSuppliedGridView.Size = new System.Drawing.Size(291, 40);
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
            // lblTileTitle
            // 
            this.lblTileTitle.AutoSize = true;
            this.lblTileTitle.Location = new System.Drawing.Point(327, 67);
            this.lblTileTitle.Name = "lblTileTitle";
            this.lblTileTitle.Size = new System.Drawing.Size(48, 13);
            this.lblTileTitle.TabIndex = 10;
            this.lblTileTitle.Text = "TileArray";
            this.lblTileTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGetTileForCell
            // 
            this.btnGetTileForCell.Location = new System.Drawing.Point(322, 97);
            this.btnGetTileForCell.Name = "btnGetTileForCell";
            this.btnGetTileForCell.Size = new System.Drawing.Size(140, 31);
            this.btnGetTileForCell.TabIndex = 11;
            this.btnGetTileForCell.Text = "Get Tile for selected Cell";
            this.btnGetTileForCell.UseVisualStyleBackColor = true;
            this.btnGetTileForCell.Click += new System.EventHandler(this.btnGetTileForCell_Click);
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
            this.TileGridView.Location = new System.Drawing.Point(322, 134);
            this.TileGridView.Name = "TileGridView";
            this.TileGridView.RowHeadersVisible = false;
            this.TileGridView.RowHeadersWidth = 18;
            this.TileGridView.Size = new System.Drawing.Size(140, 129);
            this.TileGridView.TabIndex = 12;
            // 
            // lblLowestValue
            // 
            this.lblLowestValue.AutoSize = true;
            this.lblLowestValue.Location = new System.Drawing.Point(484, 76);
            this.lblLowestValue.Name = "lblLowestValue";
            this.lblLowestValue.Size = new System.Drawing.Size(109, 13);
            this.lblLowestValue.TabIndex = 13;
            this.lblLowestValue.Text = "Lowest Value in Array";
            // 
            // txtLowestInArray
            // 
            this.txtLowestInArray.Location = new System.Drawing.Point(484, 134);
            this.txtLowestInArray.Name = "txtLowestInArray";
            this.txtLowestInArray.Size = new System.Drawing.Size(28, 20);
            this.txtLowestInArray.TabIndex = 14;
            // 
            // btnGetLowestValue
            // 
            this.btnGetLowestValue.Location = new System.Drawing.Point(484, 99);
            this.btnGetLowestValue.Name = "btnGetLowestValue";
            this.btnGetLowestValue.Size = new System.Drawing.Size(129, 28);
            this.btnGetLowestValue.TabIndex = 15;
            this.btnGetLowestValue.Text = "Compute Lowest Value";
            this.btnGetLowestValue.UseVisualStyleBackColor = true;
            this.btnGetLowestValue.Click += new System.EventHandler(this.btnGetLowestValue_Click);
            // 
            // SudokuDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 424);
            this.Controls.Add(this.btnGetLowestValue);
            this.Controls.Add(this.txtLowestInArray);
            this.Controls.Add(this.lblLowestValue);
            this.Controls.Add(this.TileGridView);
            this.Controls.Add(this.btnGetTileForCell);
            this.Controls.Add(this.lblTileTitle);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SudokuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreSuppliedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileGridView)).EndInit();
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
        private System.Windows.Forms.Label lblTileTitle;
        private System.Windows.Forms.Button btnGetTileForCell;
        private System.Windows.Forms.DataGridView TileGridView;
        private System.Windows.Forms.Label lblLowestValue;
        private System.Windows.Forms.TextBox txtLowestInArray;
        private System.Windows.Forms.Button btnGetLowestValue;
    }
}

