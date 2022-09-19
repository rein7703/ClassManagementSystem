namespace ClassManagementSystemMAUIVersion.View;


using Microsoft.Maui.Devices;

public class LoginPage : ContentPage
{
	public LoginPage()
	{

		Content = new Grid
		{
			Children =
			
			{
				new BoxView{
					WidthRequest=300,
					Color=Colors.Purple
				},

				new VerticalStackLayout{
					VerticalOptions= LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
					Children =
					{
						new Label{Text=(DeviceDisplay.MainDisplayInfo.Width / 2).ToString()}
					}
				},
				
				
				
			}
		};
	}
}