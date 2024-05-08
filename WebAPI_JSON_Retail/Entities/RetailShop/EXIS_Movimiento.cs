using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wResAPI_d3xd.Entities.RetailShop
{
    public enum enuTipoMovimiento
    {
        Ninguno,
        Entrada,
        Salida 
    }
    public class EXIS_Movimiento
    {
        enuTipoMovimiento enTipoMovimiento;

        public EXIS_Movimiento(enuTipoMovimiento enTipoMovimiento, string codigoAlmacen, string codigoEmpaque, string codigounidad, double cantidadEmpaque, double cantidadUnidades, double totalUnidades, INVEN inven)
        {
            this.enTipoMovimiento = enTipoMovimiento;
            CodigoAlmacen = codigoAlmacen;
            CodigoEmpaque = codigoEmpaque;
            Codigounidad = codigounidad;
            CantidadEmpaque = cantidadEmpaque;
            CantidadUnidades = cantidadUnidades;
            TotalUnidades = totalUnidades;
            Inven = inven;
        }

        public string CodigoAlmacen { get; set; }
        public string CodigoEmpaque { get; set; }
        public string Codigounidad { get; set; }
        public double CantidadEmpaque { get; set; }
        public double CantidadUnidades { get; set; }
        public double TotalUnidades { get; set; }
        public INVEN Inven { get; set; }
        




    }
}