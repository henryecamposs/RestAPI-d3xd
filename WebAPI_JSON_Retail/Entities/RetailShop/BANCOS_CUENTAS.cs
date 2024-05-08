using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class BANCOS_CUENTAS : ICloneable
    {

        private int mID = 0;
        private int mID_BANCO = 0;
        private double mINACTIVO = 0.0;
        private string mNRO = "";

        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public int ID_BANCO
        {
            get
            {
                return mID_BANCO;
            }
            set
            {
                mID_BANCO = value;
            }
        }

        public Double INACTIVO
        {
            get
            {
                return mINACTIVO;
            }
            set
            {
                mINACTIVO = value;
            }
        }

        public string NRO
        {
            get
            {
                return mNRO;
            }
            set
            {
                mNRO = value;
            }
        }

        BANCOS_CUENTAS()
        {
        }

        BANCOS_CUENTAS(int ID, int ID_BANCO, double INACTIVO, string NRO)
        {
            mID = ID;
            mID_BANCO = ID_BANCO;
            mINACTIVO = INACTIVO;
            mNRO = NRO;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
