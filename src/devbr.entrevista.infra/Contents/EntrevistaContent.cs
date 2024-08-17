using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;

namespace DevBr.Entrevista.Infra.Contents
{

    public class EntrevistaDbContent : DbContext
    {
        public EntrevistaDbContent(DbContextOptions<EntrevistaDbContent> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore("CascadeMode");

            modelBuilder.AddSequence();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntrevistaDbContent).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> CommitAsync()
        {
            ConfigureStatusEntity();

            var sucesso = await SaveChangesAsync() > 0;

            return sucesso;
        }

        public bool Commit()
        {
            ConfigureStatusEntity();

            var sucesso = SaveChanges() > 0;

            return sucesso;
        }

        private void ConfigureStatusEntity()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("DataCriacao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCriacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                    entry.Property("UsuarioCriacao").IsModified = false;
                    entry.Property("DataCriacao").IsModified = false;
                    entry.Property("Codigo").IsModified = false;
                }
            }
        }
    }


}
