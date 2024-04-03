namespace pou3;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();

		troc.Progress=0.5;
        imgpersonage.Source = atual.GetnomedaFoto();
	}

}

