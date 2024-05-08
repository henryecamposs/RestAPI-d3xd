using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wResAPI_d3xd.Entities.RetailShop
{
    public class COMPRAS_ajuste
    {
        enuTipoMovimiento enTipoMovimiento;

        public COMPRAS_ajuste(enuTipoMovimiento enTipoMovimiento, string codigoAlmacen, string codigoEmpaque, string codigounidad, double cantidadEmpaque, double cantidadUnidades, double totalUnidades, INVEN inven, int tipoIVA, double costoUnitario, bool esDescuentoGralPorcentaje, double descuentoGral, double descuento1, double descuento2, double descuento3, double descuentoprontoPago, bool esImpuestoAdicPorcentaje, double impuestoAdicional)
        {
            this.enTipoMovimiento = enTipoMovimiento;
            CodigoAlmacen = codigoAlmacen;
            CodigoEmpaque = codigoEmpaque;
            Codigounidad = codigounidad;
            CantidadEmpaque = cantidadEmpaque;
            CantidadUnidades = cantidadUnidades;
            TotalUnidades = totalUnidades;
            Inven = inven;
            TipoIVA = tipoIVA;
            CostoUnitario = costoUnitario;
            this.esDescuentoGralPorcentaje = esDescuentoGralPorcentaje;
            DescuentoGral = descuentoGral;
            Descuento1 = descuento1;
            Descuento2 = descuento2;
            Descuento3 = descuento3;
            DescuentoprontoPago = descuentoprontoPago;
            this.esImpuestoAdicPorcentaje = esImpuestoAdicPorcentaje;
            ImpuestoAdicional = impuestoAdicional;
        }

        public string CodigoAlmacen { get; set; }
        public string CodigoEmpaque { get; set; }
        public string Codigounidad { get; set; }
        public double CantidadEmpaque { get; set; }
        public double CantidadUnidades { get; set; }
        public double TotalUnidades { get; set; }
        public INVEN Inven { get; set; }
        public int TipoIVA { get; set; }
        public double CostoUnitario { get; set; }
        public bool esDescuentoGralPorcentaje { get; set; }
        public double DescuentoGral { get; set; }
        public double Descuento1 { get; set; }
        public double Descuento2 { get; set; }
        public double Descuento3 { get; set; }
        public double DescuentoprontoPago { get; set; }
        public bool esImpuestoAdicPorcentaje { get; set; }
        public double ImpuestoAdicional { get; set; }


    }
}