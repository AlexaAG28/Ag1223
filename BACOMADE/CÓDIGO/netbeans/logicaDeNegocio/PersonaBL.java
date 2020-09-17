/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package bacomade.logicaDeNegocio;

/**
 *
 * @author USER
 */
public class PersonaBL {
    //es más recomendble en vez del id poner una variable puede que se vaya a modificar más 
    //de un elemento de la clase no solo el id
    public boolean iniciarSesion(int idSecretaria, int idComprador){
    return true;
    }

    public boolean cerrarSesion(int idSecretaria, int idComprador){
    return true;
    }
    
    public boolean cambiarContraseña(int idSecretaria, int idComprador, String oldPass, String newPass){
        //conectar a la BD;
        //update persona set password = newpass where password = oldpass and...
    return true;
    }
    
    public boolean eliminarCuenta (int idSecretaria, int idComprador){
    return true;
    }
}
