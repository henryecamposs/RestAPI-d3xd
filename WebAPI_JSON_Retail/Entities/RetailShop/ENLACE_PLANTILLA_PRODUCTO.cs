using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class ENLACE_PLANTILLA_PRODUCTO : ICloneable
    {

        private string mCODIGO = "";
        private int mID = 0;
        private double mID_PLANTI = 0.0;

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

        public Double ID_PLANTI
        {
            get
            {
                return mID_PLANTI;
            }
            set
            {
                mID_PLANTI = value;
            }
        }

        ENLACE_PLANTILLA_PRODUCTO()
        {
        }

        ENLACE_PLANTILLA_PRODUCTO(string CODIGO, int ID, double ID_PLANTI)
        {
            mCODIGO = CODIGO;
            mID = ID;
            mID_PLANTI = ID_PLANTI;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
