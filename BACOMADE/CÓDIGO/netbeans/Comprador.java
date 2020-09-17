/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bacomade;

/**
 *
 * @author USER
 */
public class Comprador extends Persona{
    int idComprador;
    String telefonoC;
    String direccionC;
    
    public Comprador (){
    
    }
    
    public Comprador (int idCom, String corre, String contr, String nomb,String apelli, String docum, String tel, String dir){
    this.idComprador=idCom;
    this.correo=corre;
    this.contraseña=contr;
    this.nombre=nomb;
    this.apellidos=apelli;
    this.documento=docum;
    this.telefonoC=tel;
    this.direccionC=dir;
    }
    
    
    
public int getIdComprador(){
return idComprador;
}
    
public String getTelefonoC (){
return telefonoC;
}

public String getDireccionC (){
return direccionC;
}

public void setIdComprador (int idCom){
this.idComprador=idCom;
}

public void setTelefonoC (String telC){
this.telefonoC=telC;
}

public void setDireccionC (String direcC){
this.direccionC=direcC;
}
}

