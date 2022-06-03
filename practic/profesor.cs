using System;
class profesor{
    public string nombre{get;set;}
    public string apellido{get;set;}
    public string direccion{get;set;}
    public int cedula{get;set;}

    public  profesor(string nombre, string apellido, string direccion, int cedula){
        this.nombre= nombre;
        this.apellido= apellido;
        this.cedula = cedula;
        this.direccion= direccion;
    }

    public virtual void mostrar(){}

    public virtual void sueldo_total(){}

}