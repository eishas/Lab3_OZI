using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OZI_lab1
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            string key = "yIDkNUvqZFxeicQ6p7Y1vQ==";
            FileStream fileStream = new FileStream("hash.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            if (key == streamReader.ReadLine())
            {
                UserContext db = new UserContext();
                UserCopyContext dbc = new UserCopyContext();

                if (db.Users.Find("IvanchenkoA") == null)
                {
                    db.Users.Add(new User { Name = "IvanchenkoA", Role = "admin", Password = "ІванченкоZ20", PasswordLength = 11, Blocked = false, Restriction = true });
                }

                db.SaveChanges();


                dbc.SaveChanges();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Невірний ключ");
            }
                                    
            
        }
    }
}
