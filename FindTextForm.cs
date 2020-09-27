using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReader
{
    public partial class FindTextForm : Form
    {
        private static string inputText;
        private static int numEnter = 0;
        private static int[] arrIndexStr = new int[50];
        private static int numWords = 0;
        
        public FindTextForm()
        {
            InitializeComponent();
        }


        private void buttonFind2Form_Click(object sender, EventArgs e)
        {
            // Запись введеного для поиска слова в статическую переменную
            
            inputText = FindTextBox.Text;
            this.Close();
        }

        public static void FindText(in string srcString, ref int indexSubStr, ref int subStrLength)
        {
            // Обнуление статических счетчиков при поиске нового слова
            
            numEnter = 0;
            numWords = 0;
            
            if((indexSubStr = srcString.IndexOf(inputText)) != (-1))
            {
                for (int i = 0; i < indexSubStr; i++)
                    if (srcString[i].Equals('\n'))
                        numEnter++;

                indexSubStr -= numEnter; // сдвиг индекса начала найденного слова на число знаков переноса строк
               
                arrIndexStr[numWords] = indexSubStr;  // запись итогового индекса в массив для последющего использования в FindPrevWord(),
                                                      // т.е. можно перемещаться между выделениями в тексте по индескам в массиве
                subStrLength = inputText.Length;
            }
        }

        public static void FindNextWord(in string srcString, ref int indexSubStr)
        {
            // Проверка на наличие слова в тексте, если функция поиска FindText() не нашла слово, то indexSubStr == (-1), соответственно
            // нажатие на кнопку поиска следующего слова (которое приводит в эту функцию) не должно приводить ни к каким действиям, что и реализовано в данном блоке
            
            if (indexSubStr != (-1))
            {
                int tempIndex = 0;

                tempIndex = indexSubStr; // запоминаем текущее значение индекса, ищем новое, поиск переносов \n выполняем в интервале между ними

                indexSubStr = srcString.IndexOf(inputText, (indexSubStr + inputText.Length));

                if (indexSubStr != (-1)) // если больше слов в тексте нет, то возвращаемся в главную форму, переданная по ссылке indexSubStr установлена в (-1)
                {
                    for (int i = tempIndex; i < indexSubStr; i++)
                        if (srcString[i].Equals('\n'))
                            numEnter++;

                    indexSubStr -= numEnter;

                    arrIndexStr[++numWords] = indexSubStr;
                }
            }
        }

        public static int FindPrevWord(ref int indexSubStr)
        {
            // Двигаем переданный по ссылке индекс назад, чтобы при следующем вызове функции FindNext(), поиск слова (и выделение в тексте) происходил именно с этой позиции,
            // а не с оставленной при последнем вызове FindNext()

            if (numWords != 0) // если индекс указаывает на крайнее слево слово, не двигаем его, чтобы не выйти за границы массива 
            {
                indexSubStr = arrIndexStr[--numWords];
            }
            return arrIndexStr[numWords];
        }
    }
}
