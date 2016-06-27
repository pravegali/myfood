﻿using myfoodapp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace myfoodapp.ViewModel
{
    public class HomeUserViewModel : BindableBase
    {
        private string systemHealthValue;

        public string SystemHealthValue
        {
            get { return this.systemHealthValue; }
            set { this.SetProperty(ref this.systemHealthValue, value); }
        }

        public HomeUserViewModel()
        {
            Windows.UI.Xaml.DispatcherTimer aTimer = new Windows.UI.Xaml.DispatcherTimer();
            aTimer.Tick += ATimer_Tick;
            aTimer.Interval = new TimeSpan(100000000);
            //aTimer.Start();
         
           SystemHealthValue = "89%";
        }

        private void ATimer_Tick(object sender, object e)
        {
            var alea = new Random();
            int var = alea.Next(0, 2);
            SystemHealthValue = String.Format("{0}%", 78 + var);
        }

    }

}
