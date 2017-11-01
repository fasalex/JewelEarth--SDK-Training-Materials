using JewelAddinTraining.UI.Windows.Logic.ViewModels;
using Joa.JewelEarth.UI.Forms.Views;

namespace JewelAddinTraining.UI.Windows.Logic.Views
{
    /// <summary>
    ///     Interaction logic for CreatePolylineSetView.xaml
    /// </summary>
    public partial class CreatePolylineSetView : IView<CreatePolylineSetViewModel>
    {
        public CreatePolylineSetView()
        {
            InitializeComponent();
        }

        public CreatePolylineSetViewModel ViewModel
        {
            get { return (CreatePolylineSetViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}