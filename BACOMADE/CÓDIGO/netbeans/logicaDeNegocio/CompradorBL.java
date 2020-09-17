/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bacomade.logicaDeNegocio;

import bacomade.Comprador;

/**
 *
 * @author USER
 */
public class CompradorBL extends PersonaBL{
    //es más recomendble en vez del id poner una variable puede que se vaya a modificar más 
    //de un elemento de la clase no solo el id
    public boolean registrar(Comprador n1){
    return true;
    }
    
    public boolean hacerPedido(Comprador n1){
    return true;
    }
    
    public boolean ingresarDatos(Comprador n1){
    return true;
    }
    
    public boolean recibirNotificacionCE(Comprador n1){
    return true;
    }
    
    public boolean enviarPago(Comprador n1){
    return true;
    }
    
    public boolean recibirPartida(Comprador n1){
    return true;
    }
}
