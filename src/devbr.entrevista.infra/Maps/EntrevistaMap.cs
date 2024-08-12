using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class EntrevistaMap : IEntityTypeConfiguration<devbr.entrevista.domain.entities.Entrevista>
    {
        public void Configure(EntityTypeBuilder<devbr.entrevista.domain.entities.Entrevista> builder)
        {
            throw new NotImplementedException();
        }
    }
}
