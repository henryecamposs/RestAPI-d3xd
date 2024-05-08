using System;
namespace wResAPI_d3xd.Entities.RetailShop
{
    public class CAPTURA : ICloneable
    {

        private string mARCHIVO_D = "";
        private string mCODIGO = "";
        private string mDESCR = "";
        private string mDIR_D = "";
        private int mID = 0;
        private double mINTENTOS_R = 0.0;
        private double mPCAN_DPOS = 0.0;
        private double mPCAN_HPOS = 0.0;
        private double mPCOD_DPOS = 0.0;
        private double mPCOD_HPOS = 0.0;
        private double mPDOC_D = 0.0;
        private double mPDOC_H = 0.0;
        private double mPDPTO_DPOS = 0.0;
        private double mPDPTO_HPOS = 0.0;
        private double mPFEC_D = 0.0;
        private double mPFEC_H = 0.0;
        private double mPGAR_D = 0.0;
        private double mPGAR_H = 0.0;
        private double mPPROV_D = 0.0;
        private double mPPROV_H = 0.0;
        private double mPROVID = 0.0;
        private double mPSEPARA = 0.0;
        private double mPSER_D = 0.0;
        private double mPSER_H = 0.0;
        private double mPSYSS_D = 0.0;
        private double mPSYSS_H = 0.0;
        private string mP_C_SEPARA = "";
        private double mVERIFI_R = 0.0;

        public string ARCHIVO_D
        {
            get
            {
                return mARCHIVO_D;
            }
            set
            {
                mARCHIVO_D = value;
            }
        }

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

        public string DIR_D
        {
            get
            {
                return mDIR_D;
            }
            set
            {
                mDIR_D = value;
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

        public Double INTENTOS_R
        {
            get
            {
                return mINTENTOS_R;
            }
            set
            {
                mINTENTOS_R = value;
            }
        }

        public Double PCAN_DPOS
        {
            get
            {
                return mPCAN_DPOS;
            }
            set
            {
                mPCAN_DPOS = value;
            }
        }

        public Double PCAN_HPOS
        {
            get
            {
                return mPCAN_HPOS;
            }
            set
            {
                mPCAN_HPOS = value;
            }
        }

        public Double PCOD_DPOS
        {
            get
            {
                return mPCOD_DPOS;
            }
            set
            {
                mPCOD_DPOS = value;
            }
        }

        public Double PCOD_HPOS
        {
            get
            {
                return mPCOD_HPOS;
            }
            set
            {
                mPCOD_HPOS = value;
            }
        }

        public Double PDOC_D
        {
            get
            {
                return mPDOC_D;
            }
            set
            {
                mPDOC_D = value;
            }
        }

        public Double PDOC_H
        {
            get
            {
                return mPDOC_H;
            }
            set
            {
                mPDOC_H = value;
            }
        }

        public Double PDPTO_DPOS
        {
            get
            {
                return mPDPTO_DPOS;
            }
            set
            {
                mPDPTO_DPOS = value;
            }
        }

        public Double PDPTO_HPOS
        {
            get
            {
                return mPDPTO_HPOS;
            }
            set
            {
                mPDPTO_HPOS = value;
            }
        }

        public Double PFEC_D
        {
            get
            {
                return mPFEC_D;
            }
            set
            {
                mPFEC_D = value;
            }
        }

        public Double PFEC_H
        {
            get
            {
                return mPFEC_H;
            }
            set
            {
                mPFEC_H = value;
            }
        }

        public Double PGAR_D
        {
            get
            {
                return mPGAR_D;
            }
            set
            {
                mPGAR_D = value;
            }
        }

        public Double PGAR_H
        {
            get
            {
                return mPGAR_H;
            }
            set
            {
                mPGAR_H = value;
            }
        }

        public Double PPROV_D
        {
            get
            {
                return mPPROV_D;
            }
            set
            {
                mPPROV_D = value;
            }
        }

        public Double PPROV_H
        {
            get
            {
                return mPPROV_H;
            }
            set
            {
                mPPROV_H = value;
            }
        }

        public Double PROVID
        {
            get
            {
                return mPROVID;
            }
            set
            {
                mPROVID = value;
            }
        }

        public Double PSEPARA
        {
            get
            {
                return mPSEPARA;
            }
            set
            {
                mPSEPARA = value;
            }
        }

        public Double PSER_D
        {
            get
            {
                return mPSER_D;
            }
            set
            {
                mPSER_D = value;
            }
        }

        public Double PSER_H
        {
            get
            {
                return mPSER_H;
            }
            set
            {
                mPSER_H = value;
            }
        }

        public Double PSYSS_D
        {
            get
            {
                return mPSYSS_D;
            }
            set
            {
                mPSYSS_D = value;
            }
        }

        public Double PSYSS_H
        {
            get
            {
                return mPSYSS_H;
            }
            set
            {
                mPSYSS_H = value;
            }
        }

        public string P_C_SEPARA
        {
            get
            {
                return mP_C_SEPARA;
            }
            set
            {
                mP_C_SEPARA = value;
            }
        }

        public Double VERIFI_R
        {
            get
            {
                return mVERIFI_R;
            }
            set
            {
                mVERIFI_R = value;
            }
        }

        CAPTURA()
        {
        }

        CAPTURA(string ARCHIVO_D, string CODIGO, string DESCR, string DIR_D, int ID, double INTENTOS_R, double PCAN_DPOS, double PCAN_HPOS, double PCOD_DPOS, double PCOD_HPOS, double PDOC_D, double PDOC_H, double PDPTO_DPOS, double PDPTO_HPOS, double PFEC_D, double PFEC_H, double PGAR_D, double PGAR_H, double PPROV_D, double PPROV_H, double PROVID, double PSEPARA, double PSER_D, double PSER_H, double PSYSS_D, double PSYSS_H, string P_C_SEPARA, double VERIFI_R)
        {
            mARCHIVO_D = ARCHIVO_D;
            mCODIGO = CODIGO;
            mDESCR = DESCR;
            mDIR_D = DIR_D;
            mID = ID;
            mINTENTOS_R = INTENTOS_R;
            mPCAN_DPOS = PCAN_DPOS;
            mPCAN_HPOS = PCAN_HPOS;
            mPCOD_DPOS = PCOD_DPOS;
            mPCOD_HPOS = PCOD_HPOS;
            mPDOC_D = PDOC_D;
            mPDOC_H = PDOC_H;
            mPDPTO_DPOS = PDPTO_DPOS;
            mPDPTO_HPOS = PDPTO_HPOS;
            mPFEC_D = PFEC_D;
            mPFEC_H = PFEC_H;
            mPGAR_D = PGAR_D;
            mPGAR_H = PGAR_H;
            mPPROV_D = PPROV_D;
            mPPROV_H = PPROV_H;
            mPROVID = PROVID;
            mPSEPARA = PSEPARA;
            mPSER_D = PSER_D;
            mPSER_H = PSER_H;
            mPSYSS_D = PSYSS_D;
            mPSYSS_H = PSYSS_H;
            mP_C_SEPARA = P_C_SEPARA;
            mVERIFI_R = VERIFI_R;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
