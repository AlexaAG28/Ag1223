/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bacomade;

import java.util.ArrayList;
import java.util.Date;

/**
 *
 * @author USER
 */
public class ENVIO {
private int IDEnvio;
private Date FechaEnvio;
private ArrayList<PARTIDA> partida;
private ArrayList<FORMADEPAGO> formadepago;

    public ENVIO() {
    }

    public ENVIO(int IDEnvio, Date FechaEnvio, ArrayList<PARTIDA> partida, ArrayList<FORMADEPAGO> formadepago) {
        this.IDEnvio = IDEnvio;
        this.FechaEnvio = FechaEnvio;
        this.partida = partida;
        this.formadepago = formadepago;
    }

    public ArrayList<FORMADEPAGO> getFormadepago() {
        return formadepago;
    }

    public void setFormadepago(ArrayList<FORMADEPAGO> formadepago) {
        this.formadepago = formadepago;
    }

    public int getIDEnvio() {
        return IDEnvio;
    }

    public void setIDEnvio(int IDEnvio) {
        this.IDEnvio = IDEnvio;
    }

    public Date getFechaEnvio() {
        return FechaEnvio;
    }

    public void setFechaEnvio(Date FechaEnvio) {
        this.FechaEnvio = FechaEnvio;
    }

    public ArrayList<PARTIDA> getPartida() {
        return partida;
    }

    public void setPartida(ArrayList<PARTIDA> partida) {
        this.partida = partida;
    }

       
 
    
}
   