using System.Collections.Generic;
using Rently.Models;

namespace Rently.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Rently.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

//        protected override void Seed(Rently.Models.ApplicationDbContext context)
//        {
//            context.Customers.AddOrUpdate(c => c.Id, new Customer
//                {
//                    Name = "Giuseppe",
//                    MembershipTypeId = 1,
//                    IsSubscribedToNewsletter = Convert.ToBoolean("false"),
//                    Birthdate = DateTime.Parse("1989-03-11")
//                },
//                new Customer
//                {
//                    Name = "Peppe",
//                    MembershipTypeId = 2,
//                    IsSubscribedToNewsletter = Convert.ToBoolean("true"),
//                    Birthdate = DateTime.Parse("1989-03-11")
//                }
//            );
//            context.Movies.AddOrUpdate(m => m.Id, new Movie
//                {
//                    Name = "Rambo",
//                    GenreId = 1,
//                    DateAdded = DateTime.Parse("1989-03-11"),
//                    NumberInStock = 10,
//                },
//                new Movie
//                {
//                    Name          = "Rambo",
//                    GenreId       = 1,
//                    DateAdded     = DateTime.Parse("1989-03-11"),
//                    NumberInStock = 10,
//                }
//            );
//            context.Genres.AddOrUpdate(g => g.Id, new Genre
//            {
//             Name = "Action",
//
//            },
//            new Genre
//            {
//             Name = "Family",
//
//            },
//              new Genre
//            {
//             Name = "Thriller",
//
//            },
//              new Genre
//            {
//              Name = "Romance",
//            }, 
//              new Genre
//            {
//               Name = "Comedy",
//            }
//            );

        }
    }



