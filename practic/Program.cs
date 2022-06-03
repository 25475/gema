using System;
namespace practicar{
    class program {
        static void Main(string[] args){
            profesor profeHora=new profeHora(10, 24, "juan", "machuca", "centro", 1234567890);
            profeHora.mostrar();
            profeHora.sueldo_total();

            profesor Pcontrato= new Pcontrato(400, 58,60, "walter", "zambrano", 9876543210, "los esteros");
            Pcontrato.mostrar();
            Pcontrato.sueldo_total();

            profesor Pnombramiento= new Pnombramiento(400,"solange", "vazques", " manta", 5469871237);
            Pnombramiento.mostrar();
            Pnombramiento.sueldo_total();
        }
    }
}