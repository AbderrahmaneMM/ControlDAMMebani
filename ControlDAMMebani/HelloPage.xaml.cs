namespace ControlDAMMebani;

public partial class HelloPage : ContentPage
{
	public HelloPage()
	{
		InitializeComponent();
	}

    private void test_Clicked(object sender, EventArgs e)
    {
		if (sisir.Text == "DAM2024") 
		{
			this.Navigation.PushAsync(new BravoPage());
			 }
	     else { DisplayAlert("Error", "Try again...!", "OK"); }
    }
}