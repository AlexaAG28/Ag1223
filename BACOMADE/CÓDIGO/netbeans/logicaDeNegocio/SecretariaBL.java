/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bacomade.logicaDeNegocio;

import bacomade.Envio;
import bacomade.Mensajero;
import bacomade.Secretaria;

/**
 *
 * @author USER
 */
public class SecretariaBL extends PersonaBL{
    //es más recomendable en vez del id poner una variable puede que se vaya a modificar más 
    //de un elemento de la clase no solo el id
    public boolean administrar(Secretaria n1){
    return true;
    }
    
    public boolean actualizarInformacion(Secretaria n1){
    return true;
    }
    
    public boolean eliminarInformacion(Secretaria n1){
    return true;
    }
    
    public boolean modificarInformacion(Secretaria n1){
    return true;
    }
    
    public boolean recibirNotificacionSE(Secretaria n1){
    return true;
    }
    
    public boolean verificarInformacion(Secretaria n1){
    return true;
    }
    
    public boolean confirmarEnvio(Secretaria n1){
    return true;
    }
    
    public boolean recibirPago(Secretaria n1){
    return true;
    }
    
    public boolean enviarPartida(Envio n1){
    return true;
    }
    
    public boolean pagarMensajero(Mensajero n1){
    return true;
    }

}
