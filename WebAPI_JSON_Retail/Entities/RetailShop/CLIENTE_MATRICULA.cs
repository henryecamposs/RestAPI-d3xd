using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTE_MATRICULA : ICloneable
    {

        private string mCLIENTE = "";
        private double mELIMINA = 0.0;
        private int mID = 0;
        private string mMATRICULA = "";
        private double mTIPO = 0.0;
        private string mUID = "";

        public string CLIENTE
        {
            get
            {
                return mCLIENTE;
            }
            set
            {
                mCLIENTE = value;
            }
        }

        public Double ELIMINA
        {
            get
            {
                return mELIMINA;
            }
            set
            {
                mELIMINA = value;
            }
        }

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

        public string MATRICULA
        {
            get
            {
                return mMATRICULA;
            }
            set
            {
                mMATRICULA = value;
            }
        }

        public Double TIPO
        {
            get
            {
                return mTIPO;
            }
            set
            {
                mTIPO = value;
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

        CLIENTE_MATRICULA()
        {
        }

        CLIENTE_MATRICULA(string CLIENTE, double ELIMINA, int ID, string MATRICULA, double TIPO, string UID)
        {
            mCLIENTE = CLIENTE;
            mELIMINA = ELIMINA;
            mID = ID;
            mMATRICULA = MATRICULA;
            mTIPO = TIPO;
            mUID = UID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
