namespace ClassManagementSystemMAUIVersion.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);

	}

	async void onClickNewAccountButton(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new NewAccountPage());
	}
		async void onClickChanged(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(entry.Text) || string.IsNullOrEmpty(entry2.Text))
		{
			await DisplayAlert("Username dan Password tidak boleh kosong", null, "Ok");
			return;
        }
			await DisplayAlert("Successfully Login with username "+entry.Text,null,"Ok");
			await Navigation.PushAsync(new SelectPage());
		}

}