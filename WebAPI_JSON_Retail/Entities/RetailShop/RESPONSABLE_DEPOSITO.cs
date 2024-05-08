using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class RESPONSABLE_DEPOSITO : ICloneable
    {

        private int mID = 0;
        private double mINACTIVO = 0.0;
        private string mNOMBRE = "";
        private double mPUNTO_BANCA = 0.0;
        private string mUID = "";

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

        public string NOMBRE
        {
            get
            {
                return mNOMBRE;
            }
            set
            {
                mNOMBRE = value;
            }
        }

        public Double PUNTO_BANCA
        {
            get
            {
                return mPUNTO_BANCA;
            }
            set
            {
                mPUNTO_BANCA = value;
            }
        }

        public string UID
        {
            get
            {
                return mUID;
            }
            set
            {
                mUID = value;
            }
        }

        RESPONSABLE_DEPOSITO()
        {
        }

        RESPONSABLE_DEPOSITO(int ID, double INACTIVO, string NOMBRE, double PUNTO_BANCA, string UID)
        {
            mID = ID;
            mINACTIVO = INACTIVO;
            mNOMBRE = NOMBRE;
            mPUNTO_BANCA = PUNTO_BANCA;
            mUID = UID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
