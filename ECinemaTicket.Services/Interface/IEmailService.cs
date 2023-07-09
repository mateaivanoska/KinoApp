﻿using ECinemaTicket.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECinemaTicket.Services.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(List<EmailMessage> allMails);
    }
}
