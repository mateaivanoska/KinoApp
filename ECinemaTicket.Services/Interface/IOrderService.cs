﻿using ECinemaTicket.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECinemaTicket.Services.Interface
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();

        Order GetOrderDetails(BaseEntity model);
    }
}
