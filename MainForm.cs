using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using TextReader;
using System.Globalization;


namespace TextReader
{
    public partial class MainForm : Form
    {
        // Независимые от экземпляров класса (static) переменные для работы функций
        
        private OpenFileDialog dialog1;
        private string fileName;
        private static string textSrc;
        private static int indexSubStr = 0;
        private static int subStrLength = 0;
        private static Single FontSize = 9F;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialog1 = new OpenFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt",
            };
            
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog1.FileName;

                textSrc = File.ReadAllText(fileName, Encoding.GetEncoding(1251));

                richTextBox1.Text = textSrc;
            }


        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new System.Drawing.Font("Times New Roman", ++FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            richTextBox1.Update();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new System.Drawing.Font("Times New Roman", --FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            richTextBox1.Update();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Transparent;
            richTextBox1.DeselectAll();

            FindTextForm form = new FindTextForm();
            form.ShowDialog();

            FindTextForm.FindText(in textSrc, ref indexSubStr, ref subStrLength);
            if (indexSubStr == (-1))
                MessageBox.Show("Введенное слово не найдено!\nДля повторного поиска нажмите соответствующий значок");
            else
            {
                richTextBox1.Select(indexSubStr, subStrLength);  // Если слово не найдено, то сохраняем текущее выделение (блок if)
                richTextBox1.SelectionBackColor = Color.Aqua;             
            }
            
        }

        private void buttonNextFindWord_Click(object sender, EventArgs e)
        {
            FindTextForm.FindNextWord(in textSrc, ref indexSubStr);
            if (indexSubStr == (-1))
                MessageBox.Show("Нет подходящих слов в тексте\n");
            else
            {
                richTextBox1.SelectionBackColor = Color.Transparent;
                richTextBox1.DeselectAll();
                richTextBox1.Select(indexSubStr, subStrLength);
                richTextBox1.SelectionBackColor = Color.Aqua;
            }
        }

        private void buttonPrevFindWord_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Transparent;
            richTextBox1.DeselectAll();
            richTextBox1.Select(FindTextForm.FindPrevWord(ref indexSubStr), subStrLength);
            richTextBox1.SelectionBackColor = Color.Aqua;
        }
    }
}
