﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ello : ContentPage
    {
        public Ello(LoginInfo loginInfo)
        {
            InitializeComponent();
            TitleHello.Text = loginInfo.Title;
            NameHello.Text = loginInfo.Name;
            PassHello.Text = loginInfo.Password;
        }
    }
}