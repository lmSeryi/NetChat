using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.Channels
{
  public class Create
  {
    public class Command : IRequest
    {
      public Guid Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
    }

    public class CommandValidatior : AbstractValidator<Command>
    {
      public CommandValidatior()
      {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
      }
    }

    public class Handler : IRequestHandler<Command>
    {
      private readonly DataContext _context;

      public Handler(DataContext context)
      {
        _context = context ?? throw new ArgumentNullException(nameof(context));
      }
      public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
      {
       var channel = new Channel
        {
          Id = request.Id,
          Name = request.Name,
          Description = request.Description
        };
        _context.Channels.Add(channel);
        
        var success = await _context.SaveChangesAsync();

        if (success > 0) return Unit.Value;

        throw new Exception("Problem saving changes");
      }
    }
  }
}