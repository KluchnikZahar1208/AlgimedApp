namespace AlgimedApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.button_ReadExc = new System.Windows.Forms.Button();
            this.checkedListBox_Data = new System.Windows.Forms.CheckedListBox();
            this.button_FillCheckedData = new System.Windows.Forms.Button();
            this.button_AddToColumns = new System.Windows.Forms.Button();
            this.button_AddToRows = new System.Windows.Forms.Button();
            this.dataGridView_Matrix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result.Location = new System.Drawing.Point(18, 35);
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.RowTemplate.Height = 25;
            this.dataGridView_Result.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_Result.TabIndex = 0;
            // 
            // button_ReadExc
            // 
            this.button_ReadExc.Location = new System.Drawing.Point(334, 198);
            this.button_ReadExc.Name = "button_ReadExc";
            this.button_ReadExc.Size = new System.Drawing.Size(100, 38);
            this.button_ReadExc.TabIndex = 1;
            this.button_ReadExc.Text = "Fill Data";
            this.button_ReadExc.UseVisualStyleBackColor = true;
            this.button_ReadExc.Click += new System.EventHandler(this.button_ReadExc_Click);
            // 
            // checkedListBox_Data
            // 
            this.checkedListBox_Data.CheckOnClick = true;
            this.checkedListBox_Data.FormattingEnabled = true;
            this.checkedListBox_Data.Location = new System.Drawing.Point(312, 35);
            this.checkedListBox_Data.Name = "checkedListBox_Data";
            this.checkedListBox_Data.Size = new System.Drawing.Size(143, 148);
            this.checkedListBox_Data.TabIndex = 2;
            // 
            // button_FillCheckedData
            // 
            this.button_FillCheckedData.Location = new System.Drawing.Point(53, 196);
            this.button_FillCheckedData.Name = "button_FillCheckedData";
            this.button_FillCheckedData.Size = new System.Drawing.Size(75, 23);
            this.button_FillCheckedData.TabIndex = 3;
            this.button_FillCheckedData.Text = "button1";
            this.button_FillCheckedData.UseVisualStyleBackColor = true;
            this.button_FillCheckedData.Click += new System.EventHandler(this.button_FillCheckedData_Click);
            // 
            // button_AddToColumns
            // 
            this.button_AddToColumns.Location = new System.Drawing.Point(362, 265);
            this.button_AddToColumns.Name = "button_AddToColumns";
            this.button_AddToColumns.Size = new System.Drawing.Size(75, 23);
            this.button_AddToColumns.TabIndex = 4;
            this.button_AddToColumns.Text = "Columns";
            this.button_AddToColumns.UseVisualStyleBackColor = true;
            this.button_AddToColumns.Click += new System.EventHandler(this.button_AddToColumns_Click);
            // 
            // button_AddToRows
            // 
            this.button_AddToRows.Location = new System.Drawing.Point(362, 310);
            this.button_AddToRows.Name = "button_AddToRows";
            this.button_AddToRows.Size = new System.Drawing.Size(75, 23);
            this.button_AddToRows.TabIndex = 5;
            this.button_AddToRows.Text = "Rows";
            this.button_AddToRows.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Matrix
            // 
            this.dataGridView_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Matrix.Location = new System.Drawing.Point(18, 245);
            this.dataGridView_Matrix.Name = "dataGridView_Matrix";
            this.dataGridView_Matrix.RowTemplate.Height = 25;
            this.dataGridView_Matrix.Size = new System.Drawing.Size(300, 172);
            this.dataGridView_Matrix.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Matrix);
            this.Controls.Add(this.button_AddToRows);
            this.Controls.Add(this.button_AddToColumns);
            this.Controls.Add(this.button_FillCheckedData);
            this.Controls.Add(this.checkedListBox_Data);
            this.Controls.Add(this.button_ReadExc);
            this.Controls.Add(this.dataGridView_Result);
            this.Name = "MainForm";
            this.Text = "da";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Matrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_Result;
        private Button button_ReadExc;
        private CheckedListBox checkedListBox_Data;
        private Button button_FillCheckedData;
        private Button button_AddToColumns;
        private Button button_AddToRows;
        private DataGridView dataGridView_Matrix;
    }
}