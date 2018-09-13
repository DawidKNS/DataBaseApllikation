using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesPeopleWork.DataBases
{
    class ConnectionStringDB
    {
        // Declare an DBLocalization - localizationDataBase

        public string DBLocalization
        {
            get
            {
                return DBLocalization;
            }
            set => DBLocalization = value;
        }

        // Declare an DBName Name of Database
        public string DBName
        {
            get
            {
                return DBName;
            }

            set
            {
                DBName = value;
            }
        }

        //Generate String
        public override string ToString()
        {
            return "Data Source=@" + DBLocalization + DBName + ".s3db";
        }

        public static explicit operator string(ConnectionStringDB v)
        {
            throw new NotImplementedException();
        }
    }
}
