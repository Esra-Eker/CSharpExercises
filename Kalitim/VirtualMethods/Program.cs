using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();

        }
    }
    //inheritance yaptığımız ortamda genel operasyonu (değişkenlik gösteriyorsa) ezmek istediğimiz zaman virtual u kullanabiliriz.
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");  //Sqlde virtual u overried ettiğimiz için bu kod çalıştı.
            //base.Add();  //base deki Add i yaz demek. temel kodu çalıştırır.
        }
    }
    class MySql:Database  // MySqlde virtual u override etmediğimiz için temel kod çalıştı.
    {

    }
}
//bunu interface ile yapamayız. Böyle bi durum varsa inheritance ile yapmalıyız.
