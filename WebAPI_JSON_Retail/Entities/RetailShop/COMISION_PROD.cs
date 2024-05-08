using System; namespace wResAPI_d3xd.Entities.RetailShop
{
    public class COMISION_PROD : ICloneable
    {

        private double mCOMICOB = 0.0;
        private double mCOMIVEN = 0.0;
        private int mID = 0;
        private string mPRODUCTO = "";
        private string mVENDEDOR = "";

        public Double COMICOB
        {
            get
            {
                return mCOMICOB;
            }
            set
            {
                mCOMICOB = value;
            }
        }

        public Double COMIVEN
        {
            get
            {
                return mCOMIVEN;
            }
            set
            {
                mCOMIVEN = value;
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

        public string PRODUCTO
        {
            get
            {
                return mPRODUCTO;
            }
            set
            {
                mPRODUCTO = value;
            }
        }

        public string VENDEDOR
        {
            get
            {
                return mVENDEDOR;
            }
            set
            {
                mVENDEDOR = value;
            }
        }

        COMISION_PROD()
        {
        }

        COMISION_PROD(double COMICOB, double COMIVEN, int ID, string PRODUCTO, string VENDEDOR)
        {
            mCOMICOB = COMICOB;
            mCOMIVEN = COMIVEN;
            mID = ID;
            mPRODUCTO = PRODUCTO;
            mVENDEDOR = VENDEDOR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
