using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI_NavBug
{
    public class OkViewModel : ReactiveObject, IRoutableViewModel
    {
        public string? UrlPathSegment => "Test";

        public IScreen HostScreen { get; }

        public OkViewModel(IScreen hostScreen)
        {
            HostScreen = hostScreen;
        }
    }
}
