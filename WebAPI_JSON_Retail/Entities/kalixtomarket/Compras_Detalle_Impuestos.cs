using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Compras_Detalle_Impuestos : ICloneable
    {

        private int mID = 0;
        private int mID_COMPRAS_DETALLE = 0;
        private int mID_IMPUESTO = 0;
        private double mMONTOTASA_IVA = 0.0;
        private double mMONTOBASE = 0.0;

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

        public int ID_COMPRAS_DETALLE
        {
            get
            {
                return mID_COMPRAS_DETALLE;
            }
            set
            {
                mID_COMPRAS_DETALLE = value;
            }
        }

        public int ID_IMPUESTO
        {
            get
            {
                return mID_IMPUESTO;
            }
            set
            {
                mID_IMPUESTO = value;
            }
        }

        public Double MONTOTASA_IVA
        {
            get
            {
                return mMONTOTASA_IVA;
            }
            set
            {
                mMONTOTASA_IVA = value;
            }
        }

        public Double MONTOBASE
        {
            get
            {
                return mMONTOBASE;
            }
            set
            {
                mMONTOBASE = value;
            }
        }

        Compras_Detalle_Impuestos()
        {
        }

        Compras_Detalle_Impuestos(int ID, int ID_COMPRAS_DETALLE, int ID_IMPUESTO, double MONTOTASA_IVA, double MONTOBASE)
        {
            mID = ID;
            mID_COMPRAS_DETALLE = ID_COMPRAS_DETALLE;
            mID_IMPUESTO = ID_IMPUESTO;
            mMONTOTASA_IVA = MONTOTASA_IVA;
            mMONTOBASE = MONTOBASE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
