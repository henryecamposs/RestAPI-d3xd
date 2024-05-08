using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class REDONDEOG : ICloneable
    {

        private double mFDECIMAL = 0.0;
        private double mFENTERO = 0.0;
        private int mID = 0;
        private double mMODDEC = 0.0;
        private double mMODENT = 0.0;
        private double mUNIDAD = 0.0;
        private double mVALREDDEC = 0.0;
        private double mVALREDENT = 0.0;
        private double mVALREDTOT = 0.0;

        public Double FDECIMAL
        {
            get
            {
                return mFDECIMAL;
            }
            set
            {
                mFDECIMAL = value;
            }
        }

        public Double FENTERO
        {
            get
            {
                return mFENTERO;
            }
            set
            {
                mFENTERO = value;
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

        public Double MODDEC
        {
            get
            {
                return mMODDEC;
            }
            set
            {
                mMODDEC = value;
            }
        }

        public Double MODENT
        {
            get
            {
                return mMODENT;
            }
            set
            {
                mMODENT = value;
            }
        }

        public Double UNIDAD
        {
            get
            {
                return mUNIDAD;
            }
            set
            {
                mUNIDAD = value;
            }
        }

        public Double VALREDDEC
        {
            get
            {
                return mVALREDDEC;
            }
            set
            {
                mVALREDDEC = value;
            }
        }

        public Double VALREDENT
        {
            get
            {
                return mVALREDENT;
            }
            set
            {
                mVALREDENT = value;
            }
        }

        public Double VALREDTOT
        {
            get
            {
                return mVALREDTOT;
            }
            set
            {
                mVALREDTOT = value;
            }
        }

        REDONDEOG()
        {
        }

        REDONDEOG(double FDECIMAL, double FENTERO, int ID, double MODDEC, double MODENT, double UNIDAD, double VALREDDEC, double VALREDENT, double VALREDTOT)
        {
            mFDECIMAL = FDECIMAL;
            mFENTERO = FENTERO;
            mID = ID;
            mMODDEC = MODDEC;
            mMODENT = MODENT;
            mUNIDAD = UNIDAD;
            mVALREDDEC = VALREDDEC;
            mVALREDENT = VALREDENT;
            mVALREDTOT = VALREDTOT;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
