using MAUI_MVMContactListDesign.ViewModels;

namespace MAUI_MVMContactListDesign.Views;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage()
    {
        InitializeComponent();
        BindingContext = new ContactDetailsViewModel();
    }
}