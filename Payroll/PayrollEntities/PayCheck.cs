using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollEntities
{
    public class PayCheck
    {

        private DateTime date;
        private int employeeId;
        private int grossAmount;
        private int deductionsAmount;
        private int netAmount;

        public PayCheck(DateTime payDate, int employeeId, int grossAmount, int deductionsAmount, int netAmount)
        {
            this.date = payDate;
            this.employeeId = employeeId;
            this.grossAmount = grossAmount;
            this.deductionsAmount = deductionsAmount;
            this.netAmount = netAmount;
        }

        public DateTime getDate()
        {
            return date;
        }

        public int getEmployeeId()
        {
            return employeeId;
        }

        public int getGrossAmount()
        {
            return grossAmount;
        }

        public int getDeductionsAmount()
        {
            return deductionsAmount;
        }

        public int getNetAmount()
        {
            return netAmount;
        }

        
        public override String ToString()
        {
            return "PayCheck [date=" + date + ", employeeId=" + employeeId + ", grossAmount=" + grossAmount
                    + ", deductionsAmount=" + deductionsAmount + ", netAmount=" + netAmount + "]";
        }


    }
}
