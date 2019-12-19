
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DevFramework.Core.Infrastructure.Domain;

namespace DevFramework.Domain.Model
{
    public class Distance : BaseEntityWithTypeId<long>
    {        
        public double FromLat { get; set; }
        public double FromLong { get; set; }
        public double ToLat { get; set; }
        public double ToLong { get; set; }
        public double Value { get; set; }

        public List<Request> Requests { get; set; }
    }

}