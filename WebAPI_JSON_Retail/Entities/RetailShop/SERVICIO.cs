using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SERVICIO : ICloneable
    {

        private string mDescr = "";
        private int mId_servicio = 0;

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

        public int Id_servicio
        {
            get
            {
                return mId_servicio;
            }
            set
            {
                mId_servicio = value;
            }
        }

        SERVICIO()
        {
        }

        SERVICIO(string descr, int id_servicio)
        {
            mDescr = Descr;
            mId_servicio = Id_servicio;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
