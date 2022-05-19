using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI_NavBug
{
    public class MainViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router { get; }

        public OkViewModel Ok { get; }
        public BrokenViewModel Broken { get; }
        public MainViewModel()
        {
            Router = new();

            Ok = new(this);
            Broken = new(this);

            Observable.Interval(TimeSpan.FromSeconds(4), RxApp.TaskpoolScheduler)
                .ObserveOn(RxApp.MainThreadScheduler)
                .SelectMany(_ => Router.Navigate.Execute(Ok))
                .Delay(TimeSpan.FromSeconds(2), RxApp.TaskpoolScheduler)
                .ObserveOn(RxApp.MainThreadScheduler)
                .SelectMany(_ => Router.Navigate.Execute(Broken))
                .Subscribe();

        }
    }
}
