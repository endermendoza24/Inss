using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MetodosDeCalculo
    {
       public int semanas, edad;
        public string nombre, apellido, mensaje;
        public bool estado, docente;
        public decimal pensionParcial, 
            
            desconocido, nose, salario, factorCrecimiento, FactorBase, pensionTotal, asignacion
            ,porcentaje;


     

        public void CalculoDePension()
        {

            if(docente == true && edad > 54 && edad <100)
            {
                edad = 60;
            }

            if (estado == true)
            {
                if (edad >= 60)
                {
                    if (semanas >= 750)
                    {
                        pensionParcial = semanas - 150;
                        desconocido = pensionParcial / 52;
                        factorCrecimiento = (desconocido * 1);
                        FactorBase = factorCrecimiento + 20;
                        pensionTotal = (FactorBase * salario) / 100;
                        if (pensionTotal < 5500)
                        {
                            pensionTotal = 5500;
                        }

                        pensionTotal = ((pensionTotal * 9) / 100) + pensionTotal;


                    }
                }
                else
                {
                    pensionTotal = 0;
                    FactorBase = 0;
                    mensaje = "La edad o semanas cotizadas están en un rango inválido";
                }
            }
            else
            {
                if (edad >= 60)
                {
                    if (semanas >= 750)
                    {
                        pensionParcial = semanas - 150;
                        desconocido = pensionParcial / 52;
                        factorCrecimiento = (desconocido * 1);
                        FactorBase = factorCrecimiento + 20;
                        pensionTotal = (FactorBase * salario) / 100;
                        if (pensionTotal < 5500)
                        {
                            pensionTotal = 5500;
                        }


                    }
                }
                else
                {
                    pensionTotal = 0;
                    FactorBase = 0;
                    mensaje = "La edad o semanas cotizadas están en un rango inválido";
                }
            }
        }


       
    }
}
