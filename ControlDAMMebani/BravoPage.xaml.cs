namespace ControlDAMMebani;
public partial class BravoPage : ContentPage
{
    private string LaunchCountKey = "LaunchCount";
    public BravoPage()
	{
      
        InitializeComponent(); 
        UpdateLaunchCount();
	}
    private void UpdateLaunchCount()
    {
        if (Preferences.ContainsKey(LaunchCountKey))
        {
            int launchCount = Preferences.Get(LaunchCountKey, 0);
            launchCount++;
            Preferences.Set(LaunchCountKey, launchCount);
            l.Text = $"You have launched the app {launchCount} times.";
        }
        else
        {
            Preferences.Set(LaunchCountKey, 1);
           
        }
    }
    private void Retour_Clicked(object sender, EventArgs e)
    {
		Retour.Navigation.PushAsync(new HelloPage());
    }
}