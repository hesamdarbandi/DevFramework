
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DevFramework.Core.Infrastructure.Domain;

namespace DevFramework.Domain.Model
{
    public class Request : BaseEntityWithTypeId<long>
    {
        public int UserId { get; set; }
        public long DistanceId { get; set; }

        public User User { get; set; }
        public Distance Distance { get; set; }
    }

}