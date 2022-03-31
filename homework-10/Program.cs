using homework_10.Models;
using System;

namespace homework_10
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("FullName daxil edin");
            string fullName = Console.ReadLine();
            Console.WriteLine("emailinizi daxil edin");
            string email = Console.ReadLine();
            Console.WriteLine("passwordunuzu daxil en 1 boyuk herf bir balaca herif ve 1 reqem olmalidi edin");
            string password = Console.ReadLine();
            User user = new User(fullName, email, password);



            while (true)
            {

                Console.WriteLine("1: Show Info");
                Console.WriteLine("2:Create new group");

                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    user.ShowInfo();
                }


                if (num == 2)
                {
                    Console.WriteLine("Group nomresi yazin");
                    string groupno = Console.ReadLine();
                    Console.WriteLine(Extention.CheckGroupNo(groupno));
                    Console.WriteLine("nece student olsun?");
                    int stulimit = Convert.ToInt32(Console.ReadLine());
                    Group group = new Group(groupno, stulimit);

                    while (true)
                    {
                        Console.WriteLine("1: Show All Student");
                        Console.WriteLine("2: Get student by id");
                        Console.WriteLine("3: Add student");
                        Console.WriteLine("0: Quit");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        if (num1 == 1)
                        {
                            group.GetAllStudents();
                        }
                        if (num1 == 2)
                        {
                            Console.WriteLine("Studentin Id-sini yazin");
                            int id = Convert.ToInt32(Console.ReadLine());
                            group.GetStudent(id);
                        }

                        

                        
                        if (num1 == 3)
                        {
                            for (int i = 0; i < stulimit; i++)
                            {
                                Console.WriteLine("Studentin Fullnamesin yazin");
                                string fullname = Console.ReadLine();
                                Console.WriteLine("Studentin pointin yazin");
                                int point = Convert.ToInt32(Console.ReadLine());
                                Student student = new Student(fullname, point);

                                group.AddStudent(student);

                            }

                        }
                        if (num1 == 0)
                        {
                            break;
                        }
                    }
                    

                }









            }



        }

    }

    public interface IAccount
    {
        bool PassswordChecker(string password);

        void ShowInfo();

    }






}

