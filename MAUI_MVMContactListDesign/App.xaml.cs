using MAUI_MVMContactListDesign.Views;

namespace MAUI_MVMContactListDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}