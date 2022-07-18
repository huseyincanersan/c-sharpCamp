using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XamarinApi.Models;

namespace XamarinApi.Services
{
    public class XamarinService
    {

        //Kullanici ekleme
        public int addUser(USER user)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                if (context.USER.Where(x => x.USERNAME == user.USERNAME).FirstOrDefault() == null)
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

        //Police Ekleme
        public int addPolicy(POLICY policy)
        {
            using (var context = new XamarinDatabaseEntities1())
            {

                POLICY p = context.POLICY.Add(policy);
                context.SaveChanges();
                return p.POLICYID;



            }
        }

        //Police silme
        public int deletePolicy(int id)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                POLICY p = context.POLICY.Where(x => x.POLICYID == id).FirstOrDefault();
                if (p == null)
                {
                    return 0;
                }
                else
                {
                    context.POLICY.Remove(p);
                    context.SaveChanges();
                    return 1;
                }

            }
        }

        //Kullanici silme
        public int deleteUser(int id)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                USER u = context.USER.Where(x => x.USERID == id).FirstOrDefault();
                if (u == null)
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


        //police goruntuleme
        public POLICY[] getPolicies()
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                POLICY[] policies = context.POLICY.ToArray();
                if (policies.Length > 0)
                {
                    return policies;
                }
                else
                {
                    return null;
                }
            }
        }


        //Kullanici Goruntuleme
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

        //ID ye gore kullanici goruntuleme
        public USER getUserById(int id)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                return context.USER.Where(x => x.USERID == id).FirstOrDefault();

            }
        }

        //kullanici adi ve parolanin dogruluguna gore kullanici verilerini getirme
        public USER loginFunction(string username, string password)
        {
            using (var context = new XamarinDatabaseEntities1())
            {
                return context.USER.Where(x => x.USERNAME.Equals(username) && x.PASSWORD.Equals(password)).FirstOrDefault();
            }
        }


    }
}