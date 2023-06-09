﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext  
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-OCEEADF; Database=MyTodoDb; User Id=sa; Password=123456; TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author {Id = 1, FullName="Bhagya Dilhara",AddressNo = "55",Street = "Street 1", City = "Maharagama", JobRole ="Developer"},
                new Author {Id = 2, FullName="Mahima Induvara",AddressNo = "100",Street = "Street 2", City = "Pannipitiya", JobRole = "QA"},
                new Author {Id = 3, FullName="Chanuka Supun",AddressNo = "64/2",Street = "Street 3", City = "Kottawa", JobRole ="Developer"},
                new Author {Id = 4, FullName="Bhathunu Bhagya",AddressNo = "666",Street = "Street 4", City = "Piliyandala", JobRole ="System Engineer"}
            });


            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                    Id = 1,
                    Title = "Get books for school - DB",
                    Description = "Test description 1",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo
                {
                    Id = 2,
                    Title = "Do office works - DB",
                    Description = "Test description 2",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 2
                },
                new Todo
                {
                    Id = 3,
                    Title = "Do home works - DB",
                    Description = "Test description 3",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 3
                }
            });
        }
    }
}
