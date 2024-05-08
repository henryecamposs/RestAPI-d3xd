using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CLIENTE_CONTACTOS : ICloneable
    {

        private string mCLIENTE = "";
        private double mELIMINA = 0.0;
        private string mFAX = "";
        private int mID = 0;
        private string mNOMBRE = "";
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

        public string FAX
        {
            get
            {
                return mFAX;
            }
            set
            {
                mFAX = value;
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

        CLIENTE_CONTACTOS()
        {
        }

        CLIENTE_CONTACTOS(string CLIENTE, double ELIMINA, string FAX, int ID, string NOMBRE, string UID)
        {
            mCLIENTE = CLIENTE;
            mELIMINA = ELIMINA;
            mFAX = FAX;
            mID = ID;
            mNOMBRE = NOMBRE;
            mUID = UID;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
