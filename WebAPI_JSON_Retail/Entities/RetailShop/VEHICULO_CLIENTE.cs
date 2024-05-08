using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class VEHICULO_CLIENTE : ICloneable
    {

        private DateTime mFecha = new DateTime(2000, 01, 01);
        private int mId_vehi_clie = 0;
        private string mRif = "";
        private string mUid_vehiculo = "";

        public DateTime Fecha
        {
            get
            {
                return mFecha;
            }
            set
            {
                mFecha = value;
            }
        }

        public int Id_vehi_clie
        {
            get
            {
                return mId_vehi_clie;
            }
            set
            {
                mId_vehi_clie = value;
            }
        }

        public string Rif
        {
            get
            {
                return mRif;
            }
            set
            {
                mRif = value;
            }
        }

        public string Uid_vehiculo
        {
            get
            {
                return mUid_vehiculo;
            }
            set
            {
                mUid_vehiculo = value;
            }
        }

        VEHICULO_CLIENTE()
        {
        }

        VEHICULO_CLIENTE(DateTime fecha, int id_vehi_clie, string rif, string uid_vehiculo)
        {
            mFecha = Fecha;
            mId_vehi_clie = Id_vehi_clie;
            mRif = Rif;
            mUid_vehiculo = Uid_vehiculo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
