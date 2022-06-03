using System;
class Pcontrato:profesor{
public int Sbasico{get;set;}
public int H_extras{get;set;}
public int precioE{get;set;}

public Pcontrato(int Sbasico, int H_extras, int precioE, string nombre, string apellido, int cedula, string direccion) :base(nombre, apellido, direccion, cedula) 
{
this.Sbasico=Sbasico;
this.H_extras=H_extras;
this.precioE=precioE;
}

public override void mostrar(){
    Console.WriteLine("nombre: "+nombre);
    Console.WriteLine("apellido: "+apellido);
    Console.WriteLine("cedula: "+cedula);
    Console.WriteLine("direccion: "+direccion);
    Console.WriteLine("horas extras: "+H_extras);
    Console.WriteLine("precio de horas extras : "+precioE);
}
public override void sueldo_total(){
    int calculo, Phoras;
    Phoras=H_extras*precioE;
    calculo=Sbasico+Phoras;
    Console.WriteLine("el sueldo a recibir con horas extras es de: $ "+calculo);
}

}