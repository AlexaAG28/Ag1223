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
public class Iglesia {
int idIglesia;
String nombreI;
String municipio;
String direccionI;

public int getIdIglesia(){
return idIglesia;
}

public String getNombreI(){
return nombreI;
}

public String getMunicipio(){
return municipio;
}

public String getDireccionI(){
return direccionI;
}

public void setIdIglesia(int idIgle){
this.idIglesia= idIgle;
}

public void setNombreI (String nombreIgle){
this.nombreI=nombreIgle;
}

public void setMunicipio (String nMunicipio){
this.municipio=nMunicipio;
}

public void setDireccionI (String direccionIgle){
this.direccionI=direccionIgle;
} 
}
