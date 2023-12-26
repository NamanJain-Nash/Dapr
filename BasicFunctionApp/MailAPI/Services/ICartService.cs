namespace MailAPI;

public interface ICartService
{
    public Task<Cart> GetCartDetails(string userId);
    public Task AddItemsToCart(string userId,Items items);
}
