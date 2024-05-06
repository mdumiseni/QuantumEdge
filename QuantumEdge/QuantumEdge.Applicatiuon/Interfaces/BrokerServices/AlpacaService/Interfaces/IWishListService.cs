using Alpaca.Markets;
using QuantumEdge.Application.Common.Model;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Model;

namespace QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;

public interface IWishListService
{
    Task<ResultSet<IReadOnlyList<IWatchList>>> GetAllWishLists();
    Task<ResultSet<IWatchList>> CreateWishList(string name, string[] symbols);
    Task<ResultSet<IWatchList>> GetWishListById(Guid id);
    Task<ResultSet<IWatchList>> GetWishListByName(string name);
    Task<ResultSet<IWatchList>> UpdateWishListById(Guid id, string name,IEnumerable<string> symbols);
    Task<ResultSet<IWatchList>> UpdateWishListByName(string name, string[] symbols);
    Task<ResultSet<IWatchList>> DeleteWishListById(Guid id);
    Task<ResultSet<IWatchList>> DeleteWishListByName(string name);

    Task<ResultSet<IWatchList>> AddAssetToWishListByWishListId(Guid wishListId, string symbol);
    Task<ResultSet<IWatchList>> AddAssetToWishListByWishListName(string name, string symbol);
    Task<ResultSet<IWatchList>> DeleteSymbolFromWishList(Guid wishListId, string symbol);

}