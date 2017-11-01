using JewelAddinTraining.UI.Windows.Logic.ViewModels;
using Joa.JewelEarth.UI.Forms.Views;

namespace JewelAddinTraining.UI.Windows.Logic.Views
{
    /// <summary>
    ///     Interaction logic for CreateNewViewView.xaml
    /// </summary>
    public partial class CreateNewViewView : IView<CreateNewViewViewModel>
    {
        public CreateNewViewView()
        {
            InitializeComponent();
        }

        public CreateNewViewViewModel ViewModel
        {
            get { return (CreateNewViewViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}