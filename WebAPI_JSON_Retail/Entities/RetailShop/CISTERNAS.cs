using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CISTERNAS : ICloneable
    {

        private string mCODIGO = "";
        private int mID = 0;
        private double mINACTIVO = 0.0;
        private double mJETAVGAS = 0.0;
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

        public Double JETAVGAS
        {
            get
            {
                return mJETAVGAS;
            }
            set
            {
                mJETAVGAS = value;
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

        CISTERNAS()
        {
        }

        CISTERNAS(string CODIGO, int ID, double INACTIVO, double JETAVGAS, string NOMBRE)
        {
            mCODIGO = CODIGO;
            mID = ID;
            mINACTIVO = INACTIVO;
            mJETAVGAS = JETAVGAS;
            mNOMBRE = NOMBRE;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
