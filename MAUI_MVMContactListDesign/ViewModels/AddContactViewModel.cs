using MAUI_MVMContactListDesign.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_MVMContactListDesign.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact = MAUI_MVMContactListDesign.Models.Contact;


namespace MAUI_MVMContactListDesign.ViewModels
{
    public partial class AddContactViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string phone;

        [ObservableProperty]
        private string description;

        [RelayCommand]
        private async Task Save()
        {
            var contact = new Contact
            {
                Name = Name,
                Email = Email,
                Phone = Phone,
                Description = Description
            };

            ContactService.Contacts.Add(contact);

            Name = Email = Phone = Description = string.Empty;

            await Shell.Current.GoToAsync(nameof(Views.ContactsPage));
        }
    }
}