
namespace Coursework
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OF_path = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.OF_name = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.E_BoxIndex = new System.Windows.Forms.Label();
            this.E_Category = new System.Windows.Forms.TextBox();
            this.E_Index = new System.Windows.Forms.Label();
            this.E_label2 = new System.Windows.Forms.Label();
            this.E_label1 = new System.Windows.Forms.Label();
            this.E_Name = new System.Windows.Forms.TextBox();
            this.E_FileName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.T_textBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Мемасик";
            this.openFileDialog1.Tag = "meme files (*.png)|(*.jpeg)|(*.gif)|*.png|All files (*.*)|*.*";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(6, 19);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(182, 20);
            this.link.TabIndex = 3;
            this.link.Text = "Ссылка";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(581, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Готово";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.link);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка из сети";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OF_path);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.OF_name);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 116);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Открыть по файлу";
            // 
            // OF_path
            // 
            this.OF_path.BackColor = System.Drawing.SystemColors.Control;
            this.OF_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OF_path.Location = new System.Drawing.Point(6, 23);
            this.OF_path.Name = "OF_path";
            this.OF_path.ReadOnly = true;
            this.OF_path.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.OF_path.Size = new System.Drawing.Size(182, 13);
            this.OF_path.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OF_name
            // 
            this.OF_name.Location = new System.Drawing.Point(6, 49);
            this.OF_name.Name = "OF_name";
            this.OF_name.Size = new System.Drawing.Size(182, 20);
            this.OF_name.TabIndex = 5;
            this.OF_name.Text = "Название файла";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(212, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Бекапы";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(103, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Load";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(212, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Загрузить картинки из Images";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.Save);
            this.groupBox4.Controls.Add(this.E_BoxIndex);
            this.groupBox4.Controls.Add(this.E_Category);
            this.groupBox4.Controls.Add(this.E_Index);
            this.groupBox4.Controls.Add(this.E_label2);
            this.groupBox4.Controls.Add(this.E_label1);
            this.groupBox4.Controls.Add(this.E_Name);
            this.groupBox4.Controls.Add(this.E_FileName);
            this.groupBox4.Location = new System.Drawing.Point(212, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 132);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактор";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(141, 97);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(21, 29);
            this.Save.TabIndex = 11;
            this.Save.Text = "S";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // E_BoxIndex
            // 
            this.E_BoxIndex.AutoSize = true;
            this.E_BoxIndex.Location = new System.Drawing.Point(95, 113);
            this.E_BoxIndex.Name = "E_BoxIndex";
            this.E_BoxIndex.Size = new System.Drawing.Size(16, 13);
            this.E_BoxIndex.TabIndex = 6;
            this.E_BoxIndex.Text = "-1";
            // 
            // E_Category
            // 
            this.E_Category.Location = new System.Drawing.Point(6, 71);
            this.E_Category.Name = "E_Category";
            this.E_Category.Size = new System.Drawing.Size(183, 20);
            this.E_Category.TabIndex = 5;
            // 
            // E_Index
            // 
            this.E_Index.AutoSize = true;
            this.E_Index.Location = new System.Drawing.Point(46, 94);
            this.E_Index.Name = "E_Index";
            this.E_Index.Size = new System.Drawing.Size(16, 13);
            this.E_Index.TabIndex = 4;
            this.E_Index.Text = "-1";
            // 
            // E_label2
            // 
            this.E_label2.AutoSize = true;
            this.E_label2.Location = new System.Drawing.Point(6, 113);
            this.E_label2.Name = "E_label2";
            this.E_label2.Size = new System.Drawing.Size(92, 13);
            this.E_label2.TabIndex = 3;
            this.E_label2.Text = "Номер в списке:";
            // 
            // E_label1
            // 
            this.E_label1.AutoSize = true;
            this.E_label1.Location = new System.Drawing.Point(6, 94);
            this.E_label1.Name = "E_label1";
            this.E_label1.Size = new System.Drawing.Size(44, 13);
            this.E_label1.TabIndex = 2;
            this.E_label1.Text = "Номер:";
            // 
            // E_Name
            // 
            this.E_Name.Location = new System.Drawing.Point(6, 45);
            this.E_Name.Name = "E_Name";
            this.E_Name.Size = new System.Drawing.Size(183, 20);
            this.E_Name.TabIndex = 1;
            // 
            // E_FileName
            // 
            this.E_FileName.Location = new System.Drawing.Point(6, 19);
            this.E_FileName.Name = "E_FileName";
            this.E_FileName.Size = new System.Drawing.Size(183, 20);
            this.E_FileName.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.T_textBox);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Location = new System.Drawing.Point(413, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 213);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Редактор тегов";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(81, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 181);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // T_textBox
            // 
            this.T_textBox.Location = new System.Drawing.Point(6, 155);
            this.T_textBox.Name = "T_textBox";
            this.T_textBox.Size = new System.Drawing.Size(144, 20);
            this.T_textBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 134);
            this.listBox1.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(168, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(21, 29);
            this.button9.TabIndex = 12;
            this.button9.Text = "D";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Настройки Менеджера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox OF_name;
        private System.Windows.Forms.TextBox OF_path;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox E_Name;
        private System.Windows.Forms.TextBox E_FileName;
        private System.Windows.Forms.Label E_Index;
        private System.Windows.Forms.Label E_label2;
        private System.Windows.Forms.Label E_label1;
        private System.Windows.Forms.TextBox E_Category;
        private System.Windows.Forms.Label E_BoxIndex;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox T_textBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button9;
    }
}