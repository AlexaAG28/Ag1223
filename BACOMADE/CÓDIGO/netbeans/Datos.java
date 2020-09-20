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
public class Datos {
    
    public static void main (String [] args) {
        Iglesia goretti = new Iglesia (); //con el construtor vacío
        goretti.setIdIglesia(1);
        String municipio="Bello";
        goretti.setMunicipio (municipio);
        goretti.setNombreI ("Santa María Goretti");
        goretti.setDireccionI ("Cl 65 63 B 13");
        System.out.println(goretti.getMunicipio());
        System.out.println(goretti.getDireccionI());
        System.out.println("Nombre de la iglesia: " +goretti.getNombreI());
    
        Envio envio = new Envio();
        Partida n = new Partida();
        n.setIdPartida(1);
        n.setTipo("Bautismo");
        
        Partida n22 = new Partida();
        n22.setIdPartida(2);
        n22.setTipo("Confirmación");
        
        Partida n3 = new Partida();
        n3.setIdPartida(3);
        n3.setTipo("Matrimonio");
        
        Partida n4 = new Partida();
        n4.setIdPartida(4);
        n4.setTipo("Defunción");
        ArrayList<Partida> lista = new ArrayList();
        lista.add(n);
        lista.add(n22);
        lista.add(n3);
        lista.add(n4);
        envio.setListaPartida(lista);
        System.out.println(envio.getListaPartida());
        
        //sin elementos en el constructor
    Secretaria n2 = new Secretaria();
        //con elementos en el constructor
    Secretaria n1 = new Secretaria ();
    n1.setNombre ("Vanessa");
    n1.setApellidos ("Orrego Mesa");
    n1.setCorreo ("vaneorremes@gmail.com");
    System.out.println(n1.getNombre());
    System.out.println(n1.getApellidos());
    System.out.println(n1.getCorreo());
    
    
    }
}