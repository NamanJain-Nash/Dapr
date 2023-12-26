using Microsoft.AspNetCore.Mvc;

namespace MailAPI;

[ApiController]
[Route("api/cart-managemnet")]
public class CartDataController:ControllerBase
{
    private readonly ICartService _cartService;

    public CartDataController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpGet("{userId}")]
    public async Task<ActionResult<Cart>> Get(string userId)
    {
        Cart cart = await _cartService.GetCartDetails(userId);

        return Ok(cart);
    }

    [HttpPost("{userId}/items")]
    public async Task<ActionResult<Domain.ShoppingCart>> Post(string userId, Domain.ShoppingCartItem item)
    {
        try
        {
            await _shoppingCartService.AddItemToShoppingCartAsync(userId, item);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

}
