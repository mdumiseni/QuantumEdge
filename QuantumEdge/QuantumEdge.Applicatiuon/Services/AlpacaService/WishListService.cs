using Alpaca.Markets;
using QuantumEdge.Application.Common.Model;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;

namespace AlpacaAccount.Services;

public class WishListService(IAlpacaTradingClient client) : IWishListService
{
    public async Task<ResultSet<IReadOnlyList<IWatchList>>> GetAllWishLists()
    {
        throw new NotImplementedException();
    }

    public async Task<ResultSet<IWatchList>> CreateWishList(string name, string[] symbols)
    {
        var newWishList = await client.CreateWatchListAsync(new NewWatchListRequest(name)
        {
            
        });
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = newWishList };
    }

    public async Task<ResultSet<IWatchList>> GetWishListById(Guid id)
    {
        var wishList = await client.GetWatchListByIdAsync(id);
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = wishList };
    }

    public async Task<ResultSet<IWatchList>> GetWishListByName(string name)
    {
        var wishList = await client.GetWatchListByNameAsync(name);
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = wishList };
    }

    public async Task<ResultSet<IWatchList>> UpdateWishListById(Guid id, string name, IEnumerable<string> symbols)
    {
        var wishList = await client.UpdateWatchListByIdAsync(new UpdateWatchListRequest(id,name, symbols));
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = wishList };
    }

    public async Task<ResultSet<IWatchList>> UpdateWishListByName(string name, string[] symbols)
    {
        throw new NotImplementedException();
    }

    public async Task<ResultSet<IWatchList>> DeleteWishListById(Guid id)
    {
        var wishList = await client.GetWatchListByIdAsync(id);
        
        var isDeleted = await client.DeleteWatchListByIdAsync(id);
        if (!isDeleted)
            return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Error , Message = "Failed to deleted wish list."};
        
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = wishList };
    }

    public async Task<ResultSet<IWatchList>> DeleteWishListByName(string name)
    {
        var wishList = await client.GetWatchListByNameAsync(name);
        
        var isDeleted = await client.DeleteWatchListByNameAsync(name);
        if (!isDeleted)
            return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Error , Message = "Failed to deleted wish list."};
        
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = wishList };
    }

    public async Task<ResultSet<IWatchList>> AddAssetToWishListByWishListId(Guid wishListId, string symbol)
    {
        var wishList =
            await client.AddAssetIntoWatchListByIdAsync(new ChangeWatchListRequest<Guid>(wishListId, symbol));
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = wishList };
    }

    public async Task<ResultSet<IWatchList>> AddAssetToWishListByWishListName(string name, string symbol)
    {
        var wishList = await client.AddAssetIntoWatchListByNameAsync(new ChangeWatchListRequest<string>(name, symbol));
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = wishList };
    }

    public async Task<ResultSet<IWatchList>> DeleteSymbolFromWishList(Guid wishListId, string symbol)
    {
        var wishList =
            await client.DeleteAssetFromWatchListByIdAsync(new ChangeWatchListRequest<Guid>(wishListId, symbol));
        return new ResultSet<IWatchList>() { ResultStatus = ResultStatus.Success, Data = wishList };
    }
}