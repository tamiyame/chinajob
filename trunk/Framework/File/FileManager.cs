using System;
using System.IO;

namespace Com.Framework.File
{
    public class FileManager
    {
        private static string m_DefaultURL = System.Web.HttpContext.Current.Server.MapPath("\\") + @"\FileServer";
        public FileManager()
        {
        }

        public static string UploadFor(System.Web.HttpPostedFile postFile,FileType fileType)
        {
            string fuid = System.Guid.NewGuid().ToString("N");
            string dir = DirectoryCheck(fileType, fuid);
            string tmpFile = postFile.FileName;
            string fileExt = tmpFile.Substring(tmpFile.LastIndexOf('.'));
            string filename = fuid + fileExt;
            string fullname = dir + "\\" + filename;
            postFile.SaveAs(fullname);
            return GetFileURL(fileType, fuid, filename);
        }
        
        public static string UploadFor(System.Web.HttpPostedFile postFile)
        {
            FileType fileType = FileType.Upload;
            string fuid = System.Guid.NewGuid().ToString("N");
            string dir = DirectoryCheck(fileType, fuid);
            string tmpFile = postFile.FileName;
            string fileExt = tmpFile.Substring(tmpFile.LastIndexOf('.'));
            string filename = fuid + fileExt;
            string fullname = dir + "\\" + filename;
            postFile.SaveAs(fullname);
            return GetFileURL(fileType, fuid, filename);
        }

        public static string Upload(System.Web.HttpPostedFile postFile, int idx, FileType fileType)
        {
            string dir = DirectoryCheck(fileType, idx);
            string tmpFile = postFile.FileName;
            string fileExt = tmpFile.Substring(tmpFile.LastIndexOf('.'));
            string filename = idx + fileExt;
            string fullname = dir + "\\" + filename;
            postFile.SaveAs(fullname);
            return GetFileURL(fileType, idx, filename);
        }

        public static string BoardUpload(System.Web.HttpPostedFile postFile, int boardNo, int articleNo)
        {
            string dir = DirectoryCheck(FileType.Board, boardNo, articleNo);
            string tmpFile = postFile.FileName;
            string fileExt = tmpFile.Substring(tmpFile.LastIndexOf('.'));
            string filename = articleNo + fileExt;
            string fullname = dir + "\\" + filename;
            postFile.SaveAs(fullname);
            return GetFileURL(FileType.Board, boardNo, articleNo, filename);
        }

        private static string DirectoryCheck(FileType fileType, int idx)
        {
            DirectoryInfo di = new DirectoryInfo(m_DefaultURL + "\\" + fileType.ToString() + "\\" + (idx / 1000));
            if (!di.Exists)
            {
                di.Create();
            }

            return di.FullName;
        }

        private static string DirectoryCheck(FileType fileType, string fuid)
        {
            DirectoryInfo di = new DirectoryInfo(m_DefaultURL + "\\" + fileType.ToString() + "\\" + (fuid.Substring(0,4)));
            if (!di.Exists)
            {
                di.Create();
            }

            return di.FullName;
        }

        private static string DirectoryCheck(FileType fileType, int boardNo, int articleNo)
        {
            DirectoryInfo di = new DirectoryInfo(m_DefaultURL + "\\" + fileType.ToString() + "\\" + boardNo.ToString() + "\\" + (articleNo / 1000));
            if (!di.Exists)
            {
                di.Create();
            }

            return di.FullName;
        }

        public static string GetFileURL(FileType fileType, int idx, string filename)
        {
            return "/FileServer/" + fileType.ToString() + "/" + (idx / 1000) + "/" + filename;
        }

        public static string GetFileURL(FileType fileType, string fuid, string filename)
        {
            return "/FileServer/" + fileType.ToString() + "/" + fuid.Substring(0, 4) + "/" + filename;
        }

        public static string GetFileURL(FileType fileType, int boardNo, int articleNo, string filename)
        {
            return "/FileServer/" + fileType.ToString() + "/" + boardNo + "/" + (articleNo / 1000) + "/" + filename;
        }
    }
}
