using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReactiveUI_NavBug
{
    /// <summary>
    /// Interaction logic for BrokenView.xaml
    /// </summary>
    public partial class BrokenView : ReactiveBrokenView
    {
        public BrokenView()
        {
            InitializeComponent();
        }
    }

    public class ReactiveBrokenView : ReactiveUserControl<BrokenViewModel> { }
}
