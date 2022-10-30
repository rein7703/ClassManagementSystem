namespace ClassManagementSystemMAUIVersion.Views;

public partial class NewAccountPage : ContentPage
{
	public NewAccountPage()
	{
		InitializeComponent();
	}

	async void onCreateAccount(object sender, EventArgs e)
	{
		await DisplayAlert("Berhasil membuat akun", null, "OK");
		await Navigation.PopAsync();
	}
}