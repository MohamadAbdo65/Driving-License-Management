using DVLDLogger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_Manage
{
    internal class clsMethodes
    {
        public static string RemoveAllEmptiness(string Text)
        {
            string NewString = string.Empty;

            for (short i = 0;  i < Text.Length; i++) 
            {
                if (Text[i] != ' ')
                {
                    NewString += Text[i];
                }
            }
            return NewString;
        }

        public static bool IsValidEmail(string Email)
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(Email, emailPattern);
        }

        public static string GetGUID()
        {
            Guid guid =  Guid.NewGuid();
            return guid.ToString();
        }

        public static bool CreateFolderIfNotExist(string FolderPath)
        {
            if (Directory.Exists(FolderPath))
                return false;


            File.Create(FolderPath);
            return true;
        }

        public static string ReplaceFileNameWithGuid(string SourceFile)
        {
            string FileName = SourceFile;
            FileInfo fi = new FileInfo(FileName);
            string extn = fi.Extension;
            return GetGUID() + extn;
        }

        public static bool CopyImageToIMageFolder(ref string SourceImageFile)
        {
            string DestinationFolder = @"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\صور المستخدمين\";

            if(CreateFolderIfNotExist(DestinationFolder))
            {
                return false;
            }

            string DestinationFile = DestinationFolder + ReplaceFileNameWithGuid(SourceImageFile);

            try
            {
                File.Copy(SourceImageFile, DestinationFile, true);
            }
            catch(Exception ex)
            {
                clsLogger.AddLog(clsLogger.enErrorLocation.ErrorInPresentation, ex.Message, System.Diagnostics.EventLogEntryType.Error);
                return false;
            }

            SourceImageFile = DestinationFile;
            return true;
        }
    }
}
