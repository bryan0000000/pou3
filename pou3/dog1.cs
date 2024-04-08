namespace pou3;
public class dog1
{

    public double comida;
    public double agua;
    public double diversao;
    protected string nomedaFoto;

 

    public dog1()

    //________________________________________________________________________________________
    {
     
        comida = 0;
        agua = 0;
        diversao = 0;
        nomedaFoto ="";
    }

    //________________________________________________________________________________________
    public string GetnomedaFoto()
    {
        return nomedaFoto;
    }
    //________________________________________________________________________________________
    public void setcomida(double c)
    {
        if (c >= 0 && c <= 1)
            comida = c;
        else if (c > 1)
            comida = 1;
    }
    //_________________________________________________________________________________________
    public void setagua(double a)
    {
        if (a >= 0 && a <= 1)
            agua = a;
        else if (a > 1)
            agua = 1;
    }
    //_________________________________________________________________________________________
    public void setdiversao(double d)
    {
        if (d >= 0 && d <= 1)
            diversao = d;
        else if (d > 1)
            diversao = 1;
    }


}









