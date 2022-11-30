using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommands.InitializeDB(false);

            // CRUD (Create-Read-Update-Delete)
            Console.WriteLine("명령어를 입력하세요.");
            Console.WriteLine("[0] Force Reset");
            Console.WriteLine("[1] ReadAll");
            Console.WriteLine("[2] UpdateDate");
            Console.WriteLine("[3] DeleteItem");
            while (true)
            {
                Console.Write("> ");
                string command = Console.ReadLine();
                switch(command)
                {
                    case "0":
                        DbCommands.InitializeDB(true);
                        break;
                    case "1":
                        DbCommands.ReadAll();
                        break;
                    case "2":
                        DbCommands.UpdateDate();
                        break;
                    case "3":
                        DbCommands.DeleteItem();
                        break;
                }
            }
        }
    }
}