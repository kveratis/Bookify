using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstractions.Messaging;

/// <summary>
/// Enforce that all of my queries return a result type envelope response
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
    
}