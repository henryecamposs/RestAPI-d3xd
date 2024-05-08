using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SERVICIOS_TIPVEHI_ITEMS_AUX : ICloneable
    {

        private int mId_inven = 0;
        private int mId_serv_tipvehi_itau = 0;
        private int mId_serv_tipvehi_item = 0;

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

        public int Id_serv_tipvehi_itau
        {
            get
            {
                return mId_serv_tipvehi_itau;
            }
            set
            {
                mId_serv_tipvehi_itau = value;
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

        SERVICIOS_TIPVEHI_ITEMS_AUX()
        {
        }

        SERVICIOS_TIPVEHI_ITEMS_AUX(int id_inven, int id_serv_tipvehi_itau, int id_serv_tipvehi_item)
        {
            mId_inven = Id_inven;
            mId_serv_tipvehi_itau = Id_serv_tipvehi_itau;
            mId_serv_tipvehi_item = Id_serv_tipvehi_item;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
