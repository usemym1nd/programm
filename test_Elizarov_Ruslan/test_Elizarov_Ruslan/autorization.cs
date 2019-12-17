using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Elizarov_Ruslan
{
    public partial class autorization : Form
    {
        public autorization()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            registration reg = new registration();
            reg.Show();
        }

        private void autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void XZ()
        {
            string login = "user";
            string pass = "qwerty";

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните пустые поля!","Ну плез");
            }
            else
            {
                if (textBox1.Text == login && textBox2.Text == pass)
                {
                    MessageBox.Show("Вы успешно вошли!","ХЗ куда но вошли");
                }
                else
                {
                    MessageBox.Show("Не корректные данные!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XZ();
        }
    }
}
