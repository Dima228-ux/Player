namespace Player
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTrack = new System.Windows.Forms.TrackBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelNameTrack = new System.Windows.Forms.Label();
            this.labelTimePlaying = new System.Windows.Forms.Label();
            this.labelDuractionTimeTrack = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStripMovie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьТрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStop = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrack)).BeginInit();
            this.contextMenuStripMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(176, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить плейлист";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(293, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить плейлист";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сейчас играет";
            // 
            // trackBar1
            // 
            this.trackBarTrack.Location = new System.Drawing.Point(277, 127);
            this.trackBarTrack.Name = "trackBar1";
            this.trackBarTrack.Size = new System.Drawing.Size(195, 45);
            this.trackBarTrack.TabIndex = 6;
            this.trackBarTrack.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelNameTrack
            // 
            this.labelNameTrack.Location = new System.Drawing.Point(299, 71);
            this.labelNameTrack.Name = "labelNameTrack";
            this.labelNameTrack.Size = new System.Drawing.Size(173, 37);
            this.labelNameTrack.TabIndex = 9;
            // 
            // labelTimePlaying
            // 
            this.labelTimePlaying.AutoSize = true;
            this.labelTimePlaying.Location = new System.Drawing.Point(287, 108);
            this.labelTimePlaying.Name = "labelTimePlaying";
            this.labelTimePlaying.Size = new System.Drawing.Size(0, 13);
            this.labelTimePlaying.TabIndex = 11;
            // 
            // label4
            // 
            this.labelDuractionTimeTrack.AutoSize = true;
            this.labelDuractionTimeTrack.Location = new System.Drawing.Point(443, 159);
            this.labelDuractionTimeTrack.Name = "label4";
            this.labelDuractionTimeTrack.Size = new System.Drawing.Size(0, 13);
            this.labelDuractionTimeTrack.TabIndex = 12;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ContextMenuStrip = this.contextMenuStripMovie;
            this.treeView1.Location = new System.Drawing.Point(5, 41);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(266, 252);
            this.treeView1.TabIndex = 13;
           
            // 
            // contextMenuStripMovie
            // 
            this.contextMenuStripMovie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьТрекToolStripMenuItem,
            this.добавитьТрекToolStripMenuItem});
            this.contextMenuStripMovie.Name = "contextMenuStripMovie";
            this.contextMenuStripMovie.Size = new System.Drawing.Size(154, 48);
            // 
            // удалитьТрекToolStripMenuItem
            // 
            this.удалитьТрекToolStripMenuItem.Name = "удалитьТрекToolStripMenuItem";
            this.удалитьТрекToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.удалитьТрекToolStripMenuItem.Text = "Удалить трек";
            this.удалитьТрекToolStripMenuItem.Click += new System.EventHandler(this.удалитьТрекToolStripMenuItem_Click);
            // 
            // добавитьТрекToolStripMenuItem
            // 
            this.добавитьТрекToolStripMenuItem.Name = "добавитьТрекToolStripMenuItem";
            this.добавитьТрекToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.добавитьТрекToolStripMenuItem.Text = "Добавить трек";
            this.добавитьТрекToolStripMenuItem.Click += new System.EventHandler(this.добавитьТрекToolStripMenuItem_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(368, 179);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(52, 22);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "20-512.png");
            this.imageList1.Images.SetKeyName(1, "img_527371.png");
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Plaer.Properties.Resources.unnamed__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(426, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Plaer.Properties.Resources.unnamed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(277, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::Plaer.Properties.Resources._20_512;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.Location = new System.Drawing.Point(324, 179);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(38, 23);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(93, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 17;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 294);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelDuractionTimeTrack);
            this.Controls.Add(this.labelTimePlaying);
            this.Controls.Add(this.labelNameTrack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.trackBarTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPlay);
            this.Name = "FormMain";
            this.Text = "Плеер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrack)).EndInit();
            this.contextMenuStripMovie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonPlay;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar trackBarTrack;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Label labelNameTrack;
        public System.Windows.Forms.Label labelTimePlaying;
        public System.Windows.Forms.Label labelDuractionTimeTrack;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public  System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMovie;
        private System.Windows.Forms.ToolStripMenuItem удалитьТрекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТрекToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonOpen;
    }
}

