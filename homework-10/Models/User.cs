using System;
using static homework_10.Program;

namespace homework_10
{
    class User : IAccount
    {

        protected static int _Id { get; set; }
        public string _Fullname { get; set; }
        private string _Email { get; set; }
        private string _Password { get; set; }
       




        public User(string fullname, string email, string password)
        {
            
            _Fullname = fullname;
            _Email = email;
           
           
                if (PassswordChecker(password) == true)
                {
                    _Password = password;
                    _Id++;

                    

                }
                
            
            
            
                

        }
        public bool PassswordChecker(string Password)
        {

           // Console.WriteLine($"Password: {Password.ExtentionPasswordChecked()}");
            

            return Password.ExtentionPasswordChecked();
        }


        public void ShowInfo()
        {
            Console.WriteLine($"ID: {_Id} Fullname: {_Fullname} Email: {_Email}");
        }


    }

}
