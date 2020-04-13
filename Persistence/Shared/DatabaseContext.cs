using System.Data.Entity;
using Alquiler.Domain.Articles;
using Alquiler.Domain.BodyParts;
using Alquiler.Domain.Categories;
using Alquiler.Domain.CityCounties;
using Alquiler.Domain.Common;
using Alquiler.Domain.Compositions;
using Alquiler.Domain.Customers;
using Alquiler.Domain.Projects;
using Alquiler.Domain.Roles;
using Alquiler.Domain.Stocks;
using Alquiler.Domain.UserClaims;
using Alquiler.Domain.UserLogins;
using Alquiler.Domain.UserRoles;
using Alquiler.Domain.Users;
using Alquiler.Domain.Warehouses;
using Alquiler.Persistence.Articles;
using Alquiler.Persistence.BodyParts;
using Alquiler.Persistence.Categories;
using Alquiler.Persistence.CityCounties;
using Alquiler.Persistence.Compositions;
using Alquiler.Persistence.Customers;
using Alquiler.Persistence.Projects;
using Alquiler.Persistence.Roles;
using Alquiler.Persistence.Stocks;
using Alquiler.Persistence.UserClaims;
using Alquiler.Persistence.UserLogins;
using Alquiler.Persistence.UserRoles;
using Alquiler.Persistence.Users;
using Alquiler.Persistence.Warehouses;

namespace Alquiler.Persistence.Shared
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserLogin> UserLogins { get; set; }
        public IDbSet<UserClaim> UserClaims { get; set; }
        public IDbSet<Rol> Roles { get; set; }
        public IDbSet<UserRol> UserRoles { get; set; }


        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Equipment> Equipments { get; set; }
        public IDbSet<Bodypart> BodyParts { get; set; }
        public IDbSet<CityCounty> CityCounties { get; set; }
        public IDbSet<Composition> Compositions { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Project> Projects { get; set; }
        public IDbSet<Stock> Stocks { get; set; }
        public IDbSet<Warehouse> Warehouses { get; set; }

        public DatabaseContext() : base("AlquilerConnection")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }
        public new IDbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserLoginConfiguration());
            modelBuilder.Configurations.Add(new UserClaimConfiguration());
            modelBuilder.Configurations.Add(new RolConfiguration());
            modelBuilder.Configurations.Add(new UserRolConfiguration());

            modelBuilder.Configurations.Add(new EquipmentConfiguration());
            modelBuilder.Configurations.Add(new BodypartConfiguration()); 
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CityCountyConfiguration());
            modelBuilder.Configurations.Add(new CompositionConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ProjectConfiguration());
            modelBuilder.Configurations.Add(new StockConfiguration());
            modelBuilder.Configurations.Add(new WarehouseConfiguration());
        }
    }
}
