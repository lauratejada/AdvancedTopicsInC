using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using IntroToUsers_Lab5.Models;
using Microsoft.AspNetCore.Identity;

namespace IntroToUsers_Lab5.Areas.Identity.Data;

// Add profile data for application users by adding properties to the DemoUser class
public class DemoUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    // Navigation property for user's accounts
    public HashSet<Account> Accounts { get; set; } = new HashSet<Account>();
}

