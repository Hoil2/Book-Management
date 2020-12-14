using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    [Serializable]
    public class LoanInfo
    {
        public string userID;
        public string userName;
        public string bookNumber;
        public string returnDate;
        
    }

    public class Loan
    {
        public static List<LoanInfo> database;
        public static string databasePath = @"Loan\LoanDatabase.txt";
        public static void LoanLoad()
        {
            FileInfo fileInfo = new FileInfo(databasePath);
            if (fileInfo.Exists)
            {
                using (FileStream fs = new FileStream(databasePath, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    database = (List<LoanInfo>)binary.Deserialize(fs);
                }
            }
        }

        public static void LoanSave()
        {
            using (FileStream fs = new FileStream(databasePath, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, database);
            }
        }
        
        public static string FindReturnDate(string bookNumber)
        {
            foreach(var item in database)
            {
                if (item.bookNumber.Equals(bookNumber))
                    return item.returnDate;
            }
            return "";
        }
    }
}
