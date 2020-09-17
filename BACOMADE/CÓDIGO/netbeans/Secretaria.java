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
public class Secretaria extends Persona{
    int idSecretaria;

    public Secretaria (){
    
    }

    public Secretaria(int idSecretaria) {
        this.idSecretaria = idSecretaria;
    }

    public Secretaria(int idSecretaria, String correo, String contraseña, String nombre, String apellidos, String documento) {
        super(correo, contraseña, nombre, apellidos, documento);
        this.idSecretaria = idSecretaria;
    }

    public int getIdSecretaria() {
        return idSecretaria;
    }

    public void setIdSecretaria(int idSecretaria) {
        this.idSecretaria = idSecretaria;
    }
    
}
