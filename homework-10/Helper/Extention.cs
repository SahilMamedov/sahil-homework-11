using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10
{
   static class  Extention
    {

        public static bool ExtentionPasswordChecked( this string password)
        {
            
            
                bool islower = false;
                bool isupper = false;
                bool isnumber = false;
                bool result = false;

                if (password.Length >= 8)
                {


                    for (int i = 0; i < password.Length; i++)
                    {


                        if (char.IsUpper(password[i]))
                        {
                            isupper = true;

                        }

                        else if (char.IsNumber(password[i]))
                        {
                            isnumber = true;
                        }

                        else if (char.IsLower(password[i]))
                        {
                            islower = true;
                        }



                        else
                        {
                           
                            return false;
                        }
                    }

                }

                else
                {
                   
                    return false;
                }

                if (isupper == true && isnumber == true && islower == true)
                {
                    result = true;
                    


                }


                return result;

        }
        public static bool CheckGroupNo(this string grupno)
        {
            bool isUpper1 = false;
            bool isUpper2 = false;
            bool isNumber1 = false;
            bool isNumber2 = false;
            bool isNumber3 = false;
            bool result = false;



            if (grupno.Length == 5)
            {


                for (int i = 0; i < grupno.Length; i++)
                {
                    if (char.IsUpper(grupno[0]))
                    {
                        isUpper1 = true;
                    }

                    if (char.IsUpper(grupno[1]))
                    {
                        isUpper2 = true;
                    }

                   if (char.IsNumber(grupno[2]))

                    {
                        isNumber1 = true;
                    }
                    if (char.IsNumber(grupno[3]))

                    {
                        isNumber2 = true;
                    }
                   if (char.IsNumber(grupno[4]))

                    {
                        isNumber3 = true;
                    }
                    else
                    {
                        return false;
                    }


                }

            }
            else
            {
                return false;
            }
            if (isUpper1 == true && isUpper2 == true && isNumber1 == true && isNumber2 == true && isNumber3 == true)
            {
                result = true;
            }

            return result;

        }



    }
}
