using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Hoimi.Models
{
	public partial class HoimiDbContext : DbContext
	{
		public HoimiDbContext()
			: base("name=HoimiDbContext")
		{
		}

		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.Property(e => e.ProductName)
				.IsUnicode(false);
		}
	}
}
