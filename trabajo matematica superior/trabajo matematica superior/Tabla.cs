using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Tabla
    {
        private List<Punto> puntos;

        public Tabla()
        {
            puntos=new List<Punto>();
        }
        public List<Punto> get_puntos(){
            return puntos;
        }
        public List<Punto> set_puntos(){
            return puntos;
        }
        public void agregar_punto(Punto un_punto)
        {
            if(this.existe_otro_mismo_x(un_punto)){
                if(!this.es_el_mismo_punto(un_punto)){
                    //error
                    return;
                }
            }
            puntos.Add(un_punto);
        }
        public bool existe_otro_mismo_x(Punto un_punto){
            return (puntos.Any(punto => punto.get_x() == un_punto.get_x()));
        }
        public bool es_el_mismo_punto(Punto un_punto){
            return (puntos.Any(punto => (punto.get_x() == un_punto.get_x())&& (punto.get_y() == un_punto.get_y())));
        }
        public void ordenar()
        {
            puntos=this.ordenar_puntos(puntos);
        }
        public List<Punto> ordenar_puntos(List<Punto> unos_puntos)
        {
            if (unos_puntos.Count() == 0)
            {
                return unos_puntos;
            }
            Punto primero = unos_puntos[0];
            List<Punto> ordenada=this.ordenar_puntos(this.menores_a(unos_puntos,primero));
            ordenada.Add(primero);
            ordenada.Concat(this.ordenar_puntos(this.mayores_a(unos_puntos,primero)));
            return ordenada;
        }
        public List<Punto> mayores_a(List<Punto> unos_puntos, Punto otro_punto)
        {
            return (unos_puntos.FindAll(un_punto => un_punto.sos_mayor_a(otro_punto)));
        }
        public List<Punto> menores_a(List<Punto> unos_puntos, Punto otro_punto)
        {
            return (unos_puntos.FindAll(un_punto => !un_punto.sos_mayor_a(otro_punto)));
        }
        public float progresivo(int indice, int grado)
        {
            if (grado == 0)
            {
                return puntos[indice].get_y();
            }
            float dif_f = this.progresivo(indice+1, grado - 1) - this.progresivo(indice, grado - 1);
            float dif_x = puntos[indice + 1].get_x() - puntos[indice].get_x();
            return (dif_f / dif_x);
        }
        public float regresivo(int indice, int grado)
        {
            return this.progresivo(indice - grado, grado);
        }
        public List<float> posiciones_en_x_progresivas()
        {
            List<float> algo = new List<float>();
            foreach(Punto p in puntos){
                algo.Add(p.get_x());
            }
            
            return algo;
        }
        public List<float> pusiciones_en_x_regresivas()
        {
            List<float> algo=this.posiciones_en_x_progresivas();
            algo.Reverse();
            return (algo);
        }
        public List<float> coeficientes_progresivos()
        {
            List<float> algo = new List<float>();
            int i=0;
            for(i=0;i<=puntos.Count();i++){
                algo.Add(this.progresivo(0,i));
            }
            
            return algo;
        }
        public List<float> coeficientes_regresivos()
        {
            List<float> algo = new List<float>();
            int i=0;
            for(i=0;i<=puntos.Count();i++){
                algo.Add(this.regresivo(i,i));
            }
            
            return algo;
        }
    }
}
