using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_Detalle_Descuentos : ICloneable
    {

        private int mID = 0;
        private int mId_FacturaDetalle = 0;
        private int mId_TipoDescuento = 0;
        private double mMontoTasa = 0.0;

        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public int Id_FacturaDetalle
        {
            get
            {
                return mId_FacturaDetalle;
            }
            set
            {
                mId_FacturaDetalle = value;
            }
        }

        public int Id_TipoDescuento
        {
            get
            {
                return mId_TipoDescuento;
            }
            set
            {
                mId_TipoDescuento = value;
            }
        }

        public Double MontoTasa
        {
            get
            {
                return mMontoTasa;
            }
            set
            {
                mMontoTasa = value;
            }
        }

        Facturas_Detalle_Descuentos()
        {
        }

        Facturas_Detalle_Descuentos(int ID, int Id_FacturaDetalle, int Id_TipoDescuento, double MontoTasa)
        {
            mID = ID;
            mId_FacturaDetalle = Id_FacturaDetalle;
            mId_TipoDescuento = Id_TipoDescuento;
            mMontoTasa = MontoTasa;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
