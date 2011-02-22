using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotbookCommand
{
    public partial class frmHotbook : Form
    {
        private string m_Directory = string.Empty;
        public frmHotbook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtDirectory.Text))
            {
                MessageBox.Show("존재하지 않는 디렉토리 입니다.");
                txtDirectory.Text = m_Directory;
                return;
            }

            m_Directory = txtDirectory.Text;
            DirectoryInfo dir = new DirectoryInfo(m_Directory);
            lstFile.Items.Clear();

            if (txtDirectory.Text.Length > 3)
            {
                lstFile.Items.Add("[.]");
                lstFile.Items.Add("[..]");
            }

            foreach (DirectoryInfo dirInfo in dir.GetDirectories())
            {
                lstFile.Items.Add("[" + dirInfo.Name + "]");
            }

            foreach (FileInfo fiSql in dir.GetFiles("*.*sql"))
            {
                lstFile.Items.Add(fiSql.Name);
            }
        }

        private void lstFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isStart = false;
            string fileName = lstFile.SelectedItem.ToString().Replace("[", "" ).Replace("]", "");

            FileInfo fi = new FileInfo(m_Directory + @"\" + fileName);
            if ((fi.Attributes & FileAttributes.Directory )== FileAttributes.Directory)
            {
                DirectoryInfo dir = new DirectoryInfo(txtDirectory.Text + @"\" + fileName);
                txtDirectory.Text = dir.FullName;
                m_Directory = txtDirectory.Text;
                lstFile.Items.Clear();
                if (txtDirectory.Text.Length > 3)
                {
                    lstFile.Items.Add("[.]");
                    lstFile.Items.Add("[..]");
                }
                foreach (DirectoryInfo dirInfo in dir.GetDirectories())
                {
                    lstFile.Items.Add("[" + dirInfo.Name + "]");
                }
                foreach (FileInfo fiSql in dir.GetFiles("*.*sql"))
                {
                    lstFile.Items.Add(fiSql.Name);
                }

            }
            else
            {
                AccessBuild ab = new AccessBuild(m_Directory, lstFile.SelectedItem.ToString());
                ArgumentsBuild argBuild = new ArgumentsBuild(m_Directory, lstFile.SelectedItem.ToString());
                StreamReader sr = new StreamReader(m_Directory + @"\" + lstFile.SelectedItem.ToString());
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (isStart)
                    {
                        if (line.ToLower().IndexOf("as") == -1)
                        {
                            if (line.IndexOf("@") != -1)
                            {
                                ab.AddItem(line);
                                argBuild.AddItem(line);
                            }
                        }
                        else
                        {
                            isStart = false;
                            break;
                        }
                    }

                    if (line.ToLower().IndexOf("proc") != -1)
                    {
                        isStart = true;
                    }
                }
                txtAccess.Text = ab.GetAccess();
                txtArguments.Text = argBuild.GetAruments();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_Directory = @"D:\Hotbook\SP";
            txtDirectory.Text = m_Directory;

            cmbType.Items.Add("string");
            cmbType.Items.Add("long");
            cmbType.Items.Add("int");
            cmbType.Items.Add("short");
            cmbType.Items.Add("byte");
            cmbType.Items.Add("double");
            cmbType.Items.Add("DateTime");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtParamName.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("파라미터 이름을 입력하세요!!!");
                return;
            }

            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("타입을 선택하세요!!!");
                return;
            }

            lstEntity.Items.Add(txtParamName.Text.Replace(" ", "") + ":" + cmbType.SelectedItem.ToString());

            EntityBuild eb = new EntityBuild(txtNamespace.Text, txtEntityName.Text);
            for (int i = 0; i < lstEntity.Items.Count; i++)
            {
                eb.AddItem(lstEntity.Items[i].ToString());
            }
            txtEntity.Text = eb.GetEntity();

            txtParamName.Text = "";
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstEntity.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 아이템을 선택하세요");
                return;
            }

            lstEntity.Items.Remove(lstEntity.SelectedItem.ToString());

            EntityBuild eb = new EntityBuild(txtNamespace.Text, txtEntityName.Text);
            for (int i = 0; i < lstEntity.Items.Count; i++)
            {
                eb.AddItem(lstEntity.Items[i].ToString());
            }
            txtEntity.Text = eb.GetEntity();
        }

        private void btnEntity_Click(object sender, EventArgs e)
        {
            EntityBuild eb = new EntityBuild(txtNamespace.Text, txtEntityName.Text);
            for (int i = 0; i < lstEntity.Items.Count; i++)
            {
                eb.AddItem(lstEntity.Items[i].ToString());
            }
            txtEntity.Text = eb.GetEntity();
        }

        private void btnSPGen_Click(object sender, EventArgs e)
        {
            SPFrkBuild sb = new SPFrkBuild(txtSPName.Text);
            txtSPGen.Text = sb.GetSP();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSPGen.Text);
        }

        private void btnAccessClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtAccess.Text);
        }

        private void btnArgumentsClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtArguments.Text);
        }

        private void btnEntityClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEntity.Text);
        }
    }
}
