using ClassManagementSystemMAUIVersion.Views;

namespace ClassManagementSystemMAUIVersion;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var navpage = new NavigationPage(new LoginPage());
        NavigationPage.SetHasNavigationBar(navpage,false);
		MainPage = navpage;
	}
}
