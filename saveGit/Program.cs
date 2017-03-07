using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace saveGit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("saveGit");
            StreamReader Joric = new StreamReader("saveGitexe.txt");
            String a = Joric.ReadLine();
            Joric.Close();
            System.Diagnostics.Process p = new System.Diagnostics.Process();  // для открытия внешней программы
            // команды, необходимые для доступа к другому приложению. изменить только путь
            p.StartInfo.FileName = @a; // имя атакуемого файла
            p.StartInfo.UseShellExecute = false;         // получает контроль над приложением
            p.StartInfo.RedirectStandardInput = true;    // перехватывает поток ввода в программу-взломщик
            p.Start(); 			        // запускает программу
            StreamReader David = new StreamReader("saveGit.txt");
            String b = David.ReadLine();
            David.Close();
            Console.WriteLine("$ cd " + b);
            p.StandardInput.WriteLine("cd "+b);
            Console.WriteLine("git init");
            p.StandardInput.WriteLine("git init");
            Console.WriteLine("git add .");
            p.StandardInput.WriteLine("git add .");
            char c='"';
            StreamReader Q = new StreamReader("saveGitName.txt");
            String name = Q.ReadLine();
            David.Close();
            StreamReader W = new StreamReader("saveGitSite.txt");
            String Site = W.ReadLine();
            David.Close();
            Console.WriteLine("git commit -m" + c + name +DateTime.Now+ c);
            p.StandardInput.WriteLine("git commit -m" + c + name+" " + DateTime.Now + c);

            Console.WriteLine("git remote add origin "+Site);
            p.StandardInput.WriteLine("git remote add origin "+Site);

            Console.WriteLine("git push -u origin master");
            p.StandardInput.WriteLine("git push -u origin master");
           // p.StandardInput.WriteLine("git config --list");
            //Console.ReadLine();
            

        }
    }
}
