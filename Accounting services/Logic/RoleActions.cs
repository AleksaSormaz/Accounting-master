using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Accounting_services.Models;

namespace Accounting_services.Logic
{
    public class RoleActions
    {
        internal void AddUserAndRole()
        {
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleMgr = new RoleManager<IdentityRole>(roleStore);
            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "admin@accounting.com",
                Email = "admin@accounting.com"
            };

            IdUserResult = userMgr.Create(appUser, "adminPass1!");

            if (!userMgr.IsInRole(userMgr.FindByEmail("admin@university.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("admin@university.com").Id, "canEdit");
            }
        }
    }
}
