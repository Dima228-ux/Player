using Plaer.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plaer.Viev
{
    public partial class FormDeletePlayList : Form
    {
        private ControllerFormDeletePlayList controller;
            
        public FormDeletePlayList()
        {
            InitializeComponent();
        }

        private void FormDeletePlayList_Load(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
                controller.Name = textBox1.Text;
            else MessageBox.Show("Введите имя!!!!!");

        }
    }
}
