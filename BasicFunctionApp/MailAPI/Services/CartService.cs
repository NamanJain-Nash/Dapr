using Dapr.Client;
using Grpc.Core;
using Microsoft.VisualBasic;
namespace MailAPI;

public class CartService:ICartService
{
    //We will use to add the data from Dapr Client
    private readonly DaprClient _daprCleint;    
    private static readonly string storeName="cart";
    public CartService(DaprClient daprClient){
        _daprCleint=daprClient;
    }
    public async Task AddItemsToCart(string userId,Items item){
        Cart newCart=await GetCartDetails(userId);
        Items? existingItems=newCart.CardItems.Where(x=>x.Id==item.Id).FirstOrDefault();
        if(existingItems==null){
            newCart.CardItems.Add(item);   
        }
        else{
            existingItems.Qunatity+=item.Qunatity;
            int index = newCart.CardItems.FindIndex(x => x.Id == item.Id);
        if (index != -1)
        {
            newCart.CardItems[index] = existingItems;
        }
        }
        await _daprCleint.SaveStateAsync(storeName,userId,newCart);
    }
    public async Task<Cart> GetCartDetails(string userId){
        Cart details=await _daprCleint.GetStateAsync<Cart>(storeName,userId);
        //null case
        if(details==null){
            details=new Cart(){
                UserId=userId
            };
        }
        return details;
    }


}
