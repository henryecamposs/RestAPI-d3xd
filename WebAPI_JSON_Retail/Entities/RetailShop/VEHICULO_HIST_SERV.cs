using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class VEHICULO_HIST_SERV : ICloneable
    {

        private DateTime mFecha = new DateTime(2000, 01, 01);
        private int mId_vehiculo_hist_ser = 0;
        private double mKilometraje = 0.0;
        private string mUid_fac = "";
        private string mUid_vehiculo = "";
        private string mUid_vehiculo_hist_se = "";

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

        public int Id_vehiculo_hist_ser
        {
            get
            {
                return mId_vehiculo_hist_ser;
            }
            set
            {
                mId_vehiculo_hist_ser = value;
            }
        }

        public Double Kilometraje
        {
            get
            {
                return mKilometraje;
            }
            set
            {
                mKilometraje = value;
            }
        }

        public string Uid_fac
        {
            get
            {
                return mUid_fac;
            }
            set
            {
                mUid_fac = value;
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

        public string Uid_vehiculo_hist_se
        {
            get
            {
                return mUid_vehiculo_hist_se;
            }
            set
            {
                mUid_vehiculo_hist_se = value;
            }
        }

        VEHICULO_HIST_SERV()
        {
        }

        VEHICULO_HIST_SERV(DateTime fecha, int id_vehiculo_hist_ser, double kilometraje, string uid_fac, string uid_vehiculo, string uid_vehiculo_hist_se)
        {
            mFecha = Fecha;
            mId_vehiculo_hist_ser = Id_vehiculo_hist_ser;
            mKilometraje = Kilometraje;
            mUid_fac = Uid_fac;
            mUid_vehiculo = Uid_vehiculo;
            mUid_vehiculo_hist_se = Uid_vehiculo_hist_se;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
