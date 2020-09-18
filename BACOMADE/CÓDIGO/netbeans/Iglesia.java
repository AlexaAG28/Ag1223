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
public class Iglesia {
private int idIglesia;
private String nombreI;
private String municipio;
private String direccionI;
private ArrayList<Partida> listaPartida; 
private ArrayList<Secretaria> listaSecretaria;

public Iglesia (){

}

    public Iglesia(int idIglesia, String nombreI, String municipio, String direccionI, ArrayList<Partida> listaPartida, ArrayList<Secretaria> listaSecretaria) {
        this.idIglesia = idIglesia;
        this.nombreI = nombreI;
        this.municipio = municipio;
        this.direccionI = direccionI;
        this.listaPartida = listaPartida;
        this.listaSecretaria = listaSecretaria;
    }

    public int getIdIglesia() {
        return idIglesia;
    }

    public void setIdIglesia(int idIglesia) {
        this.idIglesia = idIglesia;
    }

    public String getNombreI() {
        return nombreI;
    }

    public void setNombreI(String nombreI) {
        this.nombreI = nombreI;
    }

    public String getMunicipio() {
        return municipio;
    }

    public void setMunicipio(String municipio) {
        this.municipio = municipio;
    }

    public String getDireccionI() {
        return direccionI;
    }

    public void setDireccionI(String direccionI) {
        this.direccionI = direccionI;
    }

    public ArrayList<Partida> getListaPartida() {
        return listaPartida;
    }

    public void setListaPartida(ArrayList<Partida> listaPartida) {
        this.listaPartida = listaPartida;
    }

    public ArrayList<Secretaria> getListaSecretaria() {
        return listaSecretaria;
    }

    public void setListaSecretaria(ArrayList<Secretaria> listaSecretaria) {
        this.listaSecretaria = listaSecretaria;
    }
   
}
