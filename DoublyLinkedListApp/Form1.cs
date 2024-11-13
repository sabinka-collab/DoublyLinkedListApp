using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublyLinkedListApp
{
    public partial class Form1 : Form
    {
        private DoublyLinkedList list;

        public Form1()
        {
            InitializeComponent();
            list = new DoublyLinkedList();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                list.AddToFront(value);
                txtInput.Clear();
                MessageBox.Show("Элемент добавлен!");
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                list.Delete(value);
                txtInput.Clear();
                MessageBox.Show("Элемент удален!");
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            List<int> items = list.ToList();
            foreach (int item in items)
            {
                listBox.Items.Add(item);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
