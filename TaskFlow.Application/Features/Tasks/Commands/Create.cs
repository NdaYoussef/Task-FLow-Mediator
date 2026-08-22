using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Application.Database;
using TaskFlow.Application.Mediator.Messaging;
using TaskFlow.Domain.Common.ResutlPatterns;

namespace TaskFlow.Application.Features.Tasks.Commands
{
    public sealed class Create(IAppDbContext appDbContext) : IResultRequestHandler<Create.Command, Result<Guid>>
    {
        public record Command(string title , string description) : IResultRequest<Result<Guid>>;

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.title).NotEmpty().WithMessage("Title is required.");
                RuleFor(x => x.description).NotEmpty().WithMessage("Description is required.");
            }
        }

        public async Task<Result<Guid>> Handle(Command request, CancellationToken cancellationToken)
        {
            var taskItem = new Domain.Entities.TaskItem
            {
                Title = request.title,
                Description = request.description,
                CreatedAt = DateTime.UtcNow
            };
            appDbContext.TaskItems.Add(taskItem);
            await appDbContext.SaveChangesAsync(cancellationToken);
            return Result<Guid>.Success(taskItem.Id);
        }


    }
}
