using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Prescription
    {
        private int prescriptionID;
        private int dosage;
        private DateTime dateIssued;
        private int duration;
      

        public int PrescriptionID
        {
            get { return prescriptionID; }
            set { prescriptionID = value; }
        }

        public int Dosage
        {
            get { return dosage; }
            set { dosage = value; }
        }

        public DateTime DateIssued
        {
            get { return dateIssued; }
            set { dateIssued = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

       
    }
}
