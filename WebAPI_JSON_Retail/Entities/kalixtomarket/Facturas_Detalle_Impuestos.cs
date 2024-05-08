using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Facturas_Detalle_Impuestos : ICloneable
    {

        private int mID = 0;
        private int mId_FacturaDetalle = 0;
        private int mId_TipoImpuesto = 0;
        private double mMontoTotalTasa = 0.0;
        private double mMontoTotalBase = 0.0;

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

        public int Id_TipoImpuesto
        {
            get
            {
                return mId_TipoImpuesto;
            }
            set
            {
                mId_TipoImpuesto = value;
            }
        }

        public Double MontoTotalTasa
        {
            get
            {
                return mMontoTotalTasa;
            }
            set
            {
                mMontoTotalTasa = value;
            }
        }

        public Double MontoTotalBase
        {
            get
            {
                return mMontoTotalBase;
            }
            set
            {
                mMontoTotalBase = value;
            }
        }

        Facturas_Detalle_Impuestos()
        {
        }

        Facturas_Detalle_Impuestos(int ID, int Id_FacturaDetalle, int Id_TipoImpuesto, double MontoTotalTasa, double MontoTotalBase)
        {
            mID = ID;
            mId_FacturaDetalle = Id_FacturaDetalle;
            mId_TipoImpuesto = Id_TipoImpuesto;
            mMontoTotalTasa = MontoTotalTasa;
            mMontoTotalBase = MontoTotalBase;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
