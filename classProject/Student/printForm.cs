using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection.Metadata;
using Microsoft.Office.Interop.Word;
using System.Drawing.Imaging;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace classProject
{
    public partial class printForm : Form
    {
        public printForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student11DataSet2.student11' table. You can move, or remove it, as needed.
            this.student11TableAdapter.Fill(this.student11DataSet2.student11);

        }
        DB mydb = new DB();
        public void loadStudentList()
        {
            mydb.openConnectionState();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from student11 ", mydb.GetConnection);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            listPrint.DataSource = table;
            listPrint.RowTemplate.Height = 80;
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            listPrint.AutoGenerateColumns = false;
            mydb.closeConnection();
        }
        private void refesh_Click(object sender, EventArgs e)
        {
            loadStudentList();
        }

 
        private void isDateRange_CheckedChanged(object sender, EventArgs e)
        {
            if (isDateRange.Checked)
            {

                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;

            }
            if (isDateRange.Checked ==false)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\student_list.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                DateTime bdate;
                for (int i = 0; i < listPrint.Rows.Count-1; i++)
                {
                    writer.Write("\n");
                    for (int j = 0; j < listPrint.Columns.Count; j++)
                    {
                        if (j == 2)
                        {
                            bdate = Convert.ToDateTime(listPrint.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t"+"|");
                        }
                        else if (j == listPrint.Columns.Count - 2)
                        {
                            writer.Write("\t" + listPrint.Rows[i].Cells[j].Value.ToString() + "");
                        }


                        if (j == 2)
                        {
                            bdate = Convert.ToDateTime(listPrint.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                        }
                        
                        else
                        {
                            writer.Write("\t" + listPrint.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                }
                writer.Close();
                MessageBox.Show("done!");
            }
        }

        private void check_Button_Click(object sender, EventArgs e)
        {

            mydb.openConnectionState();
            SqlDataAdapter adapter = new SqlDataAdapter();

            if (isDateRange.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (Male.Checked)
                {
                    adapter = new SqlDataAdapter("Select * from student11 where gender ='Male      ' and dob  BETWEEN'" + date1 + "' AND'" + date2 + "'", mydb.GetConnection);
                }
                if (female.Checked)
                {
                    adapter = new SqlDataAdapter("Select * from student11 where gender ='Female    'and dob  BETWEEN'" + date1 + "' AND'" + date2 + "'", mydb.GetConnection);
                }
                if (all.Checked)
                {
                    adapter = new SqlDataAdapter("Select * from student11 where  dob  BETWEEN'" + date1 + "' AND'" + date2 + "'", mydb.GetConnection);
                }
            }
            else if (isDateRange.Checked != true)
            {
                if (Male.Checked)
                {
                    adapter = new SqlDataAdapter("Select * from student11 where gender ='Male      '", mydb.GetConnection);
                }
                if (female.Checked)
                {
                    adapter = new SqlDataAdapter("Select * from student11 where gender ='Female    '", mydb.GetConnection);
                }
                if (all.Checked)
                {
                    adapter = new SqlDataAdapter("Select * from student11", mydb.GetConnection);
                }
            }
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            listPrint.DataSource = table;
            listPrint.RowTemplate.Height = 80;
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            listPrint.AutoGenerateColumns = false;
            mydb.closeConnection();
        }


        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int count = 1;
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        if (c == 0)
                        {
                            DataArray[r, c] = count.ToString();
                            count++;
                        }
                        else
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;
                //page orintation
                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }
                //table format
                oRange.Text = oTemp;

                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    if (c == 0)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = "No.";
                    }
                    else
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Student List";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //save image
                for (r = 0; r <= RowCount - 2; r++)
                {

                    byte[] imgbyte = (byte[])listPrint.Rows[r].Cells[6].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(System.Drawing.Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 7).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 7).Range.InsertParagraph();
                }
                //save the file
                oDoc.SaveAs(filename);

            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
        private void saveToMSW_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(listPrint, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveToPDF_Click(object sender, EventArgs e)
        {
            if (listPrint.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf"; bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(listPrint.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in listPrint.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in listPrint.Rows)
                            {
                                string id = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(id);
                                string Fullname = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(Fullname);
                                string Bdate = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(Bdate);
                                string gender = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(gender);
                                string phone = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(phone);
                                string address = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(address);
                                byte[] imageByte = (byte[])row.Cells[6].Value;
                                iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                pdfTable.AddCell(Image);
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream); pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
 

