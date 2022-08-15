namespace DesignPattern.Application
{
    public interface ICommandHandler<T,U> where T : ICommand
    {
        U Handle(T command);
    }
}
