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
    public Comprador(int idComprador, String telefonoC, String direccionC) {
        this.idComprador = idComprador;
        this.telefonoC = telefonoC;
        this.direccionC = direccionC;
    }

    public Comprador(int idComprador, String telefonoC, String direccionC, String correo, String contraseña, String nombre, String apellidos, String documento) {
        super(correo, contraseña, nombre, apellidos, documento);
        this.idComprador = idComprador;
        this.telefonoC = telefonoC;
        this.direccionC = direccionC;
    }

    public int getIdComprador() {
        return idComprador;
    }

    public String getTelefonoC() {
        return telefonoC;
    }

    public String getDireccionC() {
        return direccionC;
    }

    public void setIdComprador(int idComprador) {
        this.idComprador = idComprador;
    }

    public void setTelefonoC(String telefonoC) {
        this.telefonoC = telefonoC;
    }

    public void setDireccionC(String direccionC) {
        this.direccionC = direccionC;
    }

}

