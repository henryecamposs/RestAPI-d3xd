using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PAGINA : ICloneable
    {

        private int mCodipagi = 0;
        private string mDescpagi = "";

        public int Codipagi
        {
            get
            {
                return mCodipagi;
            }
            set
            {
                mCodipagi = value;
            }
        }

        public string Descpagi
        {
            get
            {
                return mDescpagi;
            }
            set
            {
                mDescpagi = value;
            }
        }

        PAGINA()
        {
        }

        PAGINA(int codipagi, string descpagi)
        {
            mCodipagi = Codipagi;
            mDescpagi = Descpagi;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
