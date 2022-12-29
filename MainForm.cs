using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace AlgimedApp
{
    public partial class MainForm : Form
    {
        public Dictionary<string, double> data = new Dictionary<string, double>();
        
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
            for(int i = dataGridView_Result.SelectedRows.Count-1; i >= 0; i--)
            {
                MessageBox.Show(dataGridView_Result.SelectedRows[i].Cells[0].Value.ToString());
            }
        }
    }
}