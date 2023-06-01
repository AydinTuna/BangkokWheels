﻿using System;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace ECommerce.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}

