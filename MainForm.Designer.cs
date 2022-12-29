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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.button_FillCheckedData = new System.Windows.Forms.Button();
            this.button_AddToColumns = new System.Windows.Forms.Button();
            this.button_AddToRows = new System.Windows.Forms.Button();
            this.dataGridView_Matrix = new System.Windows.Forms.DataGridView();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.button_GenerateResult = new System.Windows.Forms.Button();
            this.dataGridView_NewData = new System.Windows.Forms.DataGridView();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_ReadExc = new System.Windows.Forms.Button();
            this.checkedListBox_Data = new System.Windows.Forms.CheckedListBox();
            this.button_AddToDb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result.Location = new System.Drawing.Point(184, 2);
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.ReadOnly = true;
            this.dataGridView_Result.RowTemplate.Height = 25;
            this.dataGridView_Result.Size = new System.Drawing.Size(240, 238);
            this.dataGridView_Result.TabIndex = 0;
            // 
            // button_FillCheckedData
            // 
            this.button_FillCheckedData.Location = new System.Drawing.Point(248, 246);
            this.button_FillCheckedData.Name = "button_FillCheckedData";
            this.button_FillCheckedData.Size = new System.Drawing.Size(105, 38);
            this.button_FillCheckedData.TabIndex = 3;
            this.button_FillCheckedData.Text = "Fill in with values";
            this.button_FillCheckedData.UseVisualStyleBackColor = true;
            this.button_FillCheckedData.Click += new System.EventHandler(this.button_FillCheckedData_Click);
            // 
            // button_AddToColumns
            // 
            this.button_AddToColumns.Enabled = false;
            this.button_AddToColumns.Location = new System.Drawing.Point(361, 376);
            this.button_AddToColumns.Name = "button_AddToColumns";
            this.button_AddToColumns.Size = new System.Drawing.Size(75, 39);
            this.button_AddToColumns.TabIndex = 4;
            this.button_AddToColumns.Text = "Add Columns";
            this.button_AddToColumns.UseVisualStyleBackColor = true;
            this.button_AddToColumns.Click += new System.EventHandler(this.button_AddToColumns_Click);
            // 
            // button_AddToRows
            // 
            this.button_AddToRows.Location = new System.Drawing.Point(361, 421);
            this.button_AddToRows.Name = "button_AddToRows";
            this.button_AddToRows.Size = new System.Drawing.Size(75, 34);
            this.button_AddToRows.TabIndex = 5;
            this.button_AddToRows.Text = "Add Rows";
            this.button_AddToRows.UseVisualStyleBackColor = true;
            this.button_AddToRows.Click += new System.EventHandler(this.button_AddToRows_Click);
            // 
            // dataGridView_Matrix
            // 
            this.dataGridView_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Matrix.Location = new System.Drawing.Point(23, 308);
            this.dataGridView_Matrix.Name = "dataGridView_Matrix";
            this.dataGridView_Matrix.ReadOnly = true;
            this.dataGridView_Matrix.RowTemplate.Height = 25;
            this.dataGridView_Matrix.Size = new System.Drawing.Size(328, 240);
            this.dataGridView_Matrix.TabIndex = 6;
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(359, 461);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(76, 39);
            this.button_Calculate.TabIndex = 7;
            this.button_Calculate.Text = "Calculate matrix";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // button_GenerateResult
            // 
            this.button_GenerateResult.Location = new System.Drawing.Point(357, 506);
            this.button_GenerateResult.Name = "button_GenerateResult";
            this.button_GenerateResult.Size = new System.Drawing.Size(80, 43);
            this.button_GenerateResult.TabIndex = 8;
            this.button_GenerateResult.Text = "Generate result";
            this.button_GenerateResult.UseVisualStyleBackColor = true;
            this.button_GenerateResult.Click += new System.EventHandler(this.button_GenerateResult_Click);
            // 
            // dataGridView_NewData
            // 
            this.dataGridView_NewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NewData.Location = new System.Drawing.Point(501, 2);
            this.dataGridView_NewData.Name = "dataGridView_NewData";
            this.dataGridView_NewData.RowTemplate.Height = 25;
            this.dataGridView_NewData.Size = new System.Drawing.Size(246, 406);
            this.dataGridView_NewData.TabIndex = 9;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(AlgimedApp.Entities.Data);
            // 
            // button_ReadExc
            // 
            this.button_ReadExc.Location = new System.Drawing.Point(23, 246);
            this.button_ReadExc.Name = "button_ReadExc";
            this.button_ReadExc.Size = new System.Drawing.Size(100, 38);
            this.button_ReadExc.TabIndex = 1;
            this.button_ReadExc.Text = "Fill data from Excel";
            this.button_ReadExc.UseVisualStyleBackColor = true;
            this.button_ReadExc.Click += new System.EventHandler(this.button_ReadExc_Click);
            // 
            // checkedListBox_Data
            // 
            this.checkedListBox_Data.CheckOnClick = true;
            this.checkedListBox_Data.FormattingEnabled = true;
            this.checkedListBox_Data.Location = new System.Drawing.Point(1, 2);
            this.checkedListBox_Data.Name = "checkedListBox_Data";
            this.checkedListBox_Data.Size = new System.Drawing.Size(143, 238);
            this.checkedListBox_Data.TabIndex = 2;
            // 
            // button_AddToDb
            // 
            this.button_AddToDb.Location = new System.Drawing.Point(585, 414);
            this.button_AddToDb.Name = "button_AddToDb";
            this.button_AddToDb.Size = new System.Drawing.Size(123, 39);
            this.button_AddToDb.TabIndex = 10;
            this.button_AddToDb.Text = "Add Result To DB";
            this.button_AddToDb.UseVisualStyleBackColor = true;
            this.button_AddToDb.Click += new System.EventHandler(this.button_AddToDb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 566);
            this.Controls.Add(this.button_AddToDb);
            this.Controls.Add(this.checkedListBox_Data);
            this.Controls.Add(this.button_ReadExc);
            this.Controls.Add(this.dataGridView_NewData);
            this.Controls.Add(this.button_GenerateResult);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.dataGridView_Matrix);
            this.Controls.Add(this.button_AddToRows);
            this.Controls.Add(this.button_AddToColumns);
            this.Controls.Add(this.button_FillCheckedData);
            this.Controls.Add(this.dataGridView_Result);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_Result;
        private Button button_FillCheckedData;
        private Button button_AddToColumns;
        private Button button_AddToRows;
        private DataGridView dataGridView_Matrix;
        private Button button_Calculate;
        private Button button_GenerateResult;
        private DataGridView dataGridView_NewData;
        private BindingSource dataBindingSource;
        private Button button_ReadExc;
        private CheckedListBox checkedListBox_Data;
        private Button button_AddToDb;
    }
}