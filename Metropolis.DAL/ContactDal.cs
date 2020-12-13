﻿using Metropolis.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metropolis.DAL
{
    public class ContactDal : IContactDal
    {
        private readonly ApplicationDbContext _dbContext;

        public ContactDal(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Contact> AllContact()
        {
            return _dbContext.Contacts.ToList();

        }
    }
}