
namespace DesignPatterns.MediatorPattern.GenericMediator.Contracts;
public interface IMediator
{
    void RegisterHandler<TRequest, TRequestHandler>()
        where TRequest : IBaseRequest
        where TRequestHandler : IBaseRequestHandler;
    Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
    Task Send<TRequest>(TRequest request) where TRequest : IRequest;
}
