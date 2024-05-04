using MediatR.API.Mediatr.Commands;
using MediatR.API.Mediatr.Queries.GetAllProduct;
using MediatR.API.Mediatr.Queries.GetAllProductById;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediatr)
        {
            _mediator = mediatr;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand createProductCommand)
        {
            return Ok(await _mediator.Send(createProductCommand));
        }
    }
}