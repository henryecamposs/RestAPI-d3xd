using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TIPO_VEHICULO : ICloneable
    {

        private string mDescr = "";
        private int mId_tipo_vehi = 0;

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

        public int Id_tipo_vehi
        {
            get
            {
                return mId_tipo_vehi;
            }
            set
            {
                mId_tipo_vehi = value;
            }
        }

        TIPO_VEHICULO()
        {
        }

        TIPO_VEHICULO(string descr, int id_tipo_vehi)
        {
            mDescr = Descr;
            mId_tipo_vehi = Id_tipo_vehi;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
