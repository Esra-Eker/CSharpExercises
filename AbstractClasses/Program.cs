using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }

    //abstract classları interfacelerle virtual metodların birleşimi gibi düşünebiliriz. inheritance amacıyla kullanılır.

    abstract class Database
    {
        public void Add()  //Ekleme işlemi her yerde aynı. *tamamlanmış metod
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();  //Silme işlemi tüm veri tabanlarında farklı demiş oluyoruz.  *tamamlanmamış metod **abstract içi dolu olmayan virual metoddur.yani o her ortamdan farklı olduğu için herkesin ayrı ayrı implemente etmesi gerekir.
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle:Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }

}
