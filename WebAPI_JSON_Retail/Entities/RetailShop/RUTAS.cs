using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RUTAS : ICloneable
    {

        private string mCodigo = "";
        private string mDescr = "";
        private int mId = 0;

        public string Codigo
        {
            get
            {
                return mCodigo;
            }
            set
            {
                mCodigo = value;
            }
        }

        public string Descr
        {
            get
            {
                return mDescr;
            }
            set
            {
                mDescr = value;
            }
        }

        public int Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }

        RUTAS()
        {
        }

        RUTAS(string codigo, string descr, int id)
        {
            mCodigo = Codigo;
            mDescr = Descr;
            mId = Id;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
