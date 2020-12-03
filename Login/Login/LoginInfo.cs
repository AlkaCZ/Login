using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Login
{
    public class LoginInfo
    {
        public string Title { get; set; }
        public string Name { get; set; }
        string TextOfMSG;
        public string Password
        {
            get { return TextOfMSG; }
            set
            {
                if (value.Length < 8)
                {
                    TextOfMSG = "Heslo nemá dostatek znaku";
                }
                else if (!Regex.IsMatch(value, @"\d"))//Obsahuje sp. znak
                {
                    TextOfMSG = "Heslo neobsahuje specialni znak";
                }
                else if (value.ToLower() == value)
                {
                    TextOfMSG = "Heslo neobsahuje velke pismeno";

                }
                else
                {
                    TextOfMSG = value;
                }

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
