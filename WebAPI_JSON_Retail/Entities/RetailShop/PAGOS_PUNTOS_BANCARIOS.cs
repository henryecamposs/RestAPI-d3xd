using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class PAGOS_PUNTOS_BANCARIOS : ICloneable
    {

        private string mDESCR = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private int mID_BANCO = 0;
        private double mINACTIVO = 0.0;
        private string mNROCUENTA = "";
        private string mUID_RESPON = "";
        private string mCtacomi = "";
        private string mCtacomotro = "";
        private string mCtacon = "";
        private string mCtaislr = "";

        public string DESCR
        {
            get
            {
                return mDESCR;
            }
            set
            {
                mDESCR = value;
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

        public int IDSUC
        {
            get
            {
                return mIDSUC;
            }
            set
            {
                mIDSUC = value;
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

        public string NROCUENTA
        {
            get
            {
                return mNROCUENTA;
            }
            set
            {
                mNROCUENTA = value;
            }
        }

        public string UID_RESPON
        {
            get
            {
                return mUID_RESPON;
            }
            set
            {
                mUID_RESPON = value;
            }
        }

        public string Ctacomi
        {
            get
            {
                return mCtacomi;
            }
            set
            {
                mCtacomi = value;
            }
        }

        public string Ctacomotro
        {
            get
            {
                return mCtacomotro;
            }
            set
            {
                mCtacomotro = value;
            }
        }

        public string Ctacon
        {
            get
            {
                return mCtacon;
            }
            set
            {
                mCtacon = value;
            }
        }

        public string Ctaislr
        {
            get
            {
                return mCtaislr;
            }
            set
            {
                mCtaislr = value;
            }
        }

        PAGOS_PUNTOS_BANCARIOS()
        {
        }

        PAGOS_PUNTOS_BANCARIOS(string DESCR, int ID, int IDSUC, int ID_BANCO, double INACTIVO, string NROCUENTA, string UID_RESPON, string ctacomi, string ctacomotro, string ctacon, string ctaislr)
        {
            mDESCR = DESCR;
            mID = ID;
            mIDSUC = IDSUC;
            mID_BANCO = ID_BANCO;
            mINACTIVO = INACTIVO;
            mNROCUENTA = NROCUENTA;
            mUID_RESPON = UID_RESPON;
            mCtacomi = Ctacomi;
            mCtacomotro = Ctacomotro;
            mCtacon = Ctacon;
            mCtaislr = Ctaislr;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
