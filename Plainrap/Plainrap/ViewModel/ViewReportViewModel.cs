﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;


namespace Plainrap.ViewModel
{
    class ViewReportViewModel : ViewModelBase
    {
        public ViewReportViewModel() : base(GalaSoft.MvvmLight.Messaging.Messenger.Default)
        {

        }
    }
}