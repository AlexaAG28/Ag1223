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
   
    public PARTIDA() {
    }

    public PARTIDA(int IDPartida, String Tipo, Date FechaCreada, String Costo) {
        this.IDPartida = IDPartida;
        this.Tipo = Tipo;
        this.FechaCreada = FechaCreada;
        this.Costo = Costo;
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

   
}
    