using System;
using DevFramework.Domain.Model;

namespace DevFramework.Service.Dto
{
    public class RequestDto : ImappedFrom<Request>
    {
        public DateTime CreateOn { get; set; }
        public int UserId { get; set; }
        public DistanceDto Distance { get; set; }
    }

    public class DistanceDto : ImappedFrom<Distance>
    {
        public double FromLat { get; set; }
        public double FromLong { get; set; }
        public double ToLat { get; set; }
        public double ToLong { get; set; }
        public double Value { get; set; }
    }

}
