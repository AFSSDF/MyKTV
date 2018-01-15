using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using MyKTV.frm;
namespace MyKTV.sys
{
    class Shrink
    {
        static DBHelper dbHelper = new DBHelper();
        FrmDeleteList frmDeleteList = new FrmDeleteList();

        //数据库中列表
        static List<string> list = new List<string>();
        //资源路径下的所有文件
        static List<string> yuanList = new List<string>();
        //需要删除的列表文件
        static List<string> deleteList = new List<string>();
        public void ExShrink()
        {
            SqlDataReader reader1 = null;
            SqlDataReader reader0 = null;
            try
            {
                dbHelper.OpenConn();

                reader1 = new SqlCommand("SELECT song_url FROM song_info", dbHelper.Conn).ExecuteReader();
                while (reader1.Read())
                {
                    list.Add(reader1[0].ToString());
                }
                reader1.Close();
                reader0 = new SqlCommand("SELECT singer_miao  FROM singer_info ", dbHelper.Conn).ExecuteReader();
                while (reader0.Read())
                {
                    list.Add(reader0[0].ToString());
                }
                reader0.Close();


                DirectoryInfo dir = new DirectoryInfo(CopyFile.SourcePath);
                FileInfo[] fileInfo = dir.GetFiles();
                foreach (FileInfo item in fileInfo)
                {
                    yuanList.Add(item.Name);
                }

                foreach(string once0 in yuanList)
                {
                    int i = 0;
                    foreach (string once1 in list)
                    {
                        i++;
                        if (once0.Equals(once1))
                        {
                            i = -999;
                            break;
                        }
                    }
                    if (i == list.Count )
                    {
                        deleteList.Add(once0);
                        frmDeleteList.listView1.Items.Add(once0);
                    }
                }
                frmDeleteList.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                dbHelper.CloseConn();
            }
        }

        public static void No()
        {
            clearList();
            MessageBox.Show("取消成功！！", "系统提示");
        }

        public static void Yes()
        {
            foreach (string once in deleteList)
            {
                try
                {
                    System.IO.File.Delete(CopyFile.SourcePath + "\\" + once);
                }
                catch (Exception ex) { Console.Write(ex.ToString()); };
            }
            clearList();
            MessageBox.Show("收缩成功！！", "系统提示");
        }

        public static void clearList()
        {
            list.Clear();
            deleteList.Clear();
            yuanList.Clear();
        }
    }
}
