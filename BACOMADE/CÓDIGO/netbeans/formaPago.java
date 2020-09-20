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
public class formaPago {
   private int idFormaP;
   private String nombreFP;
   private String totalPagar;
   private Date fechaPago; 
   private ArrayList<Envio> listaEnvio;
   private ArrayList<Comprador> listaComprador;
   
   public formaPago(){
   
   }

    public formaPago(int idFormaP, String nombreFP, String totalPagar, Date fechaPago, ArrayList<Envio> listaEnvio, ArrayList<Comprador> listaComprador) {
        this.idFormaP = idFormaP;
        this.nombreFP = nombreFP;
        this.totalPagar = totalPagar;
        this.fechaPago = fechaPago;
        this.listaEnvio = listaEnvio;
        this.listaComprador = listaComprador;
    }

    public int getIdFormaP() {
        return idFormaP;
    }

    public String getNombreFP() {
        return nombreFP;
    }

    public String getTotalPagar() {
        return totalPagar;
    }

    public Date getFechaPago() {
        return fechaPago;
    }

    public ArrayList<Envio> getListaEnvio() {
        return listaEnvio;
    }

    public ArrayList<Comprador> getListaComprador() {
        return listaComprador;
    }

    public void setIdFormaP(int idFormaP) {
        this.idFormaP = idFormaP;
    }

    public void setNombreFP(String nombreFP) {
        this.nombreFP = nombreFP;
    }

    public void setTotalPagar(String totalPagar) {
        this.totalPagar = totalPagar;
    }

    public void setFechaPago(Date fechaPago) {
        this.fechaPago = fechaPago;
    }

    public void setListaEnvio(ArrayList<Envio> listaEnvio) {
        this.listaEnvio = listaEnvio;
    }

    public void setListaComprador(ArrayList<Comprador> listaComprador) {
        this.listaComprador = listaComprador;
    }
   
}
