using System;
using System.Collections.Generic;
using System.Text;

namespace nombramiento{
class Pnombramiento:profesor{
    public int Sfijo{get;set;}
    
    public Pnombramiento(int sueldo, string nombre, string apellido, string direccion,int cedula) :base(nombre,apellido,direccion,cedula){
     this.Sfijo=sueldo;
    }
    public override void mostrar(){
        Console.WriteLine("nombre: "+nombre);
        Console.WriteLine("apellido: "+apellido);
        Console.WriteLine("direccion: "+direccion);
        Console.WriteLine("cedula: "+cedula);
        Console.WriteLine("sueldo fijo: "+Sfijo);
    }
    public override void sueldo_total(){
        do{
            Console.WriteLine("ingrese sueldo");
            int sueldo1;
            sueldo1=int.Parse(Console.ReadLine());
            Sfijo=sueldo1;
        }while(Sfijo<1000);
        Console.WriteLine("el sueldo total a recibir es de: $ "+Sfijo);
    }
}
}