using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class GRUPO_VEHICULO : ICloneable
    {

        private string mDescr = "";
        private int mId_grupo_vehi = 0;

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

        public int Id_grupo_vehi
        {
            get
            {
                return mId_grupo_vehi;
            }
            set
            {
                mId_grupo_vehi = value;
            }
        }

        GRUPO_VEHICULO()
        {
        }

        GRUPO_VEHICULO(string descr, int id_grupo_vehi)
        {
            mDescr = Descr;
            mId_grupo_vehi = Id_grupo_vehi;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
