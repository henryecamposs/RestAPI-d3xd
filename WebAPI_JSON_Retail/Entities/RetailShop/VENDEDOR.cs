using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class VENDEDOR : ICloneable
    {

        private string mCODIGO = "";
        private string mCODINTE = "";
        private double mCOMICOBRO = 0.0;
        private double mCOMIVENTA = 0.0;
        private string mEMPLE = "";
        private int mID = 0;
        private int mIDSUC = 0;
        private double mINACTIVO = 0.0;
        private string mNOMBRE = "";

        public string CODIGO
        {
            get
            {
                return mCODIGO;
            }
            set
            {
                mCODIGO = value;
            }
        }

        public string CODINTE
        {
            get
            {
                return mCODINTE;
            }
            set
            {
                mCODINTE = value;
            }
        }

        public Double COMICOBRO
        {
            get
            {
                return mCOMICOBRO;
            }
            set
            {
                mCOMICOBRO = value;
            }
        }

        public Double COMIVENTA
        {
            get
            {
                return mCOMIVENTA;
            }
            set
            {
                mCOMIVENTA = value;
            }
        }

        public string EMPLE
        {
            get
            {
                return mEMPLE;
            }
            set
            {
                mEMPLE = value;
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

        VENDEDOR()
        {
        }

        VENDEDOR(string CODIGO, string CODINTE, double COMICOBRO, double COMIVENTA, string EMPLE, int ID, int IDSUC, double INACTIVO, string NOMBRE)
        {
            mCODIGO = CODIGO;
            mCODINTE = CODINTE;
            mCOMICOBRO = COMICOBRO;
            mCOMIVENTA = COMIVENTA;
            mEMPLE = EMPLE;
            mID = ID;
            mIDSUC = IDSUC;
            mINACTIVO = INACTIVO;
            mNOMBRE = NOMBRE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
