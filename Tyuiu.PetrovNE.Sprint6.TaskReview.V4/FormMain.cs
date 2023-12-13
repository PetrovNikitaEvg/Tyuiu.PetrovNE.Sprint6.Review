using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PetrovNE.Sprint6.TaskReview.V4.Lib;

namespace Tyuiu.PetrovNE.Sprint6.TaskReview.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public int row = 0;
        public int col = 0;
        public int r1 = 0, r2 = 0;
        public int[,] MyArray;
        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxFirstNumFormProgramm_PNE.Enabled = false;
            textBoxSecondNumFormProgramm_PNE.Enabled = false;
            textBoxRowAmount_PNE.Enabled = false;
            buttonDone_PNE.Enabled = false;
        }

        private void labelTask_PNE_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateArray_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int row = Convert.ToInt32(textBoxRows_PNE.Text), col = Convert.ToInt32(textBoxColumns_PNE.Text);
                int r1 = Convert.ToInt32(textBoxFirstNumForRandom_PNE.Text), r2 = Convert.ToInt32(textBoxSecondNumForRandom_PNE.Text);
                int[,] array = new int[row, col];

                MyArray = ds.GetMatrix(row, col, r1, r2);

                dataGridViewArray_PNE.RowCount = row;
                dataGridViewArray_PNE.ColumnCount = col;

                for (int i = 0; i < col; i++)
                {
                    dataGridViewArray_PNE.Columns[i].Width = 100;
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        dataGridViewArray_PNE.Rows[i].Cells[j].Value = Convert.ToString(MyArray[i, j]);
                    }
                }
                textBoxFirstNumFormProgramm_PNE.Enabled = true;
                textBoxSecondNumFormProgramm_PNE.Enabled = true;
                textBoxRowAmount_PNE.Enabled = true;
                buttonDone_PNE.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_PNE_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int First = Convert.ToInt32(textBoxFirstNumFormProgramm_PNE.Text);
                int Second = Convert.ToInt32(textBoxSecondNumFormProgramm_PNE.Text);
                int MyC = Convert.ToInt32(textBoxRowAmount_PNE.Text);

                int MyAnswer = ds.Result(MyArray, MyC, First, Second);

                textBoxResult_PNE.Text = Convert.ToString(MyAnswer);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxSecondNumFormProgramm_PNE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_PNE_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_PNE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Петров Никита Евгеньевич\nГруппа АСОиУБ-23-1\nСпринт6Ревью Вариант6", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxRowAmount_PNE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
