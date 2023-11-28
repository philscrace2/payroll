using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollEntities.paymentmethod;
using PayrollEntities.paymentschedule;
using PayrollEntities.paymenttype;

namespace PayrollDBAdapterInMemory.entity
{
    public class EmployeeImpl : Employee
    {

        private int? id;
        private String name;
        private String address;

        private PaymentType paymentType;
        private PaymentSchedule paymentSchedule;
        private PaymentMethod paymentMethod;
        private Affiliation affiliation;


        public override PaymentType getPaymentType()
        {
            return paymentType;
        }


        public override void setPaymentType(PaymentType paymentType)
        {
            this.paymentType = paymentType;
        }


        public override String getName()
        {
            return name;
        }


        public override void setName(String name)
        {
            this.name = name;
        }


        public override int? getId()
        {
            return id;
        }


        public override void setId(int? id)
        {
            this.id = id;
        }


        public override String getAddress()
        {
            return address;
        }


        public override void setAddress(String address)
        {
            this.address = address;
        }


        public override PaymentSchedule getPaymentSchedule()
        {
            return paymentSchedule;
        }


        public override void setPaymentSchedule(PaymentSchedule paymentSchedule)
        {
            this.paymentSchedule = paymentSchedule;
        }


        public override PaymentMethod getPaymentMethod()
        {
            return paymentMethod;
        }


        public override void setPaymentMethod(PaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }


        public override Affiliation getAffiliation()
        {
            return affiliation;
        }


        public override void setAffiliation(Affiliation affiliation)
        {
            this.affiliation = affiliation;
        }
    }
}

