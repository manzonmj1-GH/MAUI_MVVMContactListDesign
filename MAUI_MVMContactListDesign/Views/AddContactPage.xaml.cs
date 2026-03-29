using MAUI_MVMContactListDesign.ViewModels;

namespace MAUI_MVMContactListDesign.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
		BindingContext = new AddContactViewModel();
	}
}