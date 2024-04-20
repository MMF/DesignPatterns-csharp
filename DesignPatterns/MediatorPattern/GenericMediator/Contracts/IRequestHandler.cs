namespace DesignPatterns.MediatorPattern.GenericMediator.Contracts;

public interface IBaseRequestHandler { }

public interface IRequestHandler<in TRequest> : IBaseRequestHandler
    where TRequest : IRequest
{
    Task Handle(TRequest request);
}

public interface IRequestHandler<in TRequest, TResponse> : IBaseRequestHandler
    where TRequest : IRequest<TResponse>
{
    Task<TResponse> Handle(TRequest request);
}
