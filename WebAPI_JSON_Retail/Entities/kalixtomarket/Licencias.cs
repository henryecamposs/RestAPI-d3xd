using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class Licencias : ICloneable
    {

        private int mID = 0;
        private string mCodigoActivacion = "";
        private string mCodigoSerial = "";
        private string mHdd_Serial = "";
        private string mMotherBoard_Serial = "";
        private string mNombreEquipo = "";
        private string mSistemaOperativo = "";
        private string mSO_Version = "";
        private string mEsActivo = "";
        private bool mEsOnline = false;
        private string mNombreEmpresa = "";
        private string mRIF = "";
        private string mDireccion = "";
        private string mId_defTipoLicencia = "";
        private string mNroUsos = "";
        private string mNroUsosTotal = "";
        private string mFechaInstalacion = "";
        private string mFechaExpira = "";
        private string mFechaDLL = "";
        private string mKeyDLL = "";
        private string mQRCode = "";

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

        public string CodigoActivacion
        {
            get
            {
                return mCodigoActivacion;
            }
            set
            {
                mCodigoActivacion = value;
            }
        }

        public string CodigoSerial
        {
            get
            {
                return mCodigoSerial;
            }
            set
            {
                mCodigoSerial = value;
            }
        }

        public string Hdd_Serial
        {
            get
            {
                return mHdd_Serial;
            }
            set
            {
                mHdd_Serial = value;
            }
        }

        public string MotherBoard_Serial
        {
            get
            {
                return mMotherBoard_Serial;
            }
            set
            {
                mMotherBoard_Serial = value;
            }
        }

        public string NombreEquipo
        {
            get
            {
                return mNombreEquipo;
            }
            set
            {
                mNombreEquipo = value;
            }
        }

        public string SistemaOperativo
        {
            get
            {
                return mSistemaOperativo;
            }
            set
            {
                mSistemaOperativo = value;
            }
        }

        public string SO_Version
        {
            get
            {
                return mSO_Version;
            }
            set
            {
                mSO_Version = value;
            }
        }

        public string EsActivo
        {
            get
            {
                return mEsActivo;
            }
            set
            {
                mEsActivo = value;
            }
        }

        public Boolean EsOnline
        {
            get
            {
                return mEsOnline;
            }
            set
            {
                mEsOnline = value;
            }
        }

        public string NombreEmpresa
        {
            get
            {
                return mNombreEmpresa;
            }
            set
            {
                mNombreEmpresa = value;
            }
        }

        public string RIF
        {
            get
            {
                return mRIF;
            }
            set
            {
                mRIF = value;
            }
        }

        public string Direccion
        {
            get
            {
                return mDireccion;
            }
            set
            {
                mDireccion = value;
            }
        }

        public string Id_defTipoLicencia
        {
            get
            {
                return mId_defTipoLicencia;
            }
            set
            {
                mId_defTipoLicencia = value;
            }
        }

        public string NroUsos
        {
            get
            {
                return mNroUsos;
            }
            set
            {
                mNroUsos = value;
            }
        }

        public string NroUsosTotal
        {
            get
            {
                return mNroUsosTotal;
            }
            set
            {
                mNroUsosTotal = value;
            }
        }

        public string FechaInstalacion
        {
            get
            {
                return mFechaInstalacion;
            }
            set
            {
                mFechaInstalacion = value;
            }
        }

        public string FechaExpira
        {
            get
            {
                return mFechaExpira;
            }
            set
            {
                mFechaExpira = value;
            }
        }

        public string FechaDLL
        {
            get
            {
                return mFechaDLL;
            }
            set
            {
                mFechaDLL = value;
            }
        }

        public string KeyDLL
        {
            get
            {
                return mKeyDLL;
            }
            set
            {
                mKeyDLL = value;
            }
        }

        public string QRCode
        {
            get
            {
                return mQRCode;
            }
            set
            {
                mQRCode = value;
            }
        }

        Licencias()
        {
        }

        Licencias(int ID, string CodigoActivacion, string CodigoSerial, string hdd_Serial, string MotherBoard_Serial, string NombreEquipo, string SistemaOperativo, string SO_Version, string esActivo, bool esOnline, string NombreEmpresa, string RIF, string Direccion, string id_defTipoLicencia, string NroUsos, string NroUsosTotal, string FechaInstalacion, string FechaExpira, string FechaDLL, string KeyDLL, string QRCode)
        {
            mID = ID;
            mCodigoActivacion = CodigoActivacion;
            mCodigoSerial = CodigoSerial;
            mHdd_Serial = Hdd_Serial;
            mMotherBoard_Serial = MotherBoard_Serial;
            mNombreEquipo = NombreEquipo;
            mSistemaOperativo = SistemaOperativo;
            mSO_Version = SO_Version;
            mEsActivo = EsActivo;
            mEsOnline = EsOnline;
            mNombreEmpresa = NombreEmpresa;
            mRIF = RIF;
            mDireccion = Direccion;
            mId_defTipoLicencia = Id_defTipoLicencia;
            mNroUsos = NroUsos;
            mNroUsosTotal = NroUsosTotal;
            mFechaInstalacion = FechaInstalacion;
            mFechaExpira = FechaExpira;
            mFechaDLL = FechaDLL;
            mKeyDLL = KeyDLL;
            mQRCode = QRCode;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
