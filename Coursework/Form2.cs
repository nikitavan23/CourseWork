using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Coursework
{
    public partial class Form2 : Form
    {
        private Form1 m_parent;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            m_parent = f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Готово (Load)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                openFileDialog1.Filter = "Мемас jpg|*.jpg|Мемас bmp|*.bmp|Мемас png|*.png|Мемас gif|*.gif|Мемас jpeg|*.jpeg";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                OF_name.Text = openFileDialog1.SafeFileName;
                OF_path.Text = openFileDialog1.FileName;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Ошибка открытия файла";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(OF_path.Text, Application.StartupPath + "/Images/" + OF_name.Text);
                m_parent.memi.Add(new memes(OF_name.Text));
                toolStripStatusLabel1.Text = "Готово (Copy)";
                m_parent.UpdateInfo();
            }
            catch
            {
                toolStripStatusLabel1.Text = "Ошибка копирования файла";
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Загрузка...";
                WebClient wc = new WebClient();

                string filename = (new DirectoryInfo(Application.StartupPath + "/Images").GetFiles().Length + 1).ToString();
                int index = 0;

                if (link.Text[link.Text.Length - 4] == '.') index = 4;
                else if (link.Text[link.Text.Length - 5] == '.') index = 5;


                if (index == 0) filename += ".jpg";
                else filename += link.Text.Substring(link.Text.Length - index, index);

                wc.DownloadFile(link.Text, Application.StartupPath + "/Images/" + filename);
                toolStripStatusLabel1.Text = "Готово (Download)";

                m_parent.memi.Add(new memes(filename));
                m_parent.UpdateInfo();
            }
            catch
            {
                toolStripStatusLabel1.Text = "Ошибка загрузки";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Загрузка...";

                File.WriteAllText(
                    Application.StartupPath + "/Images/data.json",
                    JsonConvert.SerializeObject(m_parent.memi));

                toolStripStatusLabel1.Text = "Готово (Save backup)";

            }
            catch
            {
                toolStripStatusLabel1.Text = "Ошибка Save backup";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Загрузка...";

                m_parent.memi = JsonConvert.DeserializeObject<List<memes>>(
                    File.ReadAllText(
                        Application.StartupPath + "/Images/data.json"));

                m_parent.UpdateInfo();

                toolStripStatusLabel1.Text = "Готово (Load backup)";
            }
            catch
            {
                toolStripStatusLabel1.Text = "Ошибка Load backup";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Чтение файлов...";
                string[] extensions = { ".jpg", ".gif", ".png", ".jpeg" };

                string path = Application.StartupPath + @"\Images";
                string[] fileArray = Directory.GetFiles(path, "*.*")
                    .Where(f => extensions.Contains(System.IO.Path.GetExtension(f).ToLower())).ToArray();

                toolStripStatusLabel1.Text = fileArray.Length.ToString();

                m_parent.memi.Clear();
                for (int i = 0; i < fileArray.Length; i++)
                {
                    fileArray[i] = fileArray[i].Substring(path.Length + 1);
                    m_parent.memi.Add(new memes(fileArray[i]));
                }
                m_parent.UpdateInfo();
                toolStripStatusLabel1.Text = "Готов (Load Files)";
            }
            catch
            {
                toolStripStatusLabel1.Text = "Ошибка Load Files";
            }
        }

        public void UpdateEditor(memes info,int index, int boxindex)
        {
            E_FileName.Text = info.Filename;
            E_Name.Text = info.Name;
            E_Category.Text = info.Category;
            E_Index.Text = index.ToString();
            E_BoxIndex.Text = (boxindex + 1).ToString();

            listBox1.Items.Clear();
            for (int i = 0; i < info.tags.Count; i++)
                listBox1.Items.Add(info.tags[i]);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Сохранения объекта...";
                m_parent.memi[Convert.ToInt32(E_Index.Text)].Filename = E_FileName.Text;
                m_parent.memi[Convert.ToInt32(E_Index.Text)].Name = E_Name.Text;
                m_parent.memi[Convert.ToInt32(E_Index.Text)].Category = E_Category.Text;

                for (int i = 0; i < listBox1.Items.Count; i++)
                    m_parent.memi[Convert.ToInt32(E_Index.Text)].AddTags(Convert.ToString(listBox1.Items[i]));

                m_parent.UpdateInfo();
                toolStripStatusLabel1.Text = "Готово (сохранение объекта)";
            }
            catch
            {
                toolStripStatusLabel1.Text = "Ошибка сохранения объекта...";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains(T_textBox.Text.ToLower()))
                listBox1.Items.Add(T_textBox.Text.ToLower());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m_parent.memi.RemoveAt(Convert.ToInt32(E_Index.Text));
            E_FileName.Text = "";
            E_Name.Text = "";
            E_Category.Text = "";
            listBox1.Items.Clear();
            E_Index.Text = (-1).ToString();
            E_BoxIndex.Text = (-1).ToString();
            m_parent.UpdateInfo();
        }
    }
}
