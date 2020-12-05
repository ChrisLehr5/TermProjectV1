using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TermProjectV1.Models;


namespace TermProjectV1.Models
{
    public class TrackerContext : DbContext
    {

		public TrackerContext(DbContextOptions<TrackerContext> options): base(options)
		{ }
		public DbSet<Member> Membership { get; set; }
		public DbSet<Details> Statistics { get; set; }
		public DbSet<Reference> References { get; set; }		
		public DbSet<MemberReference> MemberReferences { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<Reference>().HasData(
				new Reference
				{
					ReferenceId = 1,
					Name = "Brett",
					LastName = "Macki",
					ID = 2,
				},
				new Reference
				{
					ReferenceId = 2,
					Name = "Tim",
					LastName = "Largent",
					ID = 3
				},
				new Reference
				{
					ReferenceId = 3,
					Name = "Max ",
					LastName = "Lehr",
					ID = 1
				}
				);

			modelBuilder.Entity<Member>().HasData(
				new Member
				{
					ID = 1,
					name = "Tim",
					LastName = "Largent"
				},
				new Member
				{
					ID = 2,
					name = "Max",
					LastName = "Lehr",
					email = "mlehr@mail.com"
				},
				new Member
				{
					ID = 3,
					name = "Brett",
					LastName = "Macki"
				}
			 );
			modelBuilder.Entity<Details>().HasData(
				new Details
				{
					ID = 1,
					age = 34,
					MemberID = 1
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
			modelBuilder.Entity<MemberReference>().HasData(
				new MemberReference { ID = 1, MemberID = 1, ReferenceID = 1 },
				new MemberReference { ID = 2, MemberID = 2, ReferenceID = 2 },
				new MemberReference { ID = 3, MemberID = 3, ReferenceID = 3 }
			);
		}
		public DbSet<TermProjectV1.Models.MemberReference> MemberReference { get; set; }

	}
}