using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_MVMContactListDesign.Models;
using MAUI_MVMContactListDesign.Services;
using System.Collections.ObjectModel;
using Contact = MAUI_MVMContactListDesign.Models.Contact;

namespace MAUI_MVMContactListDesign.ViewModels;

public partial class ContactsViewModel : BaseViewModel
{
    public ObservableCollection<Contact> Contacts => ContactService.Contacts;

    [RelayCommand]
    private async Task SelectContact(Contact contact)
    {
        if (contact == null) return;

        await Shell.Current.GoToAsync(nameof(Views.ContactDetailsPage),
            new Dictionary<string, object>
            {
                { "Contact", contact }
            });
    }

    [RelayCommand]
    private async Task GoToAddContact()
    {
        await Shell.Current.GoToAsync("..");
    }
}