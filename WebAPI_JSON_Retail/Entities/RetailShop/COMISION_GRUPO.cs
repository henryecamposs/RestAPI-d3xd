using System; namespace wResAPI_d3xd.Entities.RetailShop
{
    public class COMISION_GRUPO : ICloneable
    {

        private double mCOMICOB = 0.0;
        private double mCOMIVEN = 0.0;
        private string mGRUPO = "";
        private int mID = 0;
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

        public string GRUPO
        {
            get
            {
                return mGRUPO;
            }
            set
            {
                mGRUPO = value;
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

        COMISION_GRUPO()
        {
        }

        COMISION_GRUPO(double COMICOB, double COMIVEN, string GRUPO, int ID, string VENDEDOR)
        {
            mCOMICOB = COMICOB;
            mCOMIVEN = COMIVEN;
            mGRUPO = GRUPO;
            mID = ID;
            mVENDEDOR = VENDEDOR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
