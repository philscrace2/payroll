using PayrollAdminAdapterGui.validation;
using PayrollAdminAdapterGui.views_controllers_uis.dialog;

namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public class SalariedEmployeeViewModel : EmployeeViewModel
    {
        public int monthlySalary;

        public void accept(EmployeeViewModelVisitor visitor)
        {
            visitor.visit(this);
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
    public interface PaymentMethod
    {
        T accept<T>(PaymentMethodVisitor<T> visitor);

    }
    public class HourlyEmployeeViewModel : EmployeeViewModel
    {
        public int hourlyWage;

        public void accept(EmployeeViewModelVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class DirectPaymentMethod : PaymentMethod
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
        public int? employeeId;
        public String name;
        public String address;
        public PaymentMethod paymentMethod;

    }

    public class PaymasterPaymentMethod : PaymentMethod
    {

        public T accept<T>(PaymentMethodVisitor<T> visitor)
        {
            return visitor.visit(this);
        }
    }

    public class CommissionedEmployeeViewModel : EmployeeViewModel
    {
        public int biWeeklyBaseSalary;
        public int commissionRatePercentage;

        public void accept(EmployeeViewModelVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}

