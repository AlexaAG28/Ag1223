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
    ArrayList<PARTIDA> partida;
    ArrayList<FORMADEPAGO> formadepago;

    public ENVIO() {
    }

    public ENVIO(int IDEnvio, Date FechaEnvio, ArrayList<PARTIDA> partida, ArrayList<FORMADEPAGO> formadepago) {
        this.IDEnvio = IDEnvio;
        this.FechaEnvio = FechaEnvio;
        this.partida = partida;
        this.formadepago = formadepago;
    }

    public int getIDEnvio() {
        return IDEnvio;
    }

    public Date getFechaEnvio() {
        return FechaEnvio;
    }

    public void setIDEnvio(int IDEnvio) {
        this.IDEnvio = IDEnvio;
    }

    public void setFechaEnvio(Date FechaEnvio) {
        this.FechaEnvio = FechaEnvio;
    }

    public void setPartida(ArrayList<PARTIDA> partida) {
        this.partida = partida;
    }

    public void setFormadepago(ArrayList<FORMADEPAGO> formadepago) {
        this.formadepago = formadepago;
    }
    
    

    public ArrayList<PARTIDA> getPartida() {
        return partida;
    }

    public ArrayList<FORMADEPAGO> getFormadepago() {
        return formadepago;
    }

    
 
    
}
   