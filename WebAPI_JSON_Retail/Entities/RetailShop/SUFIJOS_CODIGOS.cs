using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SUFIJOS_CODIGOS : ICloneable
    {

        private string mDescripcion = "";
        private int mId = 0;
        private double mSel = 0.0;
        private string mSufijo = "";

        public string Descripcion
        {
            get
            {
                return mDescripcion;
            }
            set
            {
                mDescripcion = value;
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

        public Double Sel
        {
            get
            {
                return mSel;
            }
            set
            {
                mSel = value;
            }
        }

        public string Sufijo
        {
            get
            {
                return mSufijo;
            }
            set
            {
                mSufijo = value;
            }
        }

        SUFIJOS_CODIGOS()
        {
        }

        SUFIJOS_CODIGOS(string Descripcion, int id, double sel, string sufijo)
        {
            mDescripcion = Descripcion;
            mId = Id;
            mSel = Sel;
            mSufijo = Sufijo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
