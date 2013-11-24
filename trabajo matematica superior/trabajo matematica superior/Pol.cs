using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Pol
    {
        private List<float> puntos;
        private List<float> coeficientes;
        public List<float> get_puntos(){
            return puntos;
        }
        public List<float> get_coeficientes(){
            return coeficientes;
        }
        public void set_puntos(List<float> pts){
            puntos=pts;
        }
        public void set_coeficientes(List<float> coefs){
            coeficientes=coefs;
        }
        public Pol(){
            puntos=new List<float>();
            coeficientes=new List<float>();
        }
        public Pol(List<float> nvos_pts, List<float> coefs){
            puntos=nvos_pts;
            coeficientes=coefs;
        }
        public String construir_polinomio()
        {
            String polinomio = "p(x) = ";
            int i;
            for (i = 0; i < coeficientes.Count; i++)
            {
                if(coeficientes[i]!=0){
                    polinomio = polinomio + coeficientes[i] + this.parte_de_x(i)+ ' + ';
                }
            }
            return "";
        }
        public String parte_de_x(int termino){
            int i;
            String parte_x="";
            if(termino!=0)
            {
                parte_x=parte_x+this.parte_de_x(termino-1)+this.el_termino(termino);

            }

            return parte_x;
        }
        public String el_termino(int termino){
            if(puntos[termino-1]<0){
                return "(x-("+puntos[termino-1].ToString()+"))";
            }
            if(puntos[termino-1]==0){
                return "x";
            }
            if(puntos[termino-1]>0){
                return "(x-"+puntos[termino-1].ToString()+")";
            }
            return "";
        }
        public float evaluar_polinomio (float lugar){
            float cuenta=0;
            int i;
            for (i = 0; i < coeficientes.Count; i++){
                cuenta+=coeficientes[i]*this.evaluar_en(lugar,i);

            }


            return cuenta;
        }
        public float evaluar_en(float punto, int posicion){
            if(posicion==0){
                return 1;
            }
            return puntos.Take(posicion).Sum(numero => posicion - numero);

        }
    }
}
