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

    public class Mensajero {
   private int idMensajero;
   private String nombreM;
   private String telefono;
   private String documentoM; 
   private ArrayList<Envio> listaEnvio;
   
  public Mensajero(){
  
  }

    public Mensajero(int idMensajero, String nombreM, String telefono, String documentoM, ArrayList<Envio> listaEnvio) {
        this.idMensajero = idMensajero;
        this.nombreM = nombreM;
        this.telefono = telefono;
        this.documentoM = documentoM;
        this.listaEnvio = listaEnvio;
    }

    public ArrayList<Envio> getListaEnvio() {
        return listaEnvio;
    }

    public int getIdMensajero() {
        return idMensajero;
    }

    public String getNombreM() {
        return nombreM;
    }

    public String getTelefono() {
        return telefono;
    }

    public String getDocumentoM() {
        return documentoM;
    }

    public void setIdMensajero(int idMensajero) {
        this.idMensajero = idMensajero;
    }

    public void setNombreM(String nombreM) {
        this.nombreM = nombreM;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public void setDocumentoM(String documentoM) {
        this.documentoM = documentoM;
    }

    public void setListaEnvio(ArrayList<Envio> listaEnvio) {
        this.listaEnvio = listaEnvio;
    }
  
  }

