namespace PayrollPorts.primaryAdminUseCase.response
{
    public interface Response
    {
        public sealed class EmptyResponse : Response
        {
            public EmptyResponse INSTANCE = new EmptyResponse();
        }
    }

}

