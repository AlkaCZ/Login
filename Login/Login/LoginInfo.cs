using System;
using System.Collections.Generic;
using System.Text;

namespace Login
{
   public class LoginInfo
    {
        public string Title { get; set; }
        public string Name { get; set; }

        public string Password
        {
            get { return Password; }
            set
            {
                if (Password.Length >= 8)
                {
                    if (true)//Obsahuje sp. znak
                    {
                        if (true)//Obsahuje velke pismeno
                        {

                        }
                        else  //Vyhodit error ze nema velke pismeno
                        {

                        }

                    }
                    else //Vyhodit error ze neobsahuje sp. ynak
                    {

                    }
                }
                else //Vyhodit error ze nama dostatek znaku
                {

                }
               
                Password = value; 
            }
        }


        public LoginInfo(string title, string name, string pass)
        {
            Title = title;
            Name = name;
            Password = pass;
        }
    }
}
