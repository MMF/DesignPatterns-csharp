using DesignPatterns.MediatorPattern.GenericMediator.Contracts;
using System.Reflection;

namespace DesignPatterns.MediatorPattern.GenericMediator;
public class Mediator : IMediator
{
    private Dictionary<Type, Type> _handlers = new();

    public void RegisterHandler<TRequest, TRequestHandler>()
        where TRequest : IBaseRequest
        where TRequestHandler : IBaseRequestHandler
    {
        _handlers.Add(typeof(TRequest), typeof(TRequestHandler));
    }

    public (dynamic Handler, MethodInfo handleMethod) _GetHandlerAndHandleMethod(Type requestType)
    {
        if (!_handlers.ContainsKey(requestType))
            throw new InvalidOperationException($"Handler for {requestType.Name} not found");

        var handlerType = _handlers[requestType];
        dynamic handlerInstance = Activator.CreateInstance(handlerType);

        var handleMethod = handlerType.GetMethod("Handle");
        if (handleMethod is null)
            throw new InvalidOperationException($"Handle method not found in {handlerType.Name}");

        return (handlerInstance, handleMethod);
    }

    public Task Send<TRequest>(TRequest request)
        where TRequest : IRequest
    {
        ArgumentNullException.ThrowIfNull(request);

        (dynamic handlerInstance, MethodInfo handleMethod) = _GetHandlerAndHandleMethod(request.GetType());

        return (Task) handleMethod.Invoke(handlerInstance, new object[] { request });
    }

    public Task<TResponse> Send<TResponse>(IRequest<TResponse> request)
    {
        ArgumentNullException.ThrowIfNull(request);

        (dynamic handlerInstance, MethodInfo handleMethod) = _GetHandlerAndHandleMethod(request.GetType());

        return (Task<TResponse>) handleMethod.Invoke(handlerInstance, new object[] { request });
    }
}
