using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RELACION_DEVOLU : ICloneable
    {

        private double mANULACION = 0.0;
        private string mCAJA = "";
        private double mFACTURA = 0.0;
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mFECHAC = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mMONTOA = 0.0;
        private double mMONTOF = 0.0;

        public Double ANULACION
        {
            get
            {
                return mANULACION;
            }
            set
            {
                mANULACION = value;
            }
        }

        public string CAJA
        {
            get
            {
                return mCAJA;
            }
            set
            {
                mCAJA = value;
            }
        }

        public Double FACTURA
        {
            get
            {
                return mFACTURA;
            }
            set
            {
                mFACTURA = value;
            }
        }

        public DateTime FECHA
        {
            get
            {
                return mFECHA;
            }
            set
            {
                mFECHA = value;
            }
        }

        public string FECHAC
        {
            get
            {
                return mFECHAC;
            }
            set
            {
                mFECHAC = value;
            }
        }

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

        public int IDSUC
        {
            get
            {
                return mIDSUC;
            }
            set
            {
                mIDSUC = value;
            }
        }

        public Double MONTOA
        {
            get
            {
                return mMONTOA;
            }
            set
            {
                mMONTOA = value;
            }
        }

        public Double MONTOF
        {
            get
            {
                return mMONTOF;
            }
            set
            {
                mMONTOF = value;
            }
        }

        RELACION_DEVOLU()
        {
        }

        RELACION_DEVOLU(double ANULACION, string CAJA, double FACTURA, DateTime FECHA, string FECHAC, int ID, int IDSUC, double MONTOA, double MONTOF)
        {
            mANULACION = ANULACION;
            mCAJA = CAJA;
            mFACTURA = FACTURA;
            mFECHA = FECHA;
            mFECHAC = FECHAC;
            mID = ID;
            mIDSUC = IDSUC;
            mMONTOA = MONTOA;
            mMONTOF = MONTOF;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
