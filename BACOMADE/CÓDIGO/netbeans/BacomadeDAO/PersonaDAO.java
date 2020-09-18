/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bacomade.BacomadeDAO;
//BL contiene todos los metodos además del crud y en DAO solo se pone crud
/**
 *
 * @author USER
 */
public class PersonaDAO {
    //netamente el crud 
    //DATA ACCES OBJECT - ACCESO A LA BD
    public boolean cambiarContraseña(int idSecretaria, int idComprador, String oldPass, String newPass){
        //conectar a la BD;
        //update persona set password = newpass where password = oldpass and...
    return true;
    }
    
    public boolean eliminarCuenta (int idSecretaria, int idComprador){
    return true;
    }
}
