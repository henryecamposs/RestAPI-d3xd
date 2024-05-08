using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wResAPI_d3xd.Entities
{
    public class iva_verificador
    {
     
            public int tipo; public double valor; public string nombre; public string nomencla;

            public iva_verificador()
            {
                tipo = 0; valor = 0.0; nombre = null; nomencla = null;
            }

            public iva_verificador(string nombre, int tipo, double valor, string nomencla)
            {
                this.nombre = nombre;
                this.tipo = tipo;
                this.valor = valor;
                this.nomencla = nomencla;
            }
         
    }
}