using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TermProjectV1.Models
{
    public class TrackerContext : DbContext
    {

		public TrackerContext(DbContextOptions<TrackerContext> options): base(options)
		{ }
		public DbSet<Member> Membership { get; set; }
		public DbSet<Details> Statistics { get; set; }
		public DbSet<Reference> References { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<Reference>().HasData(
				new Reference
				{
					ReferenceId = 1,
					Name = "Brett Macki",
					LastName = "Frank",
					ID = 2, 					
				},
				new Reference
				{
					ReferenceId = 2,
					Name = "Tim Largent",
					LastName = "Frank",
					ID = 3
				},
				new Reference
				{
					ReferenceId = 3,
					Name = "Max Lehr",
					LastName = "Frank",
					ID = 1
				}
				);

			modelBuilder.Entity<Member>().HasData(
				new Member
                {
					ID = 1, 
					name= "Tim Largent",
					LastName = "Frank"
                },
				new Member
				{
					ID = 2,
					name = "Max Lehr",
					LastName = "Frank",
					email = "mlehr@mail.com"
				},
				new Member
				{
				ID= 3,
					name = "Brett Macki",
					LastName = "Frank"
				}
			 );
			modelBuilder.Entity<Details>().HasData(
				new Details
				{
					ID = 1,
					age = 34,
					MemberID= 1
				},
				new Details
				{
					ID = 2,
					age = 31,
					MemberID = 2
				},
				new Details
				{
					ID = 3,
					age = 37,
					MemberID = 3
				}
			 );
		}

	}
}