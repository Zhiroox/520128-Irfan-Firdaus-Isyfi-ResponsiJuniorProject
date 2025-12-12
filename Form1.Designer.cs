namespace Responsi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            lbl_namaDev = new Label();
            lbl_proyek = new Label();
            comboBox1 = new ComboBox();
            lblstat = new Label();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btn_Insert = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 14);
            label1.Name = "label1";
            label1.Size = new Size(160, 47);
            label1.TabIndex = 0;
            label1.Text = "PRODEV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 61);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 1;
            label2.Text = "Platform recap proyek dan developer";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 25);
            textBox1.TabIndex = 2;
            // 
            // lbl_namaDev
            // 
            lbl_namaDev.AutoSize = true;
            lbl_namaDev.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_namaDev.Location = new Point(32, 41);
            lbl_namaDev.Name = "lbl_namaDev";
            lbl_namaDev.Size = new Size(105, 15);
            lbl_namaDev.TabIndex = 3;
            lbl_namaDev.Text = "Nama Developer :";
            // 
            // lbl_proyek
            // 
            lbl_proyek.AutoSize = true;
            lbl_proyek.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_proyek.Location = new Point(61, 71);
            lbl_proyek.Name = "lbl_proyek";
            lbl_proyek.Size = new Size(76, 15);
            lbl_proyek.TabIndex = 4;
            lbl_proyek.Text = "Pilih Proyek :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(336, 25);
            comboBox1.TabIndex = 5;
            // 
            // lblstat
            // 
            lblstat.AutoSize = true;
            lblstat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblstat.Location = new Point(44, 102);
            lblstat.Name = "lblstat";
            lblstat.Size = new Size(93, 15);
            lblstat.TabIndex = 6;
            lblstat.Text = "Status Kontrak :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(161, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(336, 25);
            comboBox2.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(lbl_namaDev);
            groupBox1.Controls.Add(lblstat);
            groupBox1.Controls.Add(lbl_proyek);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 137);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(37, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(678, 99);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 25);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 25);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 63);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 1;
            label4.Text = "Jumlah Bug :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 29);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "Fitur Selesai :";
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(131, 344);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(75, 23);
            btn_Insert.TabIndex = 10;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(328, 344);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 11;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(502, 344);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 12;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(655, 107);
            dataGridView1.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(37, 392);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(678, 136);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "DAFTAR PERFORMA TIM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Insert);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label lbl_namaDev;
        private Label lbl_proyek;
        private ComboBox comboBox1;
        private Label lblstat;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Button btn_Insert;
        private Button btn_Update;
        private Button btn_Delete;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
    }
}
