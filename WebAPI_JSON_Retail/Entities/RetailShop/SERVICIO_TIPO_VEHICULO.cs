using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SERVICIO_TIPO_VEHICULO : ICloneable
    {

        private int mId_grupo_vehi = 0;
        private int mId_serv_tipo_vehi = 0;
        private int mId_servicio = 0;
        private int mId_tipo_vehi = 0;

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

        SERVICIO_TIPO_VEHICULO()
        {
        }

        SERVICIO_TIPO_VEHICULO(int id_grupo_vehi, int id_serv_tipo_vehi, int id_servicio, int id_tipo_vehi)
        {
            mId_grupo_vehi = Id_grupo_vehi;
            mId_serv_tipo_vehi = Id_serv_tipo_vehi;
            mId_servicio = Id_servicio;
            mId_tipo_vehi = Id_tipo_vehi;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
