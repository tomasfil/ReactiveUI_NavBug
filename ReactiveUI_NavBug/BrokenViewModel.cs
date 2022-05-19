using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI_NavBug
{
    public class BrokenViewModel : ReactiveObject, IRoutableViewModel
    {
        public string? UrlPathSegment => "Test";

        public IScreen HostScreen { get; }

        public BrokenViewModel(IScreen hostScreen)
        {
            HostScreen = hostScreen;
        }
    }
}
