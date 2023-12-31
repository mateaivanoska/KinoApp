﻿using ECinemaTicket.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECinemaTicket.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<ECinemaApplicationUser> GetAll();

        ECinemaApplicationUser Get(string id);

        void Insert(ECinemaApplicationUser entity);

        void Update(ECinemaApplicationUser entity);

        void Delete(ECinemaApplicationUser entity);
    }
}
