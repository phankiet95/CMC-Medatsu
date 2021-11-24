using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMC_Medatsu
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        CMCExcelHelper helper;
        private XLWorkbook workbook;
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void excelFileProcess(String path)
        {
            helper = new CMCExcelHelper(path);
            cboWorkSheet.DataSource = helper.getListWorkSheetName();
            cboWorkSheet.Show();
        }


        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse Excel Files";
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                try
                {
                    lblFile.Text = Path.GetFileName(openFileDialog.FileName);
                    excelFileProcess(openFileDialog.FileName);
                    workPanel.Enabled = true;
                } catch (Exception)
                {
                    MessageBox.Show("Please re-check or close file before processing", "Read file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnGoIndexing_Click(object sender, EventArgs e)
        {
            int start;
            int numberDigit;
            try
            {
                start = int.Parse(txtStartIndex.Text);
                numberDigit = int.Parse(txtNumberDigit.Text);
                if (start < 0 || numberDigit < 1)
                {
                    throw new Exception();
                }
            } catch
            {
                MessageBox.Show("Please re-check Start index or numberDigit", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workbook = helper.startIndexing(start, txtFunctionName.Text, numberDigit, txtDate.Text, txtPIC.Text);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Dispose();
                MessageBox.Show("File Saved: "+saveFileDialog.FileName, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                workPanel.Enabled = false;
            } else
            {
                workbook.Dispose();
                workPanel.Enabled = false;
            }

        }

        private void formIcon_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            if (txtDate.Text == "")
            {
                txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            }
        }
    }
}
