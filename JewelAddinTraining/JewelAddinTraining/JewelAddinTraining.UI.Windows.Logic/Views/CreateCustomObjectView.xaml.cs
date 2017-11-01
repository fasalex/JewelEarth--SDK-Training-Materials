using JewelAddinTraining.UI.Windows.Logic.ViewModels;
using Joa.JewelEarth.UI.Forms.Views;

namespace JewelAddinTraining.UI.Windows.Logic.Views
{
    /// <summary>
    ///     Interaction logic for CreateCustomObjectView.xaml
    /// </summary>
    public partial class CreateCustomObjectView : IView<CreateCustomObjectViewModel>
    {
        public CreateCustomObjectView()
        {
            InitializeComponent();
        }

        public CreateCustomObjectViewModel ViewModel
        {
            get { return (CreateCustomObjectViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}