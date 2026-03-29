using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MAUI_MVMContactListDesign.Models;
using Contact = MAUI_MVMContactListDesign.Models.Contact;

namespace MAUI_MVMContactListDesign.Services
{
    public static class ContactService
    {
        public static ObservableCollection<Contact> Contacts { get; set; } = new();
    }
}
