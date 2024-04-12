using Microsoft.Maui.Controls;

namespace pou3;

public partial class MainPage : ContentPage
{

    dog1 atual;
    boou susto;
    creatina poodol;
    pinscher01 pinscher;
    //_________________________________________________________________________
    public MainPage()
    {
        InitializeComponent();

      
        
        susto = new boou();
        poodol = new creatina();
        pinscher = new pinscher01();
        atual = new dog1();

        atual = poodol;
        
       Progresscomida.Progress = atual.comida;
       Progressagua.Progress= atual.agua;
       Progressdiversao.Progress= atual.diversao;
        
//_______________________________________________________________________________
      var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(1);
		timer.Tick += (s,e) => 
		daquiprafrentesopratrais(); 
		timer.Start();
//_______________________________________________________________________________
    }

    void botaotrocar(object sender, EventArgs args)
	{
	   if(atual == poodol)
	   { 
		  atual = susto;
	   }
	   else if(atual == susto)
	   { 
		 atual = pinscher;
	   }
	   else if (atual == pinscher)
	   {
		 atual = poodol;
	   }
    
       imgpersonage.Source = atual.GetnomedaFoto();
    }
void botaoComida(object sender, EventArgs args)
    {
       atual.setcomida(atual.Getcomida() + 0.2);
      Progresscomida.Progress = atual.Getcomida();

    }

      void botaoAgua(object sender, EventArgs args)
    {
       atual.setagua(atual.Getagua() + 0.2);
         Progressagua.Progress= atual.Getagua();

    }
      void botaoDivercao(object sender, EventArgs args)
    {
       atual.setdiversao(atual.Getdiversao() + 0.2);
        Progressdiversao.Progress= atual.Getdiversao();
}
void daquiprafrentesopratrais()
{

      atual.setcomida(atual.Getcomida() - 0.1);
 		atual.setagua(atual.Getagua() - 0.1);
      atual.setdiversao(atual.Getdiversao () - 0.1);
 		
}
}