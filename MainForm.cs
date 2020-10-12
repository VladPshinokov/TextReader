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
        private static string fileName;
        private static string textSrc;
        private static string strTempTransmit;
        private static int indexSubStr = 0;
        private static int subStrLength = 0;
        private static Single FontSize = 9F;
        
        public MainForm()
        {
            InitializeComponent();


        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog1 = new OpenFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt",
            };

            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog1.FileName;

                try
                {
                    textSrc = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                buttonPlus.Enabled = true;
                buttonMinus.Enabled = true;
                buttonFind.Enabled = true;
                buttonNextFindWord.Enabled = true;
                buttonPrevFindWord.Enabled = true;

                CloseToolStripMenuItem.Enabled = true;

                UndoToolStripMenuItem.Enabled = true;
                CutToolStripMenuItem.Enabled = true;
                CopyToolStripMenuItem1.Enabled = true;
                InsertToolStripMenuItem.Enabled = true;
                SelectAllToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;

                CutRightClickToolStripMenuItem.Enabled = true;
                CopyRightClickToolStripMenuItem.Enabled = true;
                InsertRightClickToolStripMenuItem.Enabled = true;
                SelectAllRightClickToolStripMenuItem.Enabled = true;
                DeleteRightClickToolStripMenuItem.Enabled = true;

                richTextBox1.Text = textSrc;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textSrc != null)
            {
                richTextBox1.Font = new System.Drawing.Font("Times New Roman", ++FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                richTextBox1.Update();
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textSrc != null)
            {
                richTextBox1.Font = new System.Drawing.Font("Times New Roman", --FontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                richTextBox1.Update();
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (textSrc != null && richTextBox1.Text != null)
            {
                richTextBox1.SelectionBackColor = Color.Transparent;
                richTextBox1.DeselectAll();

                FindTextForm form = new FindTextForm();
                form.ShowDialog();

                strTempTransmit = richTextBox1.Text; // !! присваиваем текст из формы обратно в static переменную, на случай изменения текста внутри формы, чтобы работать с правильными индексами

                FindTextForm.FindText(in strTempTransmit, ref indexSubStr, ref subStrLength);
                if (indexSubStr == (-1))
                    MessageBox.Show("Введенное слово не найдено!\nДля повторного поиска нажмите соответствующий значок");
                else
                {
                    richTextBox1.Select(indexSubStr, subStrLength);  // Если слово не найдено, то сохраняем текущее выделение (блок if)
                    richTextBox1.SelectionBackColor = Color.Aqua;
                }
            }
        }

        private void buttonNextFindWord_Click(object sender, EventArgs e)
        {
            if (textSrc != null && richTextBox1.Text != null)
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
        }

        private void buttonPrevFindWord_Click(object sender, EventArgs e)
        {
            if (textSrc != null && richTextBox1.Text != null)
            {
                richTextBox1.SelectionBackColor = Color.Transparent;
                richTextBox1.DeselectAll();
                richTextBox1.Select(FindTextForm.FindPrevWord(ref indexSubStr), subStrLength);
                richTextBox1.SelectionBackColor = Color.Aqua;
            }
        }

       

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                try
                {
                    File.WriteAllText(fileName, richTextBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                saveFileDialog1 = new SaveFileDialog()
                {
                    Filter = "Text files (*.txt)|*.txt",
                };
                
                int indexTemp = 0;
                int indexSrc = 0;

                // Задача - из имени полного файлового пути выделить только имя файла (с расширением) и передать его 
                // в поле "имя файла" в форме сохранения окна

                for (indexSrc = (fileName.Length - 1); !fileName[indexSrc].Equals('\\'); )
                {
                    indexSrc--; // определяем индекс, начиная с которого будем сохранять символы для имени файла 
                }
                
                string tempStr = null;
                char[] arrCharTemp = new char[fileName.Length - 1 - indexSrc]; // создаем массив длиной с число символов имени файла

                for (; indexSrc < (fileName.Length - 1); indexSrc++)
                {
                    arrCharTemp[indexTemp++] = fileName[indexSrc + 1]; // формируем строку с именем файла
                }

                tempStr = new string(arrCharTemp);
                saveFileDialog1.FileName = tempStr; // присваиваем выделенного имя файла в поле "имя файла" в форме

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.ResetText();// файл уже был закрыт при выполнении функции ReadAllText(), поэтому просто очищаем поле 

        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strAbout = "Программа Text Reader предназначена для открытия и редактирования\nтекстовых файлов. Версия программы - v1.";
            MessageBox.Show(strAbout, "О программе", MessageBoxButtons.OK);
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null && richTextBox1.SelectedText.Length > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectedText.Length);
                richTextBox1.Update();
            }
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null && richTextBox1.SelectedText.Length > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true) // проверка, есть ли текст в буфере обмена
                richTextBox1.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null && richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectedText.Length);
                richTextBox1.Update();
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }
        private void CutRightClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null && richTextBox1.SelectedText.Length > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectedText.Length);
                richTextBox1.Update();
            }
        }

        private void CopyRightClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null && richTextBox1.SelectedText.Length > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void InsertRightClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true) // проверка, есть ли текст в буфере обмена
                richTextBox1.Paste();
        }

        private void SelectAllRightClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void DeleteRightClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null && richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectedText.Length);
                richTextBox1.Update();
            }
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (richTextBox1.Text != string.Empty) // проверка, есть ли в текстовом поле открытый файл
            {
                if (richTextBox1.Text.Equals(textSrc)) // проверка, менялся ли загруженный в форму файл
                {

                    DialogResult tempResult = MessageBox.Show("Вы хотите сохранить файл перед закрытием?", "Предупреждение", MessageBoxButtons.YesNoCancel);

                    if (tempResult == DialogResult.Yes)
                    {
                        e.Cancel = true;
                        SaveAsToolStripMenuItem_Click(sender, e); // вызываем функцию для отработки сохранения файла
                    }
                    else if (tempResult == DialogResult.Cancel)
                    {
                        e.Cancel = true; // если нажата кнопка "отмена", устанавливаем отмену для event вызова в true, окно закрывается, возврат в форму  
                    }
                    else
                    {
                        // если нажата кнопка "нет", позволяем отработать обработчику закрытия формы
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Equals(textSrc)) // проверка, менялся ли текст в текстовом поле
            {
                SaveToolStripMenuItem.Enabled = true;
                SaveAsToolStripMenuItem.Enabled = true;
            }
        }
    }
}
