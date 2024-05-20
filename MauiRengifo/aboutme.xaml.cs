
namespace MauiRengifo;

public partial class aboutme : ContentPage
{
	public aboutme()
	{
		InitializeComponent();

	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}