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

   void botaofome(object sender, EventArgs args)
   	{
      	atual.setcomida(atual.setcomida() + 0.1);
		
   	}

      void botaoagua(object sender, EventArgs args)
   	{
      	atual.setagua(atual.setagua() + 0.1);
	
   	}
      void botaodivercao(object sender, EventArgs args)
   	{
      	atual.setdiversao(atual.setdiversao() + 0.1);
	
   	}
     
}

