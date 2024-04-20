namespace DesignPatterns.MediatorPattern.GenericMediator.Contracts;

public interface IBaseRequest { }
public interface IRequest : IBaseRequest { }

public interface IRequest<TResponse> : IBaseRequest { }
