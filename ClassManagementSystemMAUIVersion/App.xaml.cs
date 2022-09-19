using ClassManagementSystemMAUIVersion.View;

namespace ClassManagementSystemMAUIVersion;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
