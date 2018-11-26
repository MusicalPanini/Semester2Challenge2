namespace Sem2Challenge2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NewModel : DbContext
    {
        public NewModel()
            : base("name=NewModel")
        {
        }
        public virtual DbSet<GameModels> GameModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
