using Prism.Commands;
using Xamarin.Forms;

namespace HealthApp.Views
{
    public partial class AppointmentPage : ContentPage
    {

        private DelegateCommand _fieldName;
        public DelegateCommand CommandName =>
            _fieldName ?? (_fieldName = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {

        }
        
        
        
        public AppointmentPage()
        {
            InitializeComponent();
        }
   }
}
