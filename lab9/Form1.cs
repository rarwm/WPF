using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + comboBox1.Text);

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                // Если Enter нажат, то вызываем событие нажатия на кнопку "Перейти"
                button4_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button5.Visible = false;
            textBox2.Text = comboBox1.Text;
            // Очищаем список от содержимого
            listBox1.Items.Clear();
            // Создаём переменную reader для чтения из файла browser.ini
            using (StreamReader reader = new StreamReader("C:\\browser.ini"))
            {
                // Считываем первую строку чтобы получить число строк в списке
                string z = reader.ReadLine();
                //В цикле считываем остальные строки из файла
                for (int j = 0; j < Convert.ToDouble(z); j++)
                    listBox1.Items.Add(reader.ReadLine());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + "|" + textBox2.Text);
            // Создаём переменную sw для записи данных в поток (файл)
            using (StreamWriter sw = new StreamWriter("C:\\browser.ini"))
            {
                // Первой строкой записываем в файл число строк в нашем списке
                sw.WriteLine(listBox1.Items.Count.ToString());
                // В цикле записываем все строки в файл.
                // Count - число строк в списке
                for (int j = 0; j < listBox1.Items.Count; j++)
                    sw.WriteLine(listBox1.Items[j]);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            string newts = "";
            int flag = 0; //flag определяет разделитель |
            char c;
            int k = str.Length;
            for (int j = 0; j < k; j++)
            {
                c = str[j];
                if (flag != 0) newts += c;
                if (c == '|') flag = 1;
            }
            //Подставляем в адресную строку адрес сайта
            comboBox1.Text = newts;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                // Если нет, то выводим сообщение.
                MessageBox.Show("Нет выделенной строки");
            else
                // Иначе .. Удаляем выделенную строку
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //Сохраняем новый список в файле
            using (StreamWriter sw = new StreamWriter("C:\\вап\browser.txt"))
            {
                sw.WriteLine(listBox1.Items.Count.ToString());
                for (int j = 0; j < listBox1.Items.Count; j++)
                    sw.WriteLine(listBox1.Items[j]);
            }
        }
    }
}

