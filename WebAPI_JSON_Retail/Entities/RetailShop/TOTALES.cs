using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class TOTALES : ICloneable
    {

        private double mABONOS = 0.0;
        private double mBASE = 0.0;
        private double mCANTI = 0.0;
        private double mCHEQUES = 0.0;
        private double mCOMIVEN = 0.0;
        private double mCREDITOS = 0.0;
        private double mDESCUENTOS = 0.0;
        private double mEFECTIVO = 0.0;
        private double mEXENTO = 0.0;
        private double mFINAL = 0.0;
        private int mID = 0;
        private double mIMP1 = 0.0;
        private double mIMP2 = 0.0;
        private double mIMP3 = 0.0;
        private double mINICIO = 0.0;
        private double mOTROSP = 0.0;
        private double mPAGOSI = 0.0;
        private double mTARJETAS = 0.0;
        private double mTICKETS = 0.0;
        private double mVALES = 0.0;

        public Double ABONOS
        {
            get
            {
                return mABONOS;
            }
            set
            {
                mABONOS = value;
            }
        }

        public Double BASE
        {
            get
            {
                return mBASE;
            }
            set
            {
                mBASE = value;
            }
        }

        public Double CANTI
        {
            get
            {
                return mCANTI;
            }
            set
            {
                mCANTI = value;
            }
        }

        public Double CHEQUES
        {
            get
            {
                return mCHEQUES;
            }
            set
            {
                mCHEQUES = value;
            }
        }

        public Double COMIVEN
        {
            get
            {
                return mCOMIVEN;
            }
            set
            {
                mCOMIVEN = value;
            }
        }

        public Double CREDITOS
        {
            get
            {
                return mCREDITOS;
            }
            set
            {
                mCREDITOS = value;
            }
        }

        public Double DESCUENTOS
        {
            get
            {
                return mDESCUENTOS;
            }
            set
            {
                mDESCUENTOS = value;
            }
        }

        public Double EFECTIVO
        {
            get
            {
                return mEFECTIVO;
            }
            set
            {
                mEFECTIVO = value;
            }
        }

        public Double EXENTO
        {
            get
            {
                return mEXENTO;
            }
            set
            {
                mEXENTO = value;
            }
        }

        public Double FINAL
        {
            get
            {
                return mFINAL;
            }
            set
            {
                mFINAL = value;
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

        public Double IMP1
        {
            get
            {
                return mIMP1;
            }
            set
            {
                mIMP1 = value;
            }
        }

        public Double IMP2
        {
            get
            {
                return mIMP2;
            }
            set
            {
                mIMP2 = value;
            }
        }

        public Double IMP3
        {
            get
            {
                return mIMP3;
            }
            set
            {
                mIMP3 = value;
            }
        }

        public Double INICIO
        {
            get
            {
                return mINICIO;
            }
            set
            {
                mINICIO = value;
            }
        }

        public Double OTROSP
        {
            get
            {
                return mOTROSP;
            }
            set
            {
                mOTROSP = value;
            }
        }

        public Double PAGOSI
        {
            get
            {
                return mPAGOSI;
            }
            set
            {
                mPAGOSI = value;
            }
        }

        public Double TARJETAS
        {
            get
            {
                return mTARJETAS;
            }
            set
            {
                mTARJETAS = value;
            }
        }

        public Double TICKETS
        {
            get
            {
                return mTICKETS;
            }
            set
            {
                mTICKETS = value;
            }
        }

        public Double VALES
        {
            get
            {
                return mVALES;
            }
            set
            {
                mVALES = value;
            }
        }

        TOTALES()
        {
        }

        TOTALES(double ABONOS, double BASE, double CANTI, double CHEQUES, double COMIVEN, double CREDITOS, double DESCUENTOS, double EFECTIVO, double EXENTO, double FINAL, int ID, double IMP1, double IMP2, double IMP3, double INICIO, double OTROSP, double PAGOSI, double TARJETAS, double TICKETS, double VALES)
        {
            mABONOS = ABONOS;
            mBASE = BASE;
            mCANTI = CANTI;
            mCHEQUES = CHEQUES;
            mCOMIVEN = COMIVEN;
            mCREDITOS = CREDITOS;
            mDESCUENTOS = DESCUENTOS;
            mEFECTIVO = EFECTIVO;
            mEXENTO = EXENTO;
            mFINAL = FINAL;
            mID = ID;
            mIMP1 = IMP1;
            mIMP2 = IMP2;
            mIMP3 = IMP3;
            mINICIO = INICIO;
            mOTROSP = OTROSP;
            mPAGOSI = PAGOSI;
            mTARJETAS = TARJETAS;
            mTICKETS = TICKETS;
            mVALES = VALES;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
