using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace classProject
{
    public partial class printCourseForm : Form
    {
        public printCourseForm()
        {
            InitializeComponent();
        }


        private void CreateDocument()
        {
            try
            {

                //Save location 
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = ".docx";
                saveFileDialog1.Filter = "Word|*.docx";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.InitialDirectory = @"C:\Desktop";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    object filename = saveFileDialog1.FileName;
                    //Create an instance for word  
                    Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                    //Set animation status for word application  
                    winword.ShowAnimation = false;

                    //Set status for word application is to be visible or not.  
                    winword.Visible = false;

                    //Create a missing variable for missing value  
                    object missing = System.Reflection.Missing.Value;

                    //Create a new document  
                    Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                    //Add paragraph with Heading 1 style  
                    Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);

                    //Create a table  
                    int rows = printC_dgv.Rows.Count + 1;
                    int columns = printC_dgv.Columns.Count;

                    Table T = document.Tables.Add(para1.Range, rows, columns, ref missing, ref missing);

                    T.Borders.Enable = 1;

                    //Insert
                    for (int i = 1; i < T.Rows.Count-1; i++)
                    {
                        for (int j = 1; j < T.Columns.Count + 1; j++)
                        {
                            //Header 
                            T.Rows[1].Cells[j].Range.Text = printC_dgv.Columns[j - 1].HeaderText.ToString();
                            T.Rows[1].Cells[j].Range.Font.Bold = 1;
                            T.Rows[1].Cells[j].Range.Font.Name = "verdana";
                            T.Rows[1].Cells[j].Range.Font.Size = 10;
                            T.Rows[1].Cells[j].Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            T.Rows[1].Cells[j].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            T.Rows[1].Cells[j].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            T.Rows[i+1].Cells[j].Range.Text = printC_dgv.Rows[i-1].Cells[j-1].Value.ToString();

                        }
                    }
                    foreach (Microsoft.Office.Interop.Word.Section section in T.Application.ActiveDocument.Sections)
                    {
                        Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        headerRange.Text = "List Courses of HCMC UTE";
                        headerRange.Font.Size = 24;
                        headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                   
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;
                    MessageBox.Show("Document created successfully !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printCourseForm_Load(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            printC_dgv.DataSource = course.getAllCourse();
            printC_dgv.Columns[0].Width = 20;
            printC_dgv.Columns[1].Width = 100;
            printC_dgv.Columns[2].Width = 100;
            printC_dgv.Columns[3].Width = 150;
        }

        private void saveToTxt_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }
    }
}







