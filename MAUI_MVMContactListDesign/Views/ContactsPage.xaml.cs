using MAUI_MVMContactListDesign.Models;
using MAUI_MVMContactListDesign.ViewModels;
using Contact = MAUI_MVMContactListDesign.Models.Contact;

namespace MAUI_MVMContactListDesign.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
        BindingContext = new ContactsViewModel();
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var collectionView = sender as CollectionView;

        var contact = e.CurrentSelection.FirstOrDefault() as Contact;
        if (contact == null) return;

        collectionView.SelectedItem = null;

        await Shell.Current.GoToAsync(nameof(ContactDetailsPage),
            new Dictionary<string, object>
            {
            { "Contact", contact }
            });
    }
}