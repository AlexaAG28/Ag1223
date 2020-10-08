/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bacomade;

import java.util.Date;

/**
 *
 * @author USER
 */
public class Partida {

    public static Double getCosto() {
        return costo;
    }

    public static void setCosto(Double aCosto) {
        costo = aCosto;
    }
private int idPartida;
private String tipo;
private Date fechaCreada;
static private Double costo;
   
    public Partida(){
    
    }

    public Partida(int idPartida, String tipo, Date fechaCreada) {
        this.idPartida = idPartida;
        this.tipo = tipo;
        this.fechaCreada = fechaCreada;
    }

    public int getIdPartida() {
        return idPartida;
    }

    public void setIdPartida(int idPartida) {
        this.idPartida = idPartida;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public Date getFechaCreada() {
        return fechaCreada;
    }

    public void setFechaCreada(Date fechaCreada) {
        this.fechaCreada = fechaCreada;
    }
    
}
    