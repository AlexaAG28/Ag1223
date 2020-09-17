
package bacomade;


public class Partida {
    int IDPartida;
    String Tipo;
    String FechaCreada;
    String Costo;
    
    
    public int getIDPartida () {
        return IDPartida;
    }
    
    public String getTipo () {
        return Tipo;
    }
    
   
    
    public String getFechaCreada () {
        return FechaCreada;
    }
    
     public String getCosto () {
        return Costo;
    }

    
    public  void setIDPartida(int IDPartida) {
        this.IDPartida = IDPartida;
    }
    
    
     public  void setTipo(String Tipo) {
        this.Tipo = Tipo;
    }
     
    public  void setFechaCreada(String FechaCreada) {
        this.FechaCreada = FechaCreada;
    } 
    
    public  void setCosto(String Costo) {
        this.Costo = Costo;
    }
    
}


