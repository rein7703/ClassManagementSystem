namespace ClassManagementSystemMAUIVersion.View;

public class NewPage1 : ContentPage
{
	public NewPage1()
	{
		Content = new VerticalStackLayout
		{
            VerticalOptions = LayoutOptions.Center,
			Children = { new ScrollView
            { 
                Content=new Image
                    {
                        Source="https://cdn.idntimes.com/content-images/community/2022/08/fromandroid-7d79b7f3c0ed19d9628f262fb94b0c37.jpg",
                        Scale=5


                    }
            }
                
        }
                
    
		};
	}
}