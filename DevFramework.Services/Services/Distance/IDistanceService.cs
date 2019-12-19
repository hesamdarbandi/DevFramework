using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using DevFramework.Service.Dto;
using DevFramework.Core.Infrastructure.Model;

namespace DevFramework.Service
{
    public interface IDistanceService
    {
        Task<double> GetDistance(double fromLat, double fromLong, double toLat, double Tolong);
        Task<List<RequestDto>> GetUserRequests();
    }
}