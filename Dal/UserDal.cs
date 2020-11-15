using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;


namespace Dal
{
    public class UserDal
    {
        //פונקציה לעדכון פרטי משתמש
        public static users Update(users u)
        {
          using(ProjectEntities db =new ProjectEntities())
            {
                try
                {
                    users user = db.users.Where(us => us.Tz == u.Tz).FirstOrDefault();
                    user.lastName = u.lastName;
                    user.firstName = u.firstName;
                    user.city = u.city;
                    user.street = u.street;
                    user.mail = u.mail;
                    user.password = u.password;
                    user.phon = u.phon;
                    user.dateborn = u.dateborn;

                    //add all
                    db.SaveChanges();
                    return user;
                }
                catch (Exception e)
                {

                    return false;
                }
            }
        }
       

        //פונקציה להוספת משתמש חדש
        public static string Add(users u)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                 
                try
                {
                    //אם חוזר תעודת זהות הכוונה שהמשתמש רשום ויש לשלוח לכניסה
                    users usertz = db.users.Where(x => x.Tz == u.Tz).FirstOrDefault();
                    if(usertz!=null)
                    return "tz";

                    //אם חוזר סיסמא הסיסמא כבר בשימוש ויש לשנות סיסמא
                    users userpa = db.users.Where(x => x.Tz == u.Tz).FirstOrDefault();

                    return "password";

                    //אם חוזר אוקיי המשתמש נקלט בהצלחה
                    db.users.Add(u);
                    db.SaveChanges();
                    return "ok";
                }
                catch(Exception e)
                {
                    return "false";
                }
            }
        }

     

        //קבלת כל המדריכים

        public static List<users> GetAllVolenteer()
        {
            {
                using (ProjectEntities db = new ProjectEntities())

                    try
                    {
                  
                    List<users> users = db.users.Where(user => user.status == "volenteer").ToList();
                    return users;
                }
                catch (Exception e)
                {
                    return null;
                }
                return null;
            }
        }

        //קבלת נתוני מדריכה לפי id
        public static users GetVolenteerById(string Tz)
        {
            try
            {
                using (ProjectEntities db = new ProjectEntities())
                {
                    users v = db.users.Where(x => x.Tz == Tz).FirstOrDefault();
                    return v;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        //מחיקת משתמש
        public static bool Delete(string tz)
        {
            try
            {
                using (ProjectEntities db = new ProjectEntities())
                {
                    users u = db.users.Where(x => x.Tz == tz).FirstOrDefault();
                    db.users.Remove(u);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        

    }
}