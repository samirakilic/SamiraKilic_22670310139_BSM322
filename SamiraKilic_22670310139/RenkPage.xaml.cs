using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiraKilic_22670310139;


public partial class RenkPage : ContentPage
{
    public RenkPage()
    {
        InitializeComponent();
    }

    private void RenkDegisti(object sender, ValueChangedEventArgs e)
    {
        int r = (int)redSlider.Value;
        int g = (int)greenSlider.Value;
        int b = (int)blueSlider.Value;

        string hex = $"#{r:X2}{g:X2}{b:X2}";
        renkKodLabel.Text = hex;

        this.BackgroundColor = Color.FromRgb(r, g, b);
    }

    private async void KopyalaClicked(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(renkKodLabel.Text);
        await DisplayAlert("Kopyalandı", $"{renkKodLabel.Text}", "Tamam");
    }

    private void RastgeleRenkClicked(object sender, EventArgs e)
    {
        Random rnd = new Random();
        redSlider.Value = rnd.Next(0, 256);
        greenSlider.Value = rnd.Next(0, 256);
        blueSlider.Value = rnd.Next(0, 256);
    }
}
