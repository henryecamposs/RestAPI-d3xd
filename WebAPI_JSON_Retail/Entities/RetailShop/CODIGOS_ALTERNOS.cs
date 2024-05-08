using System; namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CODIGOS_ALTERNOS : ICloneable
    {

        private string mALTERNO = "";
        private string mCODIGO = "";
        private string mDPTO = "";
        private int mID = 0;
        private double mSysserial = 0.0;

        public string ALTERNO
        {
            get
            {
                return mALTERNO;
            }
            set
            {
                mALTERNO = value;
            }
        }

        public string CODIGO
        {
            get
            {
                return mCODIGO;
            }
            set
            {
                mCODIGO = value;
            }
        }

        public string DPTO
        {
            get
            {
                return mDPTO;
            }
            set
            {
                mDPTO = value;
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

        public Double Sysserial
        {
            get
            {
                return mSysserial;
            }
            set
            {
                mSysserial = value;
            }
        }

        CODIGOS_ALTERNOS()
        {
        }

        CODIGOS_ALTERNOS(string ALTERNO, string CODIGO, string DPTO, int ID, double sysserial)
        {
            mALTERNO = ALTERNO;
            mCODIGO = CODIGO;
            mDPTO = DPTO;
            mID = ID;
            mSysserial = Sysserial;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
