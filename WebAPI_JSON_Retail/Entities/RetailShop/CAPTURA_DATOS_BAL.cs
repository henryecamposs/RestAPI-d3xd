using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAPTURA_DATOS_BAL : ICloneable
    {

        private string mCAJA = "";
        private DateTime mFECHA = new DateTime(2000, 01, 01);
        private string mID = "";
        private int mID_CDB = 0;
        private double mNRO = 0.0;

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

        public string ID
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

        public int ID_CDB
        {
            get
            {
                return mID_CDB;
            }
            set
            {
                mID_CDB = value;
            }
        }

        public Double NRO
        {
            get
            {
                return mNRO;
            }
            set
            {
                mNRO = value;
            }
        }

        CAPTURA_DATOS_BAL()
        {
        }

        CAPTURA_DATOS_BAL(string CAJA, DateTime FECHA, string ID, int ID_CDB, double NRO)
        {
            mCAJA = CAJA;
            mFECHA = FECHA;
            mID = ID;
            mID_CDB = ID_CDB;
            mNRO = NRO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
