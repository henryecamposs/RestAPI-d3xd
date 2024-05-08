using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class BEMA_IMP : ICloneable
    {

        private string mCODIGO = "";
        private int mID = 0;
        private string mVALOR = "";

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

        public string VALOR
        {
            get
            {
                return mVALOR;
            }
            set
            {
                mVALOR = value;
            }
        }

        BEMA_IMP()
        {
        }

        BEMA_IMP(string CODIGO, int ID, string VALOR)
        {
            mCODIGO = CODIGO;
            mID = ID;
            mVALOR = VALOR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
