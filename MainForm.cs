using AlgimedApp.AppContext;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace AlgimedApp
{
    public partial class MainForm : Form
    {
        public Dictionary<string, double> data = new Dictionary<string, double>();
        public int rowCount = 1;
        public int columnCount = 1;
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void button_ReadExc_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ Excel";

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string xlFileName = ofd.FileName;
            Excel.Range Rng;
            Excel.Workbook xlWB;
            Excel.Worksheet xlSht;

            Excel.Application xlApp = new Excel.Application(); 
            xlWB = xlApp.Workbooks.Open(xlFileName);            
            xlSht = xlWB.Worksheets[1];


            for(int i = 1; i<= xlSht.UsedRange.Rows.Count; i++)
            {
                data.Add(xlSht.Cells[i, 1].Value.ToString(), double.Parse(xlSht.Cells[i, 6].Value.ToString()));
            }
            foreach(var item in data)
            {
                checkedListBox_Data.Items.Add(item.Key);
            }
        }

        private void button_FillCheckedData_Click(object sender, EventArgs e)
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
        }

        private void button_AddToColumns_Click(object sender, EventArgs e)
        {
            dataGridView_Matrix.ColumnCount = dataGridView_Result.SelectedRows.Count+1;
            for(int i = 1; i < dataGridView_Matrix.ColumnCount; i++)
            {
                dataGridView_Matrix.Rows[0].Cells[i].Value = dataGridView_Result.SelectedRows[dataGridView_Result.SelectedRows.Count-i].Cells[0].Value;
            }
        }

        private void button_AddToRows_Click(object sender, EventArgs e)
        {
            dataGridView_Matrix.RowCount = dataGridView_Result.SelectedRows.Count + 1;
            for(int i = 1; i < dataGridView_Matrix.RowCount; i++)
            {
                dataGridView_Matrix.Rows[i].Cells[0].Value = dataGridView_Result.SelectedRows[dataGridView_Result.SelectedRows.Count - i].Cells[0].Value;
            }
            button_AddToColumns.Enabled = true;
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < dataGridView_Matrix.ColumnCount; i++)
            {
                for(int j = 1; j < dataGridView_Matrix.RowCount; j++)
                {
                    
                    dataGridView_Matrix.Rows[i].Cells[j].Value = Math.Round(Math.Pow(2,
                        (data.Where(x => x.Key == dataGridView_Matrix.Rows[0].Cells[j].Value.ToString()).FirstOrDefault().Value 
                        - data.Where(x => x.Key == dataGridView_Matrix.Rows[i].Cells[0].Value.ToString()).FirstOrDefault().Value)),2);



                }
            }
        }

        private void button_GenerateResult_Click(object sender, EventArgs e)
        {
            string result = "";
            
            using (UsersContext db = new UsersContext())
            {
                for (int i = 1; i < dataGridView_Matrix.ColumnCount; i++)
                {
                    for (int j = 1; j < dataGridView_Matrix.RowCount; j++)
                    {
                        result += $"{dataGridView_Matrix.Rows[0].Cells[j].Value}_{dataGridView_Matrix.Rows[i].Cells[0].Value}  {dataGridView_Matrix.Rows[i].Cells[j].Value}\r\n";
                        db.Datas.Add(new Entities.Data { Cells = $"{dataGridView_Matrix.Rows[0].Cells[j].Value}_{dataGridView_Matrix.Rows[i].Cells[0].Value}", Value = dataGridView_Matrix.Rows[i].Cells[j].Value.ToString()});
                    }
                }
                db.SaveChanges();
            }
            MessageBox.Show(result);
            
        }
    }
}