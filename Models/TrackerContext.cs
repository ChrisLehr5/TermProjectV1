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
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Member>().HasData(
				new Member
                {
					ID= 1, 
					name= "Tim Largent"					
                },
				new Member
				{
					ID = 2,
					name = "Max Lehr",
					email = "mlehr@mail.com"
				},
				new Member
				{
					ID = 3,
					name = "Brett Macki"					
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