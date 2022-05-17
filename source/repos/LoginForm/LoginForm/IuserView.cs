using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LoginForm
{
    public interface IuserView
    {
        //properties-Fields
        string id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string gender { get; set; }
        string email { get; set; }
        DateTime sinhnhat { get; set; }
        string roleUser { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        bool Message { get; set; }
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void setUserBindingSource(BindingSource userlist);
        void Show();

    }
}