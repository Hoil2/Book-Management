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
    public class BookInfo : IComparable
    {
        public string bookNumber;
        public string bookName;
        public string author;
        public string publisher;
        public string publicationYear;
        public string bookStatus;
        public string bookLoanPeriod;
        // 대출기간 빌린 날 + 14일
        public int CompareTo(object obj)
        {
            return bookNumber.CompareTo((obj as BookInfo).bookNumber);
        }
    }

    public class Book
    {
        public static List<BookInfo> database;
        public static string bookDatabasePath = @"Book\BookDatabase.txt";
        public static void BookLoad()
        {
            FileInfo fileInfo = new FileInfo(bookDatabasePath);
            if (fileInfo.Exists)
            {
                using (FileStream fs = new FileStream(bookDatabasePath, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    database = (List<BookInfo>)binary.Deserialize(fs);
                }
            }
        }

        public static void BookSave()
        {
            using (FileStream fs = new FileStream(bookDatabasePath, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binary = new BinaryFormatter();
                database.Sort();
                binary.Serialize(fs, database);
            }
        }
    }
    
}
