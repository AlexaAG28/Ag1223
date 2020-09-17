/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Alexa AG
 */
public class formaPago {
   int Idpago;
   String nombreFP;
   String totalapagar;
   String fechapago; 
   
   public int getIdpago(){
   return Idpago;
   }
   
   public String getnombreFP (){
       return nombreFP;
   }
   
   public String gettotalapagar (){
      return totalapagar; 
   }
   
   public String getfechapago (){
       return fechapago;
   }
   
   public void setIdpago (int IdpagoAP){
       this.Idpago= IdpagoAP;
   }
   
   public void setnombreFP(String nombreAP){
       String dato;
       this.nombreFP=nombreAP;
       dato="Tarjeta de credito";
   }
   
   public void settotalapagar (String totalAP){
       String dato;
       this.totalapagar = totalAP;
       dato="5000";
   }
   
     public void setfechadepago (String fechaAP){
       String dato;
       this.fechapago= fechaAP;
       dato="Septiembre 12 de 2020";
   }
     
   
   
}
