using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_MVMContactListDesign.Models;
using Contact = MAUI_MVMContactListDesign.Models.Contact;

namespace MAUI_MVMContactListDesign.ViewModels;

[QueryProperty(nameof(Contact), "Contact")]
public partial class ContactDetailsViewModel : BaseViewModel
{
    [ObservableProperty]
    private Contact contact;

    [ObservableProperty]
    private bool isEditing;

    public ContactDetailsViewModel()
    {
        IsEditing = false;
    }

    [RelayCommand]
    private void Edit()
    {
        IsEditing = true;
    }

    [RelayCommand]
    private void Save()
    {
        IsEditing = false;
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}