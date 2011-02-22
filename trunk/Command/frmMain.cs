using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotbookCommand.StoreProc;

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

            StreamWriter w = new StreamWriter(@".\dir.info");
            w.WriteLine("{0}", txtDirectory.Text);
            w.Close();
            w.Dispose();
            w = null;

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

                StreamWriter w = new StreamWriter(@".\dir.info");
                w.WriteLine("{0}", m_Directory);
                w.Close();
                w.Dispose();
                w = null;
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
                        if (line.Replace("\t", "").Replace(" ", "") != "as")
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
                sr.Close();
                sr.Dispose();
                sr = null;
                txtAccess.Text = ab.GetAccess();
                txtAccessName.Text = ab.GetClassName();
                txtArguments.Text = argBuild.GetAruments();
                txtArgumentsName.Text = argBuild.GetClassName();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@".\dir.info");
            if (fi.Exists)
            {
                StreamReader sr = new StreamReader(@".\dir.info");
                if (!sr.EndOfStream)
                {
                    m_Directory = sr.ReadLine();
                }
                sr.Close();
                sr.Dispose();
                sr = null;
            }
            m_Directory = m_Directory != string.Empty ? m_Directory : @"C:\";
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

            foreach (ListViewItem item in lstEntityParam.Items)
            {
                if (item.Text.ToLower() == txtParamName.Text.ToLower().Trim())
                {
                    item.Remove();
                }
            }

            ListViewItem paramItem = new ListViewItem();
            paramItem.Text = txtParamName.Text;
            paramItem.SubItems.Add(DBInfo.ReplaceToC(cmbType.SelectedItem.ToString()));
            paramItem.SubItems.Add(DBInfo.DefaultValue(cmbType.SelectedItem.ToString()));
            paramItem.SubItems.Add(DBInfo.ConvertC(cmbType.SelectedItem.ToString()));
            lstEntityParam.Items.Add(paramItem);
            txtParamName.Text = "";
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstEntityParam.SelectedItems)
            {
                item.Remove();
            }
        }

        private void btnEntity_Click(object sender, EventArgs e)
        {
            EntityBuild eb = new EntityBuild(txtNamespace.Text, txtEntityName.Text);
            txtEntity.Text = eb.GetEntity(lstEntityParam.Items);
        }

        private void btnSPGen_Click(object sender, EventArgs e)
        {
            SPFrkBuild sb = new SPFrkBuild(txtSPName.Text, lstParam.Items);
            txtSPGen.Text = sb.GetSP();
        }

        private void btnAccessClipboard_Click(object sender, EventArgs e)
        {
            if (txtAccess.Text == string.Empty)
            {
                Clipboard.Clear();
                return;
            }
            Clipboard.SetText(txtAccess.Text);
        }

        private void btnArgumentsClipboard_Click(object sender, EventArgs e)
        {
            if (txtArguments.Text == string.Empty)
            {
                Clipboard.Clear();
                return;
            }
            Clipboard.SetText(txtArguments.Text);
        }

        private void btnEntityClipboard_Click(object sender, EventArgs e)
        {
            if (txtEntity.Text == string.Empty)
            {
                Clipboard.Clear();
                return;
            }
            Clipboard.SetText(txtEntity.Text);
        }

        private void btnSPClipboard_Click(object sender, EventArgs e)
        {
            if (txtSPGen.Text == string.Empty)
            {
                Clipboard.Clear();
                return;
            }
            Clipboard.SetText(txtSPGen.Text);
        }

        private void btnDBReader_Click(object sender, EventArgs e)
        {
            DataSet ds = DBInfo.GetTableList();
            if (ds != null)
            {
                lstTable.Items.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstTable.Items.Add(dr["table_name"].ToString());
                }
            }
            else
            {
                MessageBox.Show("connection.info 파일이 존재하지 않습니다.");
            }
        }


        private void btnEntityDBConnect_Click(object sender, EventArgs e)
        {
            DataSet ds = DBInfo.GetTableList();
            if (ds != null)
            {
                lstEntityTable.Items.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstEntityTable.Items.Add(dr["table_name"].ToString());
                }
            }
            else
            {
                MessageBox.Show("connection.info 파일이 존재하지 않습니다.");
            }
        }

        private void lstTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = DBInfo.GetFieldList(lstTable.SelectedItem.ToString());
            lstField.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = dr["name"].ToString();
                lv.SubItems.Add(dr["typename"].ToString());
                lv.SubItems.Add(dr["length"].ToString() == "-1" ? "MAX" : dr["length"].ToString());
                lv.SubItems.Add(dr["is_primary"].ToString());
                lv.SubItems.Add(dr["is_identity"].ToString());
                lv.Checked = dr["is_nullable"].ToString().ToLower() == "true" ? true : false;
                lstField.Items.Add(lv);
            }

            txtSPName.Text = "TSP_" + lstTable.SelectedItem.ToString().Replace("TB_", "").Replace("tb_", "").Replace("Tb_", "").Replace("tB_", "");
        }

        private void lstEntityTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = DBInfo.GetFieldList(lstEntityTable.SelectedItem.ToString());
            lstEntityField.Items.Clear();
            lstEntityParam.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = dr["name"].ToString();
                lv.SubItems.Add(dr["typename"].ToString());
                lv.SubItems.Add(dr["length"].ToString());
                lv.SubItems.Add(dr["is_primary"].ToString());
                lv.SubItems.Add(dr["is_identity"].ToString());
                lv.Checked = dr["is_nullable"].ToString().ToLower() == "true" ? true : false;
                lstEntityField.Items.Add(lv);

                AddEntityParam(lv);
            }
            txtEntityName.Text = lstEntityTable.SelectedItem.ToString().Replace("TB_", "").Replace("tb_", "").Replace("Tb_", "").Replace("tB_", "") + "Entity";
        }

        private void txtSPGen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtSPGen.SelectAll();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(txtSPGen.SelectedText);
            }
        }

        private void btnInputParam_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstField.SelectedItems)
            {
                AddParam(item, "INPUT");
            }
        }

        private void btnOutParam_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstField.SelectedItems)
            {
                AddParam(item, "OUTPUT");
            }
        }

        private void btnInOutParam_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstField.SelectedItems)
            {
                AddParam(item, "INPUT/OUTPUT");
            }
        }

        private void btnParamClear_Click(object sender, EventArgs e)
        {
            lstParam.Items.Clear();
        }

        private void lstParam_Click(object sender, EventArgs e)
        {
            if (lstParam.SelectedItems.Count > 0)
            {
                panParamModify.Show();
                ListViewItem lv = lstParam.SelectedItems[0];
                txtParam_Name.Text = lv.Text;
                cmbParam_Type.Text = lv.SubItems[1].Text;
                txtParam_Size.Text = lv.SubItems[2].Text;
                txtParam_Value.Text = lv.SubItems[3].Text;
                cmbParam_INOUT.Text = lv.SubItems[4].Text;
            }
        }

        private void btnParamClose_Click(object sender, EventArgs e)
        {
            panParamModify.Hide();
        }

        private void btnParamRemove_Click(object sender, EventArgs e)
        {
            if (lstParam.SelectedItems.Count > 0)
            {
                ListViewItem lv = lstParam.SelectedItems[0];
                lv.Remove();
                panParamModify.Hide();
            }
        }

        private void btnParam_Modify_Click(object sender, EventArgs e)
        {
            if (lstParam.SelectedItems.Count > 0)
            {
                ListViewItem lv = lstParam.SelectedItems[0];
                lv.Text = txtParam_Name.Text;
                lv.SubItems[1].Text = cmbParam_Type.Text;
                lv.SubItems[2].Text = txtParam_Size.Text;
                lv.SubItems[3].Text = txtParam_Value.Text;
                lv.SubItems[4].Text = cmbParam_INOUT.Text;
                panParamModify.Hide();
            }
        }

        private void AddParam(ListViewItem lvItem, string inout)
        {
            ParamCheck(lvItem);
            ListViewItem paramItem = new ListViewItem();
            paramItem.Text = lvItem.Text;
            paramItem.SubItems.Add(lvItem.SubItems[1]);
            paramItem.SubItems.Add(lvItem.SubItems[2]);
            paramItem.SubItems.Add(lvItem.Checked == true ? "NULL" : "");
            paramItem.SubItems.Add(inout);
            lstParam.Items.Add(paramItem);
        }

        private void AddEntityParam(ListViewItem lvItem)
        {
            EntityCheck(lvItem);
            ListViewItem paramItem = new ListViewItem();
            paramItem.Text = lvItem.Text;
            string cType = DBInfo.ReplaceToC(lvItem.SubItems[1].Text);
            paramItem.SubItems.Add(cType);
            paramItem.SubItems.Add(DBInfo.DefaultValue(cType));
            paramItem.SubItems.Add(DBInfo.ConvertC(cType));
            lstEntityParam.Items.Add(paramItem);
        }

        private void ParamCheck(ListViewItem citem)
        {
            foreach (ListViewItem item in lstParam.Items)
            {
                if (item.Text.ToLower() == citem.Text.ToLower())
                {
                    item.Remove();
                }
            }
        }

        private void EntityCheck(ListViewItem citem)
        {
            foreach (ListViewItem item in lstEntityParam.Items)
            {
                if (item.Text.ToLower() == citem.Text.ToLower())
                {
                    item.Remove();
                }
            }
        }

        private void btnSelectPart_Click(object sender, EventArgs e)
        {
            lstParam.Items.Clear();
            if (lstTable.SelectedItems.Count != 0)
            {
                txtSPName.Text = "TSP_" + lstTable.SelectedItem.ToString().Replace("TB_", "").Replace("tb_", "").Replace("Tb_", "").Replace("tB_", "") + "GetList";
            }
            else
            {
                txtSPName.Text = "TSP_UNKNOWGetList";
            }

            ListViewItem paramItem = new ListViewItem();
            paramItem.Text = "PageNo";
            paramItem.SubItems.Add("int");
            paramItem.SubItems.Add("4");
            paramItem.SubItems.Add("1");
            paramItem.SubItems.Add("INPUT");
            lstParam.Items.Add(paramItem);

            paramItem = new ListViewItem();
            paramItem.Text = "PageSize";
            paramItem.SubItems.Add("tinyint");
            paramItem.SubItems.Add("1");
            paramItem.SubItems.Add("10");
            paramItem.SubItems.Add("INPUT");
            lstParam.Items.Add(paramItem);

            paramItem = new ListViewItem();
            paramItem.Text = "CntRow";
            paramItem.SubItems.Add("int");
            paramItem.SubItems.Add("4");
            paramItem.SubItems.Add("NULL");
            paramItem.SubItems.Add("OUTPUT");
            lstParam.Items.Add(paramItem);

            paramItem = new ListViewItem();
            paramItem.Text = "CntTotal";
            paramItem.SubItems.Add("int");
            paramItem.SubItems.Add("4");
            paramItem.SubItems.Add("NULL");
            paramItem.SubItems.Add("OUTPUT");
            lstParam.Items.Add(paramItem);

            if (lstTable.SelectedItems.Count != 0)
            {
                SelectBuild sb = new SelectBuild();
                string select = sb.GetSelect(lstTable.SelectedItem.ToString(), lstField.Items);

                SPFrkBuild spB = new SPFrkBuild(txtSPName.Text, lstParam.Items);
                txtSPGen.Text = spB.GetQuerySP(select);
            }
            else
            {
                SPFrkBuild spB = new SPFrkBuild(txtSPName.Text, lstParam.Items);
                txtSPGen.Text = spB.GetQuerySP(@"
DECLARE @SkipPage INT
SET @SkipPage = ( ( @PageNo - 1 ) * @PageSize )
"
                    );
            }
        }

        private void btnInfoPart_Click(object sender, EventArgs e)
        {
            lstParam.Items.Clear();
            if (lstTable.SelectedItems.Count != 0)
            {
                txtSPName.Text = "TSP_" + lstTable.SelectedItem.ToString().Replace("TB_", "").Replace("tb_", "").Replace("Tb_", "").Replace("tB_", "") + "GetInfo";
            }
            else
            {
                txtSPName.Text = "TSP_UNKNOWGetInfo";
            }

            foreach (ListViewItem item in lstField.Items)
            {
                if (item.SubItems[3].Text.ToLower() == "true")
                    AddParam(item, "INPUT");
                else
                    AddParam(item, "OUTPUT");
            }

            if (lstTable.SelectedItems.Count != 0)
            {
                InfoBuild ib = new InfoBuild();
                string select = ib.GetInfo(lstTable.SelectedItem.ToString(), lstParam.Items);
                SPFrkBuild spB = new SPFrkBuild(txtSPName.Text, lstParam.Items);
                txtSPGen.Text = spB.GetQuerySP(select);
            }
            else
            {
                SPFrkBuild spB = new SPFrkBuild(txtSPName.Text, lstParam.Items);
                txtSPGen.Text = spB.GetQuerySP("");
            }
        }

        private void btnInsertPart_Click(object sender, EventArgs e)
        {
            lstParam.Items.Clear();
            if (lstTable.SelectedItems.Count != 0)
            {
                txtSPName.Text = "TSP_" + lstTable.SelectedItem.ToString().Replace("TB_", "").Replace("tb_", "").Replace("Tb_", "").Replace("tB_", "") + "Create";
            }
            else
            {
                txtSPName.Text = "TSP_UNKNOWGetCreate";
            }

            foreach (ListViewItem item in lstField.Items)
            {
                if (item.SubItems[4].Text.ToLower() != "true")
                    AddParam(item, "INPUT");
            }

            if (lstTable.SelectedItems.Count != 0)
            {
                InsertBuild ib = new InsertBuild();
                string query = ib.GetInsert(lstTable.SelectedItem.ToString(), lstParam.Items);
                SPFrkBuild spB = new SPFrkBuild(txtSPName.Text, lstParam.Items);
                txtSPGen.Text = spB.GetQuerySP(query);
            }
            else
            {
                SPFrkBuild spB = new SPFrkBuild(txtSPName.Text, lstParam.Items);
                txtSPGen.Text = spB.GetQuerySP("");
            }
        }

        private void btnUpdatePart_Click(object sender, EventArgs e)
        {
            lstParam.Items.Clear();
            if (lstTable.SelectedItems.Count != 0)
            {
                txtSPName.Text = "TSP_" + lstTable.SelectedItem.ToString().Replace("TB_", "").Replace("tb_", "").Replace("Tb_", "").Replace("tB_", "") + "Modify";
            }
            else
            {
                txtSPName.Text = "TSP_UNKNOWGetModify";
            }

            foreach (ListViewItem item in lstField.Items)
            {
                AddParam(item, "INPUT");
            }

            if (lstTable.SelectedItems.Count != 0)
            {
                ModifyBuild mb = new ModifyBuild();
                string query = mb.GetUpdate(lstTable.SelectedItem.ToString(), lstField.Items);
                SPFrkBuild spB = new SPFrkBuild(txtSPName.Text, lstParam.Items);
                txtSPGen.Text = spB.GetQuerySP(query);
            }
            else
            {
                SPFrkBuild spB = new SPFrkBuild(txtSPName.Text, lstParam.Items);
                txtSPGen.Text = spB.GetQuerySP("");
            }
        }
    }
}
