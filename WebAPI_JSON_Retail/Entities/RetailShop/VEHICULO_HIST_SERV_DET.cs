using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class VEHICULO_HIST_SERV_DET : ICloneable
    {

        private int mId_serv_tipo_vehi = 0;
        private int mId_vehiculo_hise_det = 0;
        private string mUid_vehiculo_hist_se = "";

        public int Id_serv_tipo_vehi
        {
            get
            {
                return mId_serv_tipo_vehi;
            }
            set
            {
                mId_serv_tipo_vehi = value;
            }
        }

        public int Id_vehiculo_hise_det
        {
            get
            {
                return mId_vehiculo_hise_det;
            }
            set
            {
                mId_vehiculo_hise_det = value;
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

        VEHICULO_HIST_SERV_DET()
        {
        }

        VEHICULO_HIST_SERV_DET(int id_serv_tipo_vehi, int id_vehiculo_hise_det, string uid_vehiculo_hist_se)
        {
            mId_serv_tipo_vehi = Id_serv_tipo_vehi;
            mId_vehiculo_hise_det = Id_vehiculo_hise_det;
            mUid_vehiculo_hist_se = Uid_vehiculo_hist_se;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
