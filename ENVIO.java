/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bacomade;

import java.util.ArrayList;

/**
 *
 * @author USER
 */
public class ENVIO {
    int IDEnvio;
    Date FechaEnvio;
    MENSAJERO mensajero;
    ArrayList<PARTIDA> partida;
    DATOS datos;
    ArrayList<FORMADEPAGO> formadepago;

    public ENVIO() {
    }

    public ENVIO(int IDEnvio, Date FechaEnvio, MENSAJERO mensajero, ArrayList<PARTIDA> partida, DATOS datos, ArrayList<FORMADEPAGO> formadepago) {
        this.IDEnvio = IDEnvio;
        this.FechaEnvio = FechaEnvio;
        this.mensajero = mensajero;
        this.partida = partida;
        this.datos = datos;
        this.formadepago = formadepago;
    }

    public int getIDEnvio() {
        return IDEnvio;
    }

    public Date getFechaEnvio() {
        return FechaEnvio;
    }

    public MENSAJERO getMensajero() {
        return mensajero;
    }

    public ArrayList<PARTIDA> getPartida() {
        return partida;
    }

    public DATOS getDatos() {
        return datos;
    }

    public ArrayList<FORMADEPAGO> getFormadepago() {
        return formadepago;
    }

    public void setIDEnvio(int IDEnvio) {
        this.IDEnvio = IDEnvio;
    }

    public void setFechaEnvio(Date FechaEnvio) {
        this.FechaEnvio = FechaEnvio;
    }

    public void setMensajero(MENSAJERO mensajero) {
        this.mensajero = mensajero;
    }

    public void setPartida(ArrayList<PARTIDA> partida) {
        this.partida = partida;
    }

    public void setDatos(DATOS datos) {
        this.datos = datos;
    }

    public void setFormadepago(ArrayList<FORMADEPAGO> formadepago) {
        this.formadepago = formadepago;
    }

   

 
    
}
   