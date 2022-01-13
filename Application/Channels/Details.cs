using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Channels
{
  public class Details
  {
    public class Query : IRequest<Channel>
    {
      public Guid Id;

      public Query(Guid id)
      {
        Id = id;
      }
    }

    public class Handler : IRequestHandler<Query, Channel>
    {
      private readonly DataContext _context;
      private readonly ILogger<Handler> _logger;

      public Handler(DataContext context, ILogger<Handler> logger)
      {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
      }
      public async Task<Channel> Handle(Query request, CancellationToken cancellationToken)
      {
        return await _context.Channels.Where(c => c.Id == request.Id).FirstOrDefaultAsync();
      }
    }
  }
}