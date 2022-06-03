using System;
using System.Collections.Generic;
using System.Text;
class profeHora:profesor{
    public int horas{get;set;}
    public int preciohora{get;set;}
    public profeHora(int horas, int preciohora, string nombre, string apellido, string direccion, int cedula):base(nombre, apellido, direccion, cedula ){
        this.preciohora = preciohora;
        this.horas = horas;
    }

    public override void mostrar(){
        Console.WriteLine ("nombre: "+nombre);
        Console.WriteLine ("apellido: "+apellido );
        Console.WriteLine ("cedula: "+cedula);
        Console.WriteLine ("dirección: "+direccion);
        Console.WriteLine ("horas trabajadas: "+horas);
        Console.WriteLine ("precio por hora: "+preciohora);
    }

    public override void sueldo_total(){
        int Phora;
        Phora=preciohora*horas;
        Console.WriteLine(" el sueldo total es de: $ "+Phora);
    }
}