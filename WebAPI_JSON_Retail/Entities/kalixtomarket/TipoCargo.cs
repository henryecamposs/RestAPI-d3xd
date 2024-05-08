using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class TipoCargo : ICloneable
    {

        private int mID = 0;
        private string mDescripcion = "";

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

        TipoCargo()
        {
        }

        TipoCargo(int ID, string Descripcion)
        {
            mID = ID;
            mDescripcion = Descripcion;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
