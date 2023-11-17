namespace PayrollPorts.primaryAdminUseCase.exception.multiple
{
    public interface IVisitor<V, A> where V : IVisitor<V, A> where A : IVisitable<V, A>
    {
        // Interface methods go here
    }

}
