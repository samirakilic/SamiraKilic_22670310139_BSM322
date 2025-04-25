namespace SamiraKilic_22670310139;

public partial class VKIPage : ContentPage
{
    public VKIPage()
    {
        InitializeComponent();
    }

    private void HesaplaVKI(object sender, ValueChangedEventArgs e)
    {
        double kilo = kiloSlider.Value;
        double boy = boySlider.Value / 100;

        kiloLabel.Text = $"Kilo: {kilo:F0} kg";
        boyLabel.Text = $"Boy: {boySlider.Value:F0} cm";

        double vki = kilo / (boy * boy);
        vkiSonucLabel.Text = $"VKİ: {vki:F2}";
    }
}
