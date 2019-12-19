using DevFramework.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFramework.Data.EntityTypeConfiguration
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasOne(r => r.User)
                   .WithMany(u => u.Requests)
                   .HasForeignKey(r => r.UserId);

             builder.HasOne(r => r.Distance)
                   .WithMany(u => u.Requests)
                   .HasForeignKey(r => r.DistanceId);
                   
        }
    }
}