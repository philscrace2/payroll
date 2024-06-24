using PayrollAdminAdapterGui.validation;
using PayrollEntities.paymentmethod;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee
{
    public class SalariedEmployeeViewModel : EmployeeViewModel
    {
        public int? monthlySalary;

        public void accept(EmployeeViewModelVisitor visitor)
        {
            visitor.visit(this);
        }

        public override void Accept(IEmployeeViewModelVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public interface EmployeeViewModelVisitor
    {
        void visit(SalariedEmployeeViewModel salariedEmployeeViewModel);
        void visit(HourlyEmployeeViewModel hourlyEmployeeViewModel);
        void visit(CommissionedEmployeeViewModel commissionedEmployeeViewModel);
    }

    public interface AddEmployeeView : DialogView<AddEmployeeViewListener>,
            ModelProducer<EmployeeViewModel>,
            ModelConsumer<ValidationErrorMessagesModel>
    {
        public abstract void accept(EmployeeViewModelVisitor visitor);

    }

    public class HourlyEmployeeViewModel : EmployeeViewModel
    {
        public int? hourlyWage;

        public void accept(EmployeeViewModelVisitor visitor)
        {
            visitor.visit(this);
        }

        public override void Accept(IEmployeeViewModelVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }

    public class DirectPaymentMethod : EmployeeViewModel.IPaymentMethod
    {

        public String accountNumber;
        public DirectPaymentMethod(String accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public T accept<T>(PaymentMethodVisitor<T> visitor)
        {
            return visitor.visit(this);
        }

        public T Accept<T>(EmployeeViewModel.IPaymentMethodVisitor<T> visitor)
        {
            throw new NotImplementedException();
        }
    }

    public class CommissionedEmployeeViewModel : EmployeeViewModel
    {
        public int? biWeeklyBaseSalary;
        public int? commissionRatePercentage;

        public void accept(EmployeeViewModelVisitor visitor)
        {
            visitor.visit(this);
        }

        public override void Accept(IEmployeeViewModelVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }

    public interface AddEmployeeViewListener : CloseableViewListener
    {
        void onAddEmployee();
        void onCancel();
    }

    public interface PaymentMethodVisitor<T>
    {
        T visit(PaymasterPaymentMethod paymentMethod);
        T visit(DirectPaymentMethod paymentMethod);
    }

    public abstract class EmployeeViewModel
    {
        public int? EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IPaymentMethod PaymentMethod { get; set; }

        public interface IPaymentMethod
        {
            T Accept<T>(IPaymentMethodVisitor<T> visitor);
        }

        public interface IPaymentMethodVisitor<T>
        {
            T Visit(PaymasterPaymentMethod paymentMethod);
            T Visit(DirectPaymentMethod paymentMethod);
        }

        public class PaymasterPaymentMethod : IPaymentMethod
        {
            public T Accept<T>(IPaymentMethodVisitor<T> visitor) => visitor.Visit(this);
        }

        public class DirectPaymentMethod : IPaymentMethod
        {
            public string AccountNumber { get; set; }

            public DirectPaymentMethod(string accountNumber)
            {
                AccountNumber = accountNumber;
            }

            public T Accept<T>(IPaymentMethodVisitor<T> visitor) => visitor.Visit(this);
        }

        public abstract void Accept(IEmployeeViewModelVisitor visitor);

        public interface IEmployeeViewModelVisitor
        {
            void Visit(SalariedEmployeeViewModel salariedEmployeeViewModel);
            void Visit(HourlyEmployeeViewModel hourlyEmployeeViewModel);
            void Visit(CommissionedEmployeeViewModel commissionedEmployeeViewModel);
        }
    }


    //public int?erface PaymentMethod
    //{
    //    T accept<T>(PaymentMethodVisitor<T> visitor);

    //}

    //public class PaymasterPaymentMethod : PaymentMethod
    //{

    //    public T accept<T>(PaymentMethodVisitor<T> visitor)
    //    {
    //        return visitor.visit(this);
    //    }
    //}

    //public class CommissionedEmployeeViewModel : EmployeeViewModel
    //{
    //    public int? biWeeklyBaseSalary;
    //    public int? commissionRatePercentage;

    //    public void accept(EmployeeViewModelVisitor visitor)
    //    {
    //        visitor.visit(this);
    //    }
    //}
}

