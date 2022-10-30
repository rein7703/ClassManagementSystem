namespace ClassManagementSystemMAUIVersion.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();


	}
		async void onClickChanged(object sender, EventArgs e)
		{
			await DisplayAlert("Successfully Login with username "+entry.Text,null,"Ok");
		}

}