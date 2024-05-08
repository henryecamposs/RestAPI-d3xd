using System;
namespace wResAPI_d3xd.Entities.kssMarket
{
    public class SysDB_Errors : ICloneable
    {

        private int mID = 0;
        private string mUserName = "";
        private int mErrorNumber = 0;
        private int mErrorState = 0;
        private int mErrorSeverity = 0;
        private int mErrorLine = 0;
        private string mErrorProcedure = "";
        private string mErrorMessage = "";
        private DateTime mErrorDateTimeTime = new DateTime(2000, 01, 01);

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

        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }

        public int ErrorNumber
        {
            get
            {
                return mErrorNumber;
            }
            set
            {
                mErrorNumber = value;
            }
        }

        public int ErrorState
        {
            get
            {
                return mErrorState;
            }
            set
            {
                mErrorState = value;
            }
        }

        public int ErrorSeverity
        {
            get
            {
                return mErrorSeverity;
            }
            set
            {
                mErrorSeverity = value;
            }
        }

        public int ErrorLine
        {
            get
            {
                return mErrorLine;
            }
            set
            {
                mErrorLine = value;
            }
        }

        public string ErrorProcedure
        {
            get
            {
                return mErrorProcedure;
            }
            set
            {
                mErrorProcedure = value;
            }
        }

        public string ErrorMessage
        {
            get
            {
                return mErrorMessage;
            }
            set
            {
                mErrorMessage = value;
            }
        }

        public DateTime ErrorDateTimeTime
        {
            get
            {
                return mErrorDateTimeTime;
            }
            set
            {
                mErrorDateTimeTime = value;
            }
        }

        SysDB_Errors()
        {
        }

        SysDB_Errors(int ID, string UserName, int ErrorNumber, int ErrorState, int ErrorSeverity, int ErrorLine, string ErrorProcedure, string ErrorMessage, DateTime ErrorDateTimeTime)
        {
            mID = ID;
            mUserName = UserName;
            mErrorNumber = ErrorNumber;
            mErrorState = ErrorState;
            mErrorSeverity = ErrorSeverity;
            mErrorLine = ErrorLine;
            mErrorProcedure = ErrorProcedure;
            mErrorMessage = ErrorMessage;
            mErrorDateTimeTime = ErrorDateTimeTime;
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

    }
}
