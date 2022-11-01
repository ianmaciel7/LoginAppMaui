namespace LoginApp;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string username = this.UsernameEntry.Text;
        string password = this.PasswordEntry.Text;
    }
}

