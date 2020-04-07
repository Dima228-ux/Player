using Plaer.Controller;
using Player.Controller;
using Player.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class FormMain : Form
    {
        private ControllerFromMain controller;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new ControllerFromMain(this);
            treeView1.Nodes.Add("Список музыки");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = controller.OpenFormEnterPlayListName();
            if (title != string.Empty && title != null && treeView1.SelectedNode == treeView1.Nodes[0])
            {
                controller.AddTrackList(title);

            }
            else
            {
                MessageBox.Show("НЕЛЬЗЯ СЮДА ДОБАВИТЬ!!!!!!");
            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            controller.Position = ((TrackBar)sender).Value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            controller.Save();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (!controller.IsPlay)
                controller.Play(treeView1.SelectedNode.Index);
            else
                controller.Pause();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            controller.Stop();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Index == -1)
                return;

            controller.DeleteTrackList(treeView1.SelectedNode.Name);

            if (treeView1.SelectedNode != treeView1.Nodes[0])
            {
                treeView1.SelectedNode.Remove();
                treeView1.Update();
            }
            else
            {
                MessageBox.Show("НЕЛЬЗЯ ЭТО УДОЛИТЬ");
            }
        }

        private void удалитьТрекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (treeView1.SelectedNode.Index == -1 || treeView1.SelectedNode == treeView1.Nodes[0])
            {
                MessageBox.Show("НЕЛЬЗЯ ЭТО УДАЛЯТЬ");
                return;
            }

            check = controller.DeleteTrack(treeView1.SelectedNode.Index, treeView1.SelectedNode.Parent.Index, treeView1.SelectedNode.Parent.Text);
            if (check)
                MessageBox.Show("НЕЛЬЗЯ ЭТО УДАЛЯТЬ");
        }

        private void добавитьТрекToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode != treeView1.Nodes[0])
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    Track track = controller.AddTrack(openFileDialog.FileName, treeView1.SelectedNode.Index);
                    controller.AddTrackOnTreeView(track);
                    treeView1.Update();
                }

            }
            else
            {
                MessageBox.Show("НЕЛЬЗЯ СЮДА ДОБАВИТЬ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexTrack = controller.PreviousTrack(treeView1.SelectedNode.Parent.Index, treeView1.SelectedNode.Index);
            controller.Play(indexTrack);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indexTrack = controller.NextTrack(treeView1.SelectedNode.Parent.Index, treeView1.SelectedNode.Index);
            controller.Play(indexTrack);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            controller.Open();
        }
    }
}
