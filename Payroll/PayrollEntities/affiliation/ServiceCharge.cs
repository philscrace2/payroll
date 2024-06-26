﻿namespace PayrollEntities.affiliation
{
    public interface ServiceCharge
    {

        int? getAmount();
        DateTime getDate();

        void setAmount(int? amount);
        void setDate(DateTime date);

    }

    public interface ServiceChargeFactory
    {
        ServiceCharge serviceCharge(DateTime date, int? amount);
    }
}
