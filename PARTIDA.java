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
public class PARTIDA {
    int IDPartida;
    String Tipo;
    Date FechaCreada;
    String Costo;
    ArrayList<ENVIO> ENVIO;
    ArrayList<COMPRADOR> comprador;
    MENSAJERO mensajero;
    ArrayList<FORMADEPAGO> formadepago;

    public PARTIDA() {
    }

    public PARTIDA(int IDPartida, String Tipo, Date FechaCreada, String Costo, ArrayList<ENVIO> ENVIO, ArrayList<COMPRADOR> comprador, MENSAJERO mensajero, ArrayList<FORMADEPAGO> formadepago) {
        this.IDPartida = IDPartida;
        this.Tipo = Tipo;
        this.FechaCreada = FechaCreada;
        this.Costo = Costo;
        this.ENVIO = ENVIO;
        this.comprador = comprador;
        this.mensajero = mensajero;
        this.formadepago = formadepago;
    }

    public int getIDPartida() {
        return IDPartida;
    }

    public String getTipo() {
        return Tipo;
    }

    public Date getFechaCreada() {
        return FechaCreada;
    }

    public String getCosto() {
        return Costo;
    }

    public ArrayList<ENVIO> getENVIO() {
        return ENVIO;
    }

    public ArrayList<COMPRADOR> getComprador() {
        return comprador;
    }

    public MENSAJERO getMensajero() {
        return mensajero;
    }

    public ArrayList<FORMADEPAGO> getFormadepago() {
        return formadepago;
    }

    public void setIDPartida(int IDPartida) {
        this.IDPartida = IDPartida;
    }

    public void setTipo(String Tipo) {
        this.Tipo = Tipo;
    }

    public void setFechaCreada(Date FechaCreada) {
        this.FechaCreada = FechaCreada;
    }

    public void setCosto(String Costo) {
        this.Costo = Costo;
    }

    public void setENVIO(ArrayList<ENVIO> ENVIO) {
        this.ENVIO = ENVIO;
    }

    public void setComprador(ArrayList<COMPRADOR> comprador) {
        this.comprador = comprador;
    }

    public void setMensajero(MENSAJERO mensajero) {
        this.mensajero = mensajero;
    }

    public void setFormadepago(ArrayList<FORMADEPAGO> formadepago) {
        this.formadepago = formadepago;
    }
    
    
}
    