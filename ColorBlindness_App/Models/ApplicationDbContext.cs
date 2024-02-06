﻿using Microsoft.EntityFrameworkCore;

namespace ColorBlindness_App.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
    }
}
