/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Alexa AG
 */
public class Mensajero {
     int Idmensajero;
   String nombrem;
   String telefono;
   String documentom; 
   String correo_s;
   
   public int getIdmensajero(){
   return Idmensajero;
   }
   
   public String getnombrem(){
       return nombrem;
   }
   
   public String gettelefono (){
      return telefono; 
   }
   
   public String getdocumentom (){
       return documentom;
   }
   
   public void setIdmensajero (int IdmensajeroAP){
       this.Idmensajero= IdmensajeroAP;
   }
   
   public void setnombrem(String nombreAP){
       String dato;
       this.nombrem=nombreAP;
       dato="Pepito Perez";
   }
   
   public void settelefono (String telefonoAP){
       String dato;
       this.telefono = telefonoAP;
       dato="2582845";
   }
   
     public void setdocumentom (String documentomAP){
       String dato;
       this.documentom= documentomAP;
       dato="10467892";
   }
      public void setcorreo_s (String correo_sAP){
       String dato;
       this.correo_s= correo_sAP;
       dato="Dora.divinaprov@arqmedellin.com";
     
   
   
}

    
    
}
