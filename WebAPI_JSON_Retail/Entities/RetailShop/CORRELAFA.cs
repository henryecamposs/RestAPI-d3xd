using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CORRELAFA : ICloneable
    {

        private int mID = 0;
        private string mVALOR = "";

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

        CORRELAFA()
        {
        }

        CORRELAFA(int ID, string VALOR)
        {
            mID = ID;
            mVALOR = VALOR;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
