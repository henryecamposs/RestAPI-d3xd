using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTES_APLICA_SALDO : ICloneable
    {

        private string mGUID_DOC = "";
        private string mGUID_REFE = "";
        private int mID = 0;
        private double mMONTO = 0.0;
        private int mNRO = 0;
        private int mTIPO_DOC = 0;

        public string GUID_DOC
        {
            get
            {
                return mGUID_DOC;
            }
            set
            {
                mGUID_DOC = value;
            }
        }

        public string GUID_REFE
        {
            get
            {
                return mGUID_REFE;
            }
            set
            {
                mGUID_REFE = value;
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

        public Double MONTO
        {
            get
            {
                return mMONTO;
            }
            set
            {
                mMONTO = value;
            }
        }

        public int NRO
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

        public int TIPO_DOC
        {
            get
            {
                return mTIPO_DOC;
            }
            set
            {
                mTIPO_DOC = value;
            }
        }

        CLIENTES_APLICA_SALDO()
        {
        }

        CLIENTES_APLICA_SALDO(string GUID_DOC, string GUID_REFE, int ID, double MONTO, int NRO, int TIPO_DOC)
        {
            mGUID_DOC = GUID_DOC;
            mGUID_REFE = GUID_REFE;
            mID = ID;
            mMONTO = MONTO;
            mNRO = NRO;
            mTIPO_DOC = TIPO_DOC;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
