using AlgimedApp.AppContext;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace AlgimedApp
{
    public partial class MainForm : Form
    {
        public Dictionary<string, double> data = new Dictionary<string, double>();
        public Dictionary<string, double> newData = new Dictionary<string, double>();
        public int rowCount = 1;
        public int columnCount = 1;
        
        public MainForm()
        {
            InitializeComponent();
            button_FillCheckedData.Enabled = false;
            button_AddToColumns.Enabled = false;
            button_AddToRows.Enabled = false;
            button_Calculate.Enabled = false;
            button_GenerateResult.Enabled = false;
            button_AddToDb.Enabled = false;
        }

        private void button_ReadExc_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ Excel";

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("You don't choose file", "Loading data...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string xlFileName = ofd.FileName;
                Excel.Range Rng;
                Excel.Workbook xlWB;
                Excel.Worksheet xlSht;

                Excel.Application xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Open(xlFileName);
                xlSht = xlWB.Worksheets[1];


                for (int i = 1; i <= xlSht.UsedRange.Rows.Count; i++)
                {
                    data.Add(xlSht.Cells[i, 1].Value.ToString(), double.Parse(xlSht.Cells[i, 6].Value.ToString()));
                }
                foreach (var item in data)
                {
                    checkedListBox_Data.Items.Add(item.Key);
                }
                button_FillCheckedData.Enabled = true;

            }

        }

        private void button_FillCheckedData_Click(object sender, EventArgs e)
        {
            if(checkedListBox_Data.CheckedItems.Count == 0)
            {
                MessageBox.Show("Choose rows");
            }
            else
            {
                int startIndex = 0;
                dataGridView_Result.RowCount = checkedListBox_Data.CheckedItems.Count;
                dataGridView_Result.ColumnCount = 2;
                foreach (var item in checkedListBox_Data.CheckedItems)
                {
                    dataGridView_Result.Rows[startIndex].Cells[0].Value = data.Where(x => x.Key == item).FirstOrDefault().Key.ToString();
                    dataGridView_Result.Rows[startIndex].Cells[1].Value = data.Where(x => x.Key == item).FirstOrDefault().Value;
                    startIndex++;
                }
                button_AddToRows.Enabled = true;
            }
        }

        private void button_AddToColumns_Click(object sender, EventArgs e)
        {
            if(dataGridView_Result.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose rows to generate matrix");
            }
            else
            {
                dataGridView_Matrix.ColumnCount = dataGridView_Result.SelectedRows.Count + 1;
                for (int i = 1; i < dataGridView_Matrix.ColumnCount; i++)
                {
                    dataGridView_Matrix.Rows[0].Cells[i].Value = dataGridView_Result.SelectedRows[dataGridView_Result.SelectedRows.Count - i].Cells[0].Value;
                }
                button_AddToRows.Enabled = true;
                button_Calculate.Enabled = true;
                button_AddToColumns.Enabled = false;
            }
        }

        private void button_AddToRows_Click(object sender, EventArgs e)
        {
            if (dataGridView_Result.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose rows to generate matrix");
            }
            else
            {
                dataGridView_Matrix.Rows.Clear();
                dataGridView_Matrix.RowCount = dataGridView_Result.SelectedRows.Count + 1;
                for (int i = 1; i < dataGridView_Matrix.RowCount; i++)
                {
                    dataGridView_Matrix.Rows[i].Cells[0].Value = dataGridView_Result.SelectedRows[dataGridView_Result.SelectedRows.Count - i].Cells[0].Value;
                }
                button_AddToColumns.Enabled = true;
                button_AddToRows.Enabled = false;
            }
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < dataGridView_Matrix.RowCount; i++)
            {
                for(int j = 1; j < dataGridView_Matrix.ColumnCount; j++)
                {
                    
                    dataGridView_Matrix.Rows[i].Cells[j].Value = Math.Round(Math.Pow(2,
                        (data.Where(x => x.Key == dataGridView_Matrix.Rows[0].Cells[j].Value.ToString()).FirstOrDefault().Value 
                        - data.Where(x => x.Key == dataGridView_Matrix.Rows[i].Cells[0].Value.ToString()).FirstOrDefault().Value)),2);
                }
            }
            button_GenerateResult.Enabled = true;
        }

        private void button_GenerateResult_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < dataGridView_Matrix.RowCount; i++)
            {
                for (int j = 1; j < dataGridView_Matrix.ColumnCount; j++)
                {
                    newData.Add($"{dataGridView_Matrix.Rows[0].Cells[j].Value}_{dataGridView_Matrix.Rows[i].Cells[0].Value}",
                        double.Parse(dataGridView_Matrix.Rows[i].Cells[j].Value.ToString()));
                }
            }
            dataGridView_NewData.RowCount = newData.Count+1;
            dataGridView_NewData.ColumnCount = 2;

            dataGridView_NewData.Rows[0].Cells[0].Value = "Cells";
            dataGridView_NewData.Rows[0].Cells[1].Value = "Value";

            int startIndexRows = 1;

            foreach (var item in newData)
            {
                dataGridView_NewData.Rows[startIndexRows].Cells[0].Value = item.Key;
                dataGridView_NewData.Rows[startIndexRows].Cells[1].Value = item.Value;
                startIndexRows++;
            }
            button_AddToDb.Enabled = true;
        }

        private void button_AddToDb_Click(object sender, EventArgs e)
        {
            DbAccess dbAccess = new DbAccess();
            dbAccess.ShowDialog();
            bool access = dbAccess.Access;
            if (access)
            {
                using (UsersContext db = new UsersContext())
                {
                    for (int i = 1; i < dataGridView_Matrix.RowCount; i++)
                    {
                        for (int j = 1; j < dataGridView_Matrix.ColumnCount; j++)
                        {
                            db.Datas.Add(new Entities.Data
                            {
                                Cells = $"{dataGridView_Matrix.Rows[0].Cells[j].Value}_" +
                                $"{dataGridView_Matrix.Rows[i].Cells[0].Value}",
                                Value = dataGridView_Matrix.Rows[i].Cells[j].Value.ToString()
                            });
                        }
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Data added to DB");
            }
            else
            {
                MessageBox.Show("Wrong password to DB", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}