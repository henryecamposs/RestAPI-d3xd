using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class SYS_LOCK : ICloneable
    {

        private string mDESCRIPCION = "";
        private string mESTACION = "";
        private DateTime mHORA = new DateTime(2000, 01, 01);
        private int mID = 0;
        private string mIDREGIS = "";
        private int mIDTABLA = 0;
        private string mIDUSER = "";
        private string mNAME_TABLE = "";
        private string mId_conn_hand = "";
        private int mIdconn = 0;

        public string DESCRIPCION
        {
            get
            {
                return mDESCRIPCION;
            }
            set
            {
                mDESCRIPCION = value;
            }
        }

        public string ESTACION
        {
            get
            {
                return mESTACION;
            }
            set
            {
                mESTACION = value;
            }
        }

        public DateTime HORA
        {
            get
            {
                return mHORA;
            }
            set
            {
                mHORA = value;
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

        public string IDREGIS
        {
            get
            {
                return mIDREGIS;
            }
            set
            {
                mIDREGIS = value;
            }
        }

        public int IDTABLA
        {
            get
            {
                return mIDTABLA;
            }
            set
            {
                mIDTABLA = value;
            }
        }

        public string IDUSER
        {
            get
            {
                return mIDUSER;
            }
            set
            {
                mIDUSER = value;
            }
        }

        public string NAME_TABLE
        {
            get
            {
                return mNAME_TABLE;
            }
            set
            {
                mNAME_TABLE = value;
            }
        }

        public string Id_conn_hand
        {
            get
            {
                return mId_conn_hand;
            }
            set
            {
                mId_conn_hand = value;
            }
        }

        public int Idconn
        {
            get
            {
                return mIdconn;
            }
            set
            {
                mIdconn = value;
            }
        }

        SYS_LOCK()
        {
        }

        SYS_LOCK(string DESCRIPCION, string ESTACION, DateTime HORA, int ID, string IDREGIS, int IDTABLA, string IDUSER, string NAME_TABLE, string id_conn_hand, int idconn)
        {
            mDESCRIPCION = DESCRIPCION;
            mESTACION = ESTACION;
            mHORA = HORA;
            mID = ID;
            mIDREGIS = IDREGIS;
            mIDTABLA = IDTABLA;
            mIDUSER = IDUSER;
            mNAME_TABLE = NAME_TABLE;
            mId_conn_hand = Id_conn_hand;
            mIdconn = Idconn;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
