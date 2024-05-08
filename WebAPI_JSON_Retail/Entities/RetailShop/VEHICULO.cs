using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class VEHICULO : ICloneable
    {

        private int mId_grupo_vehi = 0;
        private int mId_tipo_vehi = 0;
        private int mId_vehiculo = 0;
        private string mObservacion = "";
        private string mPlaca = "";
        private string mUid_vehiculo = "";

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

        public int Id_vehiculo
        {
            get
            {
                return mId_vehiculo;
            }
            set
            {
                mId_vehiculo = value;
            }
        }

        public string Observacion
        {
            get
            {
                return mObservacion;
            }
            set
            {
                mObservacion = value;
            }
        }

        public string Placa
        {
            get
            {
                return mPlaca;
            }
            set
            {
                mPlaca = value;
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

        VEHICULO()
        {
        }

        VEHICULO(int id_grupo_vehi, int id_tipo_vehi, int id_vehiculo, string observacion, string placa, string uid_vehiculo)
        {
            mId_grupo_vehi = Id_grupo_vehi;
            mId_tipo_vehi = Id_tipo_vehi;
            mId_vehiculo = Id_vehiculo;
            mObservacion = Observacion;
            mPlaca = Placa;
            mUid_vehiculo = Uid_vehiculo;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
