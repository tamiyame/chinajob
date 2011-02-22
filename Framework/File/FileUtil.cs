using System;
using System.Collections.Generic;

using System.Text;

namespace Com.Framework.File
{
    public class FileUtil
    {

        internal static string MakePathFromUID(string uid)
        {
            string retValue = string.Empty;
            for (int i = 0; i < 7; i++)
            {
                retValue += uid.Substring(i * 4, 4) + @"\";
            }

            return retValue;
        }

        internal static string MakeUrlFromUID(string uid)
        {
            string retValue = string.Empty;
            for (int i = 0; i < 7; i++)
            {
                retValue += uid.Substring(i * 4, 4) + @"/";
            }

            return retValue;
        }

        internal static string MakePathFromSeqNo(int seqNo) // 이름변경
        {
            string s = seqNo.ToString();
            string ReturnValue = "";

            s = s.PadLeft(10, '0');

            ReturnValue = FileUtil.CreatePath(
                s.Substring(0, 4),
                s.Substring(4, 3),
                s.Substring(7, 3)
                );


            return ReturnValue;
        }

        internal static string MakeUrlFromSeqNo(int seqNo)
        {
            string s = seqNo.ToString();
            string ReturnValue = "";

            s = s.PadLeft(10, '0');
            ReturnValue = FileUtil.CreateURL(
                s.Substring(0, 4),
                s.Substring(4, 3),
                s.Substring(7, 3)
                );

            return ReturnValue;
        }

        internal static string CreatePath(params string[] pathItems)
        {
            string retValue = string.Empty;
            for (int i = 0; i < pathItems.Length; i++)
            {
                if (pathItems[i] != string.Empty)
                {
                    retValue += pathItems[i] + (pathItems[i].Substring(pathItems[i].Length - 1, 1) == @"\" ? "" : @"\");
                }
            }

            return retValue;
        }

        internal static string CreateURL(params string[] urlItems)
        {
            string retValue = string.Empty;
            for (int i = 0; i < urlItems.Length; i++)
            {
                if (urlItems[i] != string.Empty)
                {
                    retValue += urlItems[i] + (urlItems[i].Substring(urlItems[i].Length - 1, 1) == @"/" ? "" : @"/");
                }
            }

            return retValue;
        }
    }
}
