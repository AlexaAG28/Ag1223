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
public class Secretaria extends Persona{
    int idSecretaria;

    public Secretaria (){
    
    }
    
    public Secretaria (int idSec, String crr, String cts, String nmb, String ap, String d) {
        this.idSecretaria=idSec;
        this.correo=crr;
        this.contraseña=cts;
        this.nombre=nmb;
        this.apellidos=ap;
        this.documento=d;
    }
    
public int getIdSecretaria(){
return idSecretaria;
}

public void setIdSecretaria (int idSec){
this.idSecretaria=idSec;
}
}
