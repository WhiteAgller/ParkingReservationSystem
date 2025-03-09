using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingReservationSystem.src
{
    static class Validator
    {
        public static bool IsNotEmpty(string name)
        {
            if (name.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("field is required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool CorrectDates(DateTime dateFrom, DateTime dateTo)
        {
            return dateFrom < dateTo;
        }
    }
}
