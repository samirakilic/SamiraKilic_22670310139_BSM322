namespace SamiraKilic_22670310139;

public partial class KrediPage : ContentPage
{
    public KrediPage()
    {
        InitializeComponent();
    }

    private void VadeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        vadeLabel.Text = $"Vade: {e.NewValue:F0} Ay";
    }

    private void Hesapla_Clicked(object sender, EventArgs e)
    {
        bool tutarGecerli = double.TryParse(tutarEntry.Text, out double tutar);
        bool faizGecerli = double.TryParse(faizEntry.Text, out double faizOrani);

        if (!tutarGecerli || !faizGecerli)
        {
            sonucLabel.Text = "Lütfen geçerli bir tutar ve faiz oranı giriniz.";
            return;
        }

        int vade = (int)vadeSlider.Value;
        double aylikFaiz = faizOrani / 100;
        double toplamGeriOdeme = tutar + (tutar * aylikFaiz * vade / 12);

        sonucLabel.Text = $"Toplam Geri Ödeme: {toplamGeriOdeme:F2} ₺";
    }
}
