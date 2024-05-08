using System; namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Compras_Impuestos : ICloneable
    {

        private int mID = 0;
        private int mID_COMPRA = 0;
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

        public int ID_COMPRA
        {
            get
            {
                return mID_COMPRA;
            }
            set
            {
                mID_COMPRA = value;
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

        Compras_Impuestos()
        {
        }

        Compras_Impuestos(int ID, int ID_COMPRA, int ID_IMPUESTO, double MONTOTASA_IVA, double MONTOBASE)
        {
            mID = ID;
            mID_COMPRA = ID_COMPRA;
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
