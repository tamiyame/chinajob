using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotbookCommand
{
    public class ArgumentsBuild
    {
        private string m_FileName = string.Empty;
        private string m_Directory = string.Empty;
        private string m_SPName = string.Empty;
        private string m_ClassName = string.Empty;
        private List<string> m_Param = null;
        private string m_Namespace = string.Empty;

        public ArgumentsBuild(string directory, string fileName)
        {
            m_FileName = fileName;
            m_Directory = directory;
            m_SPName = m_FileName.Substring(0, m_FileName.LastIndexOf("."));
            m_ClassName = m_SPName.Substring(m_SPName.IndexOf("_") + 1, m_SPName.Length - m_SPName.IndexOf("_") - 1) + "Arguments";
            m_Namespace = "" + m_Directory.Substring(m_Directory.LastIndexOf("\\") + 1, m_Directory.Length - m_Directory.LastIndexOf("\\") - 1);
            m_Param = new List<string>();
        }

        private string Header()
        {
            string header = string.Empty;
            header = @"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB." + m_Namespace + @"
{
    public class " + m_ClassName + @" : DBArguments
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

        public void AddItem(string item)
        {
            string paramName = string.Empty;
            string paramType = string.Empty;
            string paramDefaultValue = string.Empty;
            string paramConvert = string.Empty;

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

            for (int i = item.IndexOf("@"); i < item.Length; i++)
            {
                if (item.Substring(i, 1) == " " || item.ToCharArray(i, 1)[0] == 9)
                {
                    param = item.Substring(i, item.Length - i);
                    break;
                }
                paramName += item.Substring(i, 1).Replace("@", "");
            }

            param = param.Replace('\t', ' ').Replace("  ", " ");

            string[] arrParm = param.Split('=');
            string paramTypeASize = arrParm[0];

            if (arrParm.Length == 2)
            {
                if (arrParm[1].ToLower().IndexOf("output") != -1)
                {
                    if (arrParm[1].ToLower().IndexOf("--in") == -1)
                    {
                        return;
                    }
                }
            }
            else
            {
                if (arrParm[0].ToLower().IndexOf("output") != -1)
                {
                    if (arrParm[0].ToLower().IndexOf("--in") == -1)
                    {
                        return;
                    }
                }
                arrParm[0] = arrParm[0].ToLower().Replace("output", "");
            }

            if (paramTypeASize.IndexOf("(") != -1)
            {
                paramType = paramTypeASize.Substring(0, paramTypeASize.IndexOf("("));
            }
            else
            {
                paramType = paramTypeASize;
            }

            switch (paramType.ToLower().Trim())
            {
                case "varchar": paramType = "string"; paramDefaultValue = "string.Empty"; paramConvert = "Convert.ToString"; break;
                case "nvarchar": paramType = "string"; paramDefaultValue = "string.Empty"; paramConvert = "Convert.ToString"; break;
                case "text": paramType = "string"; paramDefaultValue = "string.Empty"; paramConvert = "Convert.ToString"; break;
                case "ntext": paramType = "string"; paramDefaultValue = "string.Empty"; paramConvert = "Convert.ToString"; break;
                case "binary": paramType = "string"; paramDefaultValue = "string.Empty"; paramConvert = "Convert.ToString"; break;
                case "int": paramType = "int"; paramDefaultValue = "0"; paramConvert = "Convert.ToInt32"; break;
                case "smallint": paramType = "short"; paramDefaultValue = "(short)0"; paramConvert = "Convert.ToInt16"; break;
                case "tinyint": paramType = "byte"; paramDefaultValue = "(byte)0"; paramConvert = "Convert.ToByte"; break;
                case "bigint": paramType = "long"; paramDefaultValue = "(long)0"; paramConvert = "Convert.ToInt64"; break;
                case "float": paramType = "double"; paramDefaultValue = "(double)0"; paramConvert = "Convert.ToDouble"; break;
                case "datatime": paramType = "DateTime"; paramDefaultValue = "DateTime.MinValue"; paramConvert = "Convert.ToDateTime"; break;
                case "smalldatatime": paramType = "DateTime"; paramDefaultValue = "DateTime.MinValue"; paramConvert = "Convert.ToDateTime"; break;
            }

            m_Param.Add(@"        public " + paramType + @" " + paramName + @"
        {
            get { return " + paramConvert + @"(GetValue(""" + paramName + @""", " + paramDefaultValue + @")); }
            set { SetValue(""" + paramName + @""", value); }
        }");
        }

        public string GetAruments()
        {
            string param = string.Empty;
            foreach (string item in m_Param)
            {
                param += (param != string.Empty ? "\r\n\r\n" : "") + item;
            }

            return Header() + param + Bottom();
        }

        public string GetClassName()
        {
            return m_ClassName;
        }
    }
}
