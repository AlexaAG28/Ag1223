/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bacomade;

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
    
        //con elementos en el constructor
    Secretaria n1 = new Secretaria (1, "luciamz@gmail.com", "1234567", "Lucia", "Mesa Zapata", "Cl 65 63 B 13");
    System.out.println(n1.getNombre());
    
    }
}