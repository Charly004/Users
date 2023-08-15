using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_User
    {

        public static List<User> ShowUser()
        {
            using (var db = new UserContext())
            {
                return db.users.ToList();
            }
        }

        public static User UserById(string id)
        {
            using (var db = new UserContext())
            {
                return db.users.ToList().LastOrDefault(p=>p.UserId==id);
            }
        }

        public static void CreateUser(User user_m)
        {
            using(var db = new UserContext())
            {
                db.users.Add(user_m);
                db.SaveChanges();
            }
        }

        public static void UpdateUser(User user_m)
        {
            using(var db = new UserContext())
            {
                
                db.users.Update(user_m);
                db.SaveChanges();
            }
        }

        public static User DeleteById(string id)
        {
            using (var db = new UserContext())
            {
                return db.users.ToList().LastOrDefault(p => p.UserId == id);
            }
        }

        public static void DeleteUser(User user_m)
        {
            using (var db = new UserContext())
            {
                db.users.Remove(user_m);
                db.SaveChanges();
            }
        }


    }
}
