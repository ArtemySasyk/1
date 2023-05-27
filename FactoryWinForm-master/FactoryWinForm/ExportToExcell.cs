using Excel = Microsoft.Office.Interop.Excel;

namespace FactoryWinForm
{
    class ExportToExcell
    {
        public ExportToExcell(System.Data.DataTable dataTable)
        {
            string filename = DateTime.Now.ToString();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                {
                    ofd.ShowDialog();
                    filename = ofd.FileName;
                    Excel.Application excelObject = new Excel.Application();
                    excelObject.Visible = true;
                    Excel.Workbook wb = excelObject.Workbooks.
                        Open(filename);
                    wb.Worksheets.Add(dataTable, "Материальный отчёт");
                    wb.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
