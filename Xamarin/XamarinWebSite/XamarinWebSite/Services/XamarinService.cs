using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XamarinWebSite.Models;

namespace XamarinWebSite.Services
{
    public class XamarinService
    {

        //ekleme fonksiyonu
        public int addUser(USER user)
        {

            using (var context = new MyDatabaseEntities())
            {
                //if blogunda girilen  kullanicin olup olmadigi sorgulaniyor.  Kullanici yoksa ekleniyor.
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


        // silme fonksiyonu
        public int deleteUser(int id)
        {
            using (var context = new MyDatabaseEntities())
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

        // databasedeki kullanicilari almak icin kullandigimiz fonksiyon
        public USER[] getUsers()
        {
            using (var context = new MyDatabaseEntities())
            {
                USER[] users = context.USER.ToArray();

                //kullanici varsa kullanicilari dondurur. Yoksa null dondurur.
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
            using (var context = new MyDatabaseEntities())
            {
                return context.USER.Where(x => x.USERID == id).FirstOrDefault();
          }
        }


        //user tablosu icin login fonksiyonu
        public USER loginFunction(string username,string password)
        {
            using(var context = new MyDatabaseEntities())
            {
                //gondermis oldgum username ile db deki username ve password ile db deki password ayni ise itemi gonder
                return context.USER.Where(x=>x.USERNAME.Equals(username)&& x.PASSWORD.Equals(password)).FirstOrDefault();
            }
        }

    }

}