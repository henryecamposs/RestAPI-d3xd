using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ESTACION_PLANTILLA_CLIENTE : ICloneable
    {

        private double mCAMPO = 0.0;
        private string mDESCR = "";
        private double mFILTRO = 0.0;
        private int mID = 0;
        private double mID_CAMPO = 0.0;
        private string mID_ESTA = "";
        private double mID_TABLA = 0.0;
        private double mKEY = 0.0;
        private double mKEYDES = 0.0;

        public Double CAMPO
        {
            get
            {
                return mCAMPO;
            }
            set
            {
                mCAMPO = value;
            }
        }

        public string DESCR
        {
            get
            {
                return mDESCR;
            }
            set
            {
                mDESCR = value;
            }
        }

        public Double FILTRO
        {
            get
            {
                return mFILTRO;
            }
            set
            {
                mFILTRO = value;
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

        public Double ID_CAMPO
        {
            get
            {
                return mID_CAMPO;
            }
            set
            {
                mID_CAMPO = value;
            }
        }

        public string ID_ESTA
        {
            get
            {
                return mID_ESTA;
            }
            set
            {
                mID_ESTA = value;
            }
        }

        public Double ID_TABLA
        {
            get
            {
                return mID_TABLA;
            }
            set
            {
                mID_TABLA = value;
            }
        }

        public Double KEY
        {
            get
            {
                return mKEY;
            }
            set
            {
                mKEY = value;
            }
        }

        public Double KEYDES
        {
            get
            {
                return mKEYDES;
            }
            set
            {
                mKEYDES = value;
            }
        }

        ESTACION_PLANTILLA_CLIENTE()
        {
        }

        ESTACION_PLANTILLA_CLIENTE(double CAMPO, string DESCR, double FILTRO, int ID, double ID_CAMPO, string ID_ESTA, double ID_TABLA, double KEY, double KEYDES)
        {
            mCAMPO = CAMPO;
            mDESCR = DESCR;
            mFILTRO = FILTRO;
            mID = ID;
            mID_CAMPO = ID_CAMPO;
            mID_ESTA = ID_ESTA;
            mID_TABLA = ID_TABLA;
            mKEY = KEY;
            mKEYDES = KEYDES;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
