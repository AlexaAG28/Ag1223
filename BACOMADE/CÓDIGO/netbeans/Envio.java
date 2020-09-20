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
public class Envio {
private int idEnvio;
private Date fechaEnvio;
private ArrayList<Partida> listaPartida;


    public Envio() {
        
    }

    public Envio(int idEnvio, Date fechaEnvio, ArrayList<Partida> listaPartida) {
        this.idEnvio = idEnvio;
        this.fechaEnvio = fechaEnvio;
        this.listaPartida = listaPartida;
    }

    public int getIdEnvio() {
        return idEnvio;
    }

    public void setIdEnvio(int idEnvio) {
        this.idEnvio = idEnvio;
    }

    public Date getFechaEnvio() {
        return fechaEnvio;
    }

    public void setFechaEnvio(Date fechaEnvio) {
        this.fechaEnvio = fechaEnvio;
    }

    public ArrayList<Partida> getListaPartida() {
        return listaPartida;
    }

    public void setListaPartida(ArrayList<Partida> listaPartida) {
        this.listaPartida = listaPartida;
    }
   
}
   