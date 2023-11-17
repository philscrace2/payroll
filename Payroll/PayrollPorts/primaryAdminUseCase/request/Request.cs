namespace PayrollPorts.primaryAdminUseCase.request
{
    public interface Request
    {

        public static readonly EmptyRequest EMPTY_REQUEST = new EmptyRequest();
        public class EmptyRequest : Request
        {
        }
    }
}
