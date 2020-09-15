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
public class Persona {
    String correo;
    String contraseña;
    String nombre;
    String apellidos;
    String documento;

public String getCorreo(){
return correo;
}

public String getContraseña(){
return contraseña;
}

public String getNombre(){
return nombre;
}

public String getApellidos(){
return apellidos;
}

public String getDocumento(){
return documento;
}

public void setCorreo (String corr){
this.correo=corr;
}

public void setContraseña (String cont){
this.contraseña=cont;
}

public void setNombre (String nom){
this.nombre=nom;
}

public void setApellidos (String ape){
this.apellidos=ape;
}

public void setDocumento (String doc) {
this.documento=doc;
}
}
