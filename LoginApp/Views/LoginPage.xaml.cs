using Microsoft.Maui.Controls.Internals;

namespace LoginApp.Views;

public partial class LoginPage : ContentPage
{

    public LoginPage()
    {
        InitializeComponent();

    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string username = this.UsernameEntry.Text;
        string password = this.PasswordEntry.Text;

        if (!username.Equals("adm") || !password.Equals("123"))
        {
            DisplayAlert("Alert", "Wrong username or password", "OK");
        }
        else
        {
            Shell.Current.GoToAsync("//home");
        }



    }
}

