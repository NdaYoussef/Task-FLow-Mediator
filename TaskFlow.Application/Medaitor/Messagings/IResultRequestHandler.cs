using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Domain.Common;

namespace TaskFlow.Application.Medaitor.Messagings
{


    public interface IResultRequest<TResult>: IRequest<TResult>
        where TResult : IResult
    { }

    public interface IResultRequestHandler<TRequest,TResult> : IRequestHandler<TRequest,TResult>
        where TRequest : IResultRequest<TResult>
        where TResult : IResult
    { }




}
