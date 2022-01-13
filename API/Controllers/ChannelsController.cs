using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MediatR;
using System.Collections.Generic;
using Domain;
using Application.Channels;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ChannelsController : ControllerBase
  {
    private readonly DataContext _context;
    private readonly ILogger<ChannelsController> _logger;
    private readonly IMediator _mediator;

    public ChannelsController(DataContext context, ILogger<ChannelsController> logger, IMediator mediator)
    {
      _context = context ?? throw new ArgumentNullException(nameof(context));
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
      _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }


    [HttpGet]
    public async Task<ActionResult<List<Channel>>> List()
    {
      var channels = await _mediator.Send(new List.Query());
      return Ok(channels);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Channel>> Channel(Guid id)
    {
      var channels = await _mediator.Send(new Details.Query(id));
      if (channels == null)
      {
        return NotFound();
      }
      return Ok(channels);
    }

    [HttpPost]
    public async Task<ActionResult<Unit>> Create([FromBody] Create.Command command)
    {
      return await _mediator.Send(command);
    }
  }
}