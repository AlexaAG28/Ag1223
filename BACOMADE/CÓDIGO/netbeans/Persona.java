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

    //estos son costructores
public Persona (){

}
    public Persona(String correo, String contraseña, String nombre, String apellidos, String documento) {
        this.correo = correo;
        this.contraseña = contraseña;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.documento = documento;
    }
  //

//get es obtener, él devuelve    
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

//void significa vacío
//set es enviar, pero no devuelve

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public void setContraseña(String contraseña) {
        this.contraseña = contraseña;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public void setDocumento(String documento) {
        this.documento = documento;
    }

}
