namespace ClassManagementSystemMAUIVersion.Views;

public partial class SelectPage : ContentPage
{
	public SelectPage()
	{
		InitializeComponent();
	}

	private async void GotoClassReminder(object sender,EventArgs e)
	{
        await Navigation.PushAsync(new ClassReminder());
    }
}