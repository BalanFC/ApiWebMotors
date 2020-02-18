using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraScructure
{
	public class WebMotorsDbContext: DbContext
	{
		public DbSet<AnuncioWebMotors> AnuncioWebMotors { get; set; }

		public WebMotorsDbContext(DbContextOptions<WebMotorsDbContext> options) 
			:base(options)
		{ }
	}
}

