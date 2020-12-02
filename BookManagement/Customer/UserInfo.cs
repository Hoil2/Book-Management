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
        public static List<UserInfo> userdatabase = new List<UserInfo>();
        public static string userDatabasePath = @"Customer\UserDB.txt";
        public static void UserLoad()
        {
            FileInfo fileInfo = new FileInfo(userDatabasePath);
            if (fileInfo.Exists)
            {
                using (FileStream fs = new FileStream(userDatabasePath, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    userdatabase = (List<UserInfo>)binary.Deserialize(fs);
                }
            }
        }

        public static void UserSave()
        {
            using (FileStream fs = new FileStream(userDatabasePath, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binary = new BinaryFormatter();
                userdatabase.Sort();
                binary.Serialize(fs, userdatabase);
            }
        }

        public static bool ExistsID(string id)
        {
            for (int i = 0; i < userdatabase.Count; i++)
            {
                if (userdatabase[i].userID.Equals(id))
                    return true;
            }
            return false;
        }

        public static bool ComparePW(string id, string pw)
        {
            for (int i = 0; i < userdatabase.Count; i++)
            {
                if (userdatabase[i].userID.Equals(id))
                {
                    if (userdatabase[i].userPwd.Equals(pw))
                        return true;
                    else return false;
                }
            }
            return false;
        }

        public static bool CompareFindPW(string id, string ph1, string ph2, string ph3)
        {
            for (int i = 0; i < userdatabase.Count; i++)
            {
                if (userdatabase[i].userID.Equals(id))
                {
                    if (userdatabase[i].userPwd.Equals(ph1))
                    {
                        if (userdatabase[i].userPwd.Equals(ph2))
                        {
                            if (userdatabase[i].userPwd.Equals(ph3))
                            {
                                return true;
                            }
                        }
                    }
                    else return false;
                }
            }
            return false;
        }
    }
}
