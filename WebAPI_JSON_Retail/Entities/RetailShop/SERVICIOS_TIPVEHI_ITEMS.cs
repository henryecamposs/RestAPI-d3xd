using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SERVICIOS_TIPVEHI_ITEMS : ICloneable
    {

        private double mCantidad = 0.0;
        private int mId_inven = 0;
        private int mId_serv_tipo_vehi = 0;
        private int mId_serv_tipvehi_item = 0;

        public Double Cantidad
        {
            get
            {
                return mCantidad;
            }
            set
            {
                mCantidad = value;
            }
        }

        public int Id_inven
        {
            get
            {
                return mId_inven;
            }
            set
            {
                mId_inven = value;
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

        public int Id_serv_tipvehi_item
        {
            get
            {
                return mId_serv_tipvehi_item;
            }
            set
            {
                mId_serv_tipvehi_item = value;
            }
        }

        SERVICIOS_TIPVEHI_ITEMS()
        {
        }

        SERVICIOS_TIPVEHI_ITEMS(double cantidad, int id_inven, int id_serv_tipo_vehi, int id_serv_tipvehi_item)
        {
            mCantidad = Cantidad;
            mId_inven = Id_inven;
            mId_serv_tipo_vehi = Id_serv_tipo_vehi;
            mId_serv_tipvehi_item = Id_serv_tipvehi_item;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
