using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Customer
{
    [Serializable]
    public class UserInfo : IComparable
    {
        public string userID;
        public string userName;
        public string userBirth;
        public string userPhone1, userPhone2, userPhone3;
        public string userPwd;

        public int CompareTo(object obj)
        {
            return userID.CompareTo((obj as UserInfo).userID);
        }
    }

    public class User
    {
        public static List<UserInfo> database = new List<UserInfo>();
        public static string userDatabasePath = @"Customer\UserDB.txt";
        public static void UserLoad()
        {
            FileInfo fileInfo = new FileInfo(userDatabasePath);
            if (fileInfo.Exists)
            {
                using (FileStream fs = new FileStream(userDatabasePath, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    database = (List<UserInfo>)binary.Deserialize(fs);
                }
            }
        }

        public static void UserSave()
        {
            using (FileStream fs = new FileStream(userDatabasePath, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binary = new BinaryFormatter();
                database.Sort();
                binary.Serialize(fs, database);
            }
        }

        public static bool ExistsID(string id)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].userID.Equals(id))
                    return true;
            }
            return false;
        }

        public static bool ComparePW(string id, string pw)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].userID.Equals(id))
                {
                    if (database[i].userPwd.Equals(pw))
                        return true;
                    else return false;
                }
            }
            return false;
        }

        public static string FindID(string name, string ph1, string ph2, string ph3)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].userName.Equals(name))
                {
                    if (database[i].userPhone1.Equals(ph1) &&
                        database[i].userPhone2.Equals(ph2) &&
                        database[i].userPhone3.Equals(ph3))
                    {
                        return database[i].userID;
                    }
                    return "";
                }
            }
            return "";
        }

        public static string FindPW(string id, string phone1, string phone2, string phone3)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].userID.Equals(id))
                {
                    if (database[i].userPhone1.Equals(phone1) &&
                        database[i].userPhone2.Equals(phone2) &&
                        database[i].userPhone3.Equals(phone3))
                    {
                        return database[i].userPwd;
                    }
                    return ""; // 아이디는 찾았는데 전화번호가 일치하지 않을 때
                }
            }
            return ""; // 아이디도 못찾았을 때
        }
        public static string FindAllID(string id)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].userName.Equals(id))
                {
                    return database[i].userID;
                }
                else
                {
                    return "못참음";
                }
            }
            return "";
        }

        public static string FindName(string id)
        {
            foreach(var item in database) 
            { 
                if (item.userID.Equals(id))
                    return item.userName;
            }
            return "";
        }

        public static UserInfo FindUser(string id)
        {
            foreach(var item in database)
            {
                if (item.userID.Equals(id))
                    return item;
            }
            return new UserInfo();
        }
    }
}
