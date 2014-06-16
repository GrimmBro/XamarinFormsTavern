<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Xamarin.Forms;


namespace XamarinFormsTavern.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            Content = XamarinFormsTavern.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Xamarin.Forms;


namespace XamarinFormsTavern.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            Content = XamarinFormsTavern.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}
>>>>>>> 8b2a16313c570a696ccd3b0c72209f96b7fb03cd
