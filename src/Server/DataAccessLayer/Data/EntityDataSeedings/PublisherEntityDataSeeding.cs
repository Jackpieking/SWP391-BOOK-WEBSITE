using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityDataSeedings;

public class PublisherEntityDataSeeding : IEntityTypeConfiguration<PublisherEntity>
{
    public void Configure(EntityTypeBuilder<PublisherEntity> builder)
    {
        PublisherEntity publisher = new()
        {
            PublisherIdentifier = new(g: "51b02aef-2b58-4433-adea-e73c37b9f224"),
            UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
            Description = "admin kiêm người đăng",
        };

        builder.HasData(data: publisher);
    }
}
