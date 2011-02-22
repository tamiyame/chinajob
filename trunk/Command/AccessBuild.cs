using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Data;

namespace HotbookCommand
{
    public class AccessBuild
    {
        private string m_FileName = string.Empty;
        private string m_Directory = string.Empty;
        private string m_SPName = string.Empty;
        private string m_ClassName = string.Empty;
        private List<string> m_Param = null;
        private string m_Namespace = string.Empty;
        public AccessBuild(string directory, string fileName)
        {
            m_FileName = fileName;
            m_Directory = directory;
            m_SPName = m_FileName.Substring(0, m_FileName.LastIndexOf("."));
            m_ClassName = m_SPName.Substring(m_SPName.IndexOf("_") + 1, m_SPName.Length - m_SPName.IndexOf("_") - 1);
            m_Namespace = "Com.Library.DB." + m_Directory.Substring(m_Directory.LastIndexOf("\\") + 1, m_Directory.Length - m_Directory.LastIndexOf("\\")-1);
            m_Param = new List<string>();
        }

        private string Header()
        {
            string header = string.Empty;
            header = @"using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace " + m_Namespace + @"
{
    public class " + m_ClassName + @" : DBDataReader<DataEntity, DataEntity>
    {
        public " + m_ClassName + @"()
            : base(new ConnectionString(), """ + m_SPName + @""")
        {
        }

        protected override void ParameterInitialize()
        {
";
            return header;
        }

        private string Bottom()
        {
            string bottom = string.Empty;
            bottom = @"
        }
    }
}";
            return bottom;
        }

        public void AddItem(string item)
        {
            string paramName = string.Empty;
            string paramType = string.Empty;
            string paramSize = string.Empty;
            string paramInout = string.Empty;

            if (item.ToLower().IndexOf("@istransaction") != -1)
            {
                return;
            }

            if (item.ToLower().IndexOf("@errorcode") != -1)
            {
                return;
            }

            if (item.ToLower().IndexOf("@errormessage") != -1)
            {
                return;
            }

            string param = string.Empty;

            for (int i = item.IndexOf( "@" ); i < item.Length; i++)
            {
                if (item.Substring(i, 1) == " " || item.ToCharArray(i,1)[0] == 9)
                {
                    param = item.Substring(i, item.Length - i);
                    break;
                }
                paramName += item.Substring(i, 1).Replace( "@", "");
            }
            
            param = param.Replace( '\t', ' ' ).Replace( " ", "" );

            string []arrParm = param.Split('=');
            string paramTypeASize = arrParm[0];
            paramInout = "SqlDataInOut.Input";
            if (arrParm.Length == 2)
            {
                if (arrParm[1].ToLower().IndexOf("output") != -1)
                {
                    if (arrParm[1].ToLower().IndexOf("--in") != -1)
                    {
                        paramInout = "SqlDataInOut.InputOutput";
                    }
                    else
                    {
                        paramInout = "SqlDataInOut.Output";
                    }
                }
            }
            else
            {
                if (arrParm[0].ToLower().IndexOf("output") != -1)
                {
                    if (arrParm[0].ToLower().IndexOf("--in") != -1)
                    {
                        paramInout = "SqlDataInOut.InputOutput";
                    }
                    else
                    {
                        paramInout = "SqlDataInOut.Output";
                    }
                }
            }

            paramTypeASize = paramTypeASize.ToLower().Replace("output", "").Replace("--in", "");
            if (paramTypeASize.IndexOf("(") != -1)
            {
                paramType = paramTypeASize.Substring(0, paramTypeASize.IndexOf("("));
                paramSize = paramTypeASize.Substring(paramTypeASize.IndexOf("(") + 1, paramTypeASize.IndexOf(")") - paramTypeASize.IndexOf("(") - 1);
                if (paramSize.ToLower() == "max")
                {
                    paramSize = "-1";
                }
            }
            else
            {
                paramType = paramTypeASize;
            }

            if (paramSize == string.Empty)
            {
                switch (paramType.ToLower())
                {
                    case "int": paramSize = "4";  break;
                    case "smallint": paramSize = "2"; break;
                    case "tinyint": paramSize = "1"; break;
                    case "bigint": paramSize = "8"; break;
                    case "float": paramSize = "8"; break;
                    case "real": paramSize = "4"; break;
                    case "datetime": paramSize = "8"; break;
                    case "smalldatatime": paramSize = "4"; break;
                    case "text": paramSize = "0"; break;
                    case "ntext": paramSize = "0"; break;

                }
            }
            
            switch (paramType.ToLower())
            {
                case "varchar": paramType = "SqlDbType.VarChar";  break;
                case "binary": paramType = "SqlDbType.Binary"; break;
                case "nvarchar": paramType = "SqlDbType.NVarChar";  break;
                case "int": paramType = "SqlDbType.Int";  break;
                case "smallint": paramType = "SqlDbType.SmallInt"; break;
                case "tinyint": paramType = "SqlDbType.TinyInt"; break;
                case "bigint": paramType = "SqlDbType.BigInt"; break;
                case "float": paramType = "SqlDbType.Float"; break;
                case "real": paramType = "SqlDbType.Real"; break;
                case "datetime": paramType = "SqlDbType.DateTime"; break;
                case "smalldatatime": paramType = "SqlDbType.SmallDateTime"; break;
                case "text": paramType = "SqlDbType.Text"; break;
                case "ntext": paramType = "SqlDbType.NText"; break;
            }

            m_Param.Add("            AddParameter(\"" + paramName.Replace("@", "") + @""", " + paramType + @", " + paramSize + @", " + paramInout + @");");
        }

        public string GetAccess()
        {
            string param = string.Empty;
            foreach( string item in m_Param )
            {
                param += ( param != string.Empty ? "\r\n" : "" ) + item;
            }

            return Header() + param + Bottom();
        }

        public string GetClassName()
        {
            return m_ClassName;
        }
    }
}
