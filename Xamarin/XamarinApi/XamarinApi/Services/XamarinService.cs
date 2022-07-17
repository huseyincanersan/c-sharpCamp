using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XamarinApi.Models;

namespace XamarinApi.Services
{
    public class XamarinService
    {
        public int addUser(USER user)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                if (context.USER.Where(x=> x.USERNAME==user.USERNAME).FirstOrDefault()==null)
                {
                    USER u = context.USER.Add(user);
                    context.SaveChanges();
                    return u.USERID;

                }
                else
                {
                    return 0;
                }
            }
        }

        public int deleteUser(int id)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                USER u = context.USER.Where(x => x.USERID == id).FirstOrDefault();
                if (u==null)
                {
                    return 0;
                }
                else
                {
                    context.USER.Remove(u);
                    context.SaveChanges();
                    return 1;
                }

            }
        }

        public USER[] getUsers()
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                USER[] users = context.USER.ToArray();
                if (users.Length > 0)
                {
                    return users;
                }
                else
                {
                    return null;
                }
            }
        }

        public USER getUserById(int id)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                return context.USER.Where(x => x.USERID == id).FirstOrDefault();
               
            }
        }

        public USER loginFunction(string username,string password)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                return context.USER.Where(x=> x.USERNAME.Equals(username) && x.PASSWORD.Equals(password)).FirstOrDefault();
            }
        }


    }
}