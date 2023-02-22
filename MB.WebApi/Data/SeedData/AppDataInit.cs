using MB.AuthDefinition.Entities.Identity;
using MB.PublicLibraries.String;
using MB.WebApi.Data.dbContext;
using Microsoft.AspNetCore.Identity;

namespace MB.WebApi.Data.SeedData
{

    public class AppDataInit
    {
        public static void SeedData(UserManager<Users> userManager, RoleManager<Roles> roleManager, mb_db_context _db)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
            //SeedSetting(_db);
        }

        public static void SeedUsers(UserManager<Users> userManager)
        {
            StringHelper string_Helper = new StringHelper();

            if (userManager.FindByNameAsync("admin").Result == null)
            {
                var user = new Users
                {
                    UserName = "admin",
                    Email = "admin@domain.com",
                    first_name = "مدیر",
                    last_name = "سیستم",
                    full_name = "راهبر سامانه",                    
                    pers_code = "admin",
                    EmailConfirmed = true,
                    birth_date = DateTime.Now,
                    mobile = "09131068814",
                    national_code = "1292707488",
                    PhoneNumber = "09131068814",
                    TwoFactorEnabled = false,
                    //address = "شرکت سوره",
                    PhoneNumberConfirmed = true,
                    tell = "09131068814",
                    AccessFailedCount = 0,
                    LockoutEnabled = false,
                    sys_code = $"Master-{string_Helper.RandomNumberString_Capital(12)}",
                };
                //PasswordHasher<Users> hasher = new PasswordHasher<Users>();

                //var pass = hasher.HashPassword(user, "123456");

                var result = userManager.CreateAsync(user, "P_mb@418600").Result;
                if (result.Succeeded)
                {
                    var result_ur = userManager.AddToRoleAsync(user, "Admin").Result;
                }
            }
        }

        public static void SeedRoles(RoleManager<Roles> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var role = new Roles
                {
                    Name = "Admin",
                    caption = "Master",
                    is_default = true,
                };
                var result = roleManager.CreateAsync(role).Result;
            }
            //if (!roleManager.RoleExistsAsync("Client").Result)
            //{
            //    var role = new Roles
            //    {
            //        Name = "Client",
            //        caption = "کاربر",
            //    };
            //    var result = roleManager.CreateAsync(role).Result;
            //}
        }

        //public static void SeedSetting(mb_db_context _db)
        //{            
        //    if (!_db.Setting.Any())
        //    {
        //        var setting = new Setting
        //        {
        //            website_name = SharedConstants.Website_Name,
        //            website_link= SharedConstants.Website_Link,
        //            master_mobile = SharedConstants.Master_Mobile,
        //            logo_file = SharedConstants.Logo_File,
        //            auth_pages_bgfile = SharedConstants.Auth_Pages_bgfile,
        //            email_username= SharedConstants.Email_Username,
        //            email_pass= SharedConstants.Email_Password,
        //            email_port= SharedConstants.Email_Port,
        //            add_date= DateTime.Now,
        //            is_deleted=false,
        //            is_lock=false,
        //        };
        //        _db.Setting.Add(setting);
        //        _db.SaveChanges();
        //    }            
        //}
    }
}
