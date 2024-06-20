using Microsoft.Extensions.Logging;
using QuantumEdge.Application.Common.Model;
using QuantumEdge.Application.Interfaces.WorldClockService;

namespace QuantumEdge.Application.Services.WorldClockService;

public class WorldClockService(ILogger<WorldClockService> logger) : IWorldClockService
{
    public async Task<ResultSet<Dictionary<string, DateTime>>> GetLocationDateTime(string currentLocation, string destinationLocation)
    {
        var worldTimes = new Dictionary<string, DateTime>();
        
        //"South Africa Standard Time"
        var currentLocationTimeZone = TimeZoneInfo.FindSystemTimeZoneById(currentLocation);
        var currentLocationTime = TimeZoneInfo.ConvertTime(DateTime.Now, currentLocationTimeZone);
        
        worldTimes.Add(currentLocation, currentLocationTime);
        logger.LogInformation($"Current time in {currentLocation}: " + currentLocationTime);

        // Get the time zone info for New York "Eastern Standard Time"
        var  destinationLocationTimeZone = TimeZoneInfo.FindSystemTimeZoneById(destinationLocation);
        
        var destinationLocationTime = TimeZoneInfo.ConvertTime(currentLocationTime, currentLocationTimeZone, destinationLocationTimeZone);
        worldTimes.Add(destinationLocation,destinationLocationTime);
        logger.LogInformation($"Current time in {destinationLocation}: " + destinationLocationTime);
        
        return new ResultSet<Dictionary<string, DateTime>>() { ResultStatus = ResultStatus.Success, Message = "Success", Data = worldTimes };
    }
}