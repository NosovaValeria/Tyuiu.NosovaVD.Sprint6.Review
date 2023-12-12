using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosovaVD.Sprint6.TaskReview.V8.Lib;
namespace Tyuiu.NosovaVD.Sprint6.TaskReview.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] arrayValues;
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOut_NVD.ColumnCount = 50;
            dataGridViewOut_NVD.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewOut_NVD.Columns[i].Width = 25;
            }
        }

        private void buttonDone_NVD_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(textBoxVarC_NVD.Text);
                int k = Convert.ToInt32(textBoxVarK_NVD.Text);
                int l = Convert.ToInt32(textBoxVarL_NVD.Text);
                if (k <= l)
                {
                    textBoxResultat_NVD.Text = ds.resultGetMatrix(arrayValues, c, k, l).ToString();
                }
                else
                {
                    MessageBox.Show("Данные введены не корректно");
                }
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно");
            }
        }

        private void buttonGen_NVD_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxVarN_NVD.Text);
                int m = Convert.ToInt32(textBoxVarM_NVD.Text);
                int n1 = Convert.ToInt32(textBoxVarN1_NVD.Text);
                int n2 = Convert.ToInt32(textBoxVarN2_NVD.Text);
                if (n1 < n2)
                {
                    arrayValues = ds.GetMatrix(n, m, n1, n2);
                    dataGridViewOut_NVD.ColumnCount = m;
                    dataGridViewOut_NVD.RowCount = n;

                    for (int i = 0; i < m; i++)
                    {
                        dataGridViewOut_NVD.Columns[i].Width = 25;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            dataGridViewOut_NVD.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    buttonDone_NVD.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Данные введены не корректно");
                }
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно");
            }
        }
    }
}
