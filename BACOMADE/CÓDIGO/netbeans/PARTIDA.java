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
private int idPartida;
private String tipo;
private Date fechaCreada;
static private String costo;
   
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

    public String getTipo() {
        return tipo;
    }

    public Date getFechaCreada() {
        return fechaCreada;
    }

    public static String getCosto() {
        return costo;
    }

    public void setIdPartida(int idPartida) {
        this.idPartida = idPartida;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public void setFechaCreada(Date fechaCreada) {
        this.fechaCreada = fechaCreada;
    }

    public static void setCosto(String costo) {
        Partida.costo = costo;
    }

  
    
}
    