using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotbookCommand
{
    public class EntityBuild
    {
        private string m_Namespace = string.Empty;
        private string m_EntityName = string.Empty;
        public EntityBuild(string _namespace, string entityName)
        {
            m_Namespace = _namespace;
            m_EntityName = entityName;
        }

        private string Header()
        {
            string header = string.Empty;
            header = @"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace " + m_Namespace + @"
{
    public class " + m_EntityName + @" : DataEntity
    {
";
            return header;
        }

        private string Bottom()
        {
            string bottom = string.Empty;
            bottom = @"
    }
}";
            return bottom;
        }

        private string AddItem(ListViewItem item)
        {
            return @"        public " + item.SubItems[1].Text + @" " + item.Text + @" { get { return " + item.SubItems[3].Text + @"(GetData(""" + item.Text + @""", " + item.SubItems[2].Text + @")); } }";
        }

        public string GetEntity(ListView.ListViewItemCollection lvCollection)
        {
            string param = string.Empty;
            foreach (ListViewItem item in lvCollection)
            {
                param += (param != string.Empty ? "\r\n" : "") + AddItem(item);
            }

            return Header() + param + Bottom();
        }
    }
}
