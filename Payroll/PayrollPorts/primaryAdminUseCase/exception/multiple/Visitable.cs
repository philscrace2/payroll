namespace PayrollPorts.primaryAdminUseCase.exception.multiple
{
    public interface IVisitable<V, A> where V : IVisitor<V, A> where A : IVisitable<V, A>
    {
        R Accept<R>(V visitor);
    }
}
