﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Plainrap.ViewModel
{
    class SyncronizeViewModel : ViewModelBase
    {
        public SyncronizeViewModel() : base(GalaSoft.MvvmLight.Messaging.Messenger.Default)
        {

        }
    }
}
