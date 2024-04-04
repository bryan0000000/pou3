namespace pou3;
public class dog1
{
	
      public double comida;
      public double agua;
      public double diversao;



      public dog1()
      {
      
       comida = 0;
       agua = 0;
       diversao = 0;
      }

    public string getfoto()
        {
            return onomedafoto
        }  
//________________________________________________________________________________________
      public void setcomida (double c)
        {
            if(c>=0 && c <= 1)
                comida = c;
            else if (c > 1)            
                comida = 1;
        }    
//_________________________________________________________________________________________
        public void setagua (double a)
        {
            if(a>=0 && a <= 1)
                agua = a;
            else if (a > 1)            
                agua = 1;
        }    
//_________________________________________________________________________________________
      public void setdiversao (double d)
       {
            if(d>=0 && d <= 1)
                diversao = d;
            else if (d > 1)            
                diversao = 1;
       }       
       
}









