using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class pharmacist
    {
        int pharmacistID;
        string fname;
        string lname;

        public int PharmacistID
        {
            get
            {
                return pharmacistID;
            }
            set
            {
                pharmacistID = value;
            }

        }

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }

        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }

        }
    }
}
