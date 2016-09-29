using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Plainrap.ViewModel
{
    class CreateReportViewModel : ViewModelBase
    {
        public CreateReportViewModel() : base(GalaSoft.MvvmLight.Messaging.Messenger.Default)
        {

        }
    }
}
