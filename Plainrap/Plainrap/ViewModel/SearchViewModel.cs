using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;

using System.Threading.Tasks;

namespace Plainrap.ViewModel
{
    class SearchViewModel : ViewModelBase
    {
        public SearchViewModel() : base(GalaSoft.MvvmLight.Messaging.Messenger.Default)
        {

        }
    }
}
