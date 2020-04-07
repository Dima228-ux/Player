using Player.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player.Viev
{
    public partial class FormEnterPlayListName : Form
    {
        private ControllerFromEnterPlayListName controller;
        public string Title;

        public FormEnterPlayListName()
        {
            InitializeComponent();
            
        }

        private void FormEnterPlayListName_Load(object sender, EventArgs e)
        {
          
            controller = new ControllerFromEnterPlayListName(this);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() !=string.Empty)
               Title = textBox1.Text;
            else 
                MessageBox.Show("Введите имя!!!!!");

            this.Close();
        }
    }
}
