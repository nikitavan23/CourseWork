using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Coursework
{
    public partial class Form1 : Form
    {
        Form2 newForm;
        public List<memes> memi { get; set; }
        private List<int> indexmemi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "/Images/" + memi[indexmemi[listBox1.SelectedIndex]].Filename);
                    newForm.UpdateEditor(memi[indexmemi[listBox1.SelectedIndex]], indexmemi[listBox1.SelectedIndex], listBox1.SelectedIndex);
                }
                catch
                {
                    if (listBox1.SelectedIndex < memi.Count) memi[listBox1.SelectedIndex].Name = "<Ошибка файла!>";
                    UpdateInfo();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (comboBox1.SelectedIndex != 0)
                {
                    listBox1.Items.Clear();
                    listBox1.ResetText();
                    listBox1.SelectedIndex = -1;
                    indexmemi.Clear();

                    for (int i = 0; i < memi.Count; i++)
                    {
                        if (memi[i].Category == Convert.ToString(comboBox1.Items[comboBox1.SelectedIndex]))
                        {
                            listBox1.Items.Add(memi[i].Name);
                            indexmemi.Add(i);
                        }
                    }
                }
                else
                {
                    Updatelist();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "/Images"))
                Directory.CreateDirectory(Application.StartupPath + "/Images");

            newForm = new Form2(this);
            memi = new List<memes>();
            indexmemi = new List<int>();
        }

        public void Updatelist()
        {
            listBox1.Items.Clear();
            listBox1.ResetText();
            listBox1.SelectedIndex = -1;
            indexmemi.Clear();

            for (int i = 0; i < memi.Count; i++)
            {
                listBox1.Items.Add(memi[i].Name);
                indexmemi.Add(i);

                if (!comboBox1.Items.Contains(memi[i].Category))
                    comboBox1.Items.Add(memi[i].Category);
            }
        }

        public void UpdateInfo()
        {
            comboBox1.Items.Clear();
            comboBox1.ResetText();
            comboBox1.Items.Add("All");
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '#')
                {
                    listBox1.Items.Clear();
                    listBox1.ResetText();
                    listBox1.SelectedIndex = -1;
                    indexmemi.Clear();

                    for (int i = 0; i < memi.Count; i++)
                        if (memi[i].HaveTag(textBox1.Text.Substring(1, textBox1.Text.Length - 1)))
                        {
                            listBox1.Items.Add(memi[i].Name);
                            indexmemi.Add(i);
                        }
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox1.ResetText();
                    listBox1.SelectedIndex = -1;
                    indexmemi.Clear();

                    for (int i = 0; i < memi.Count; i++)
                        if (memi[i].Name.Contains(textBox1.Text))
                        {
                            listBox1.Items.Add(memi[i].Name);
                            indexmemi.Add(i);
                        }
                }
            }
            else
            {
                Updatelist();
            }
        }
    }
}
