namespace SamiraKilic_22670310139;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void KrediSayfasinaGit(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new KrediPage());
    }

    private async void VKISayfasinaGit(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VKIPage());
    }

    private async void RenkSayfasinaGit(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RenkPage());
    }
}
