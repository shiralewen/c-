using Dal;
using Dto;
using System;
using System.Collections.Generic;

namespace BL
{
    public class UserBl
    {

        //פונקצית עדכון
        public static UserDto Update(UserDto u)
        {
            users use = UserDto.Todal(u);
            users usernew = Dal.users.Update(use);
           return new Dto.UserDto(usernew);
            
        }

        //פונקצית הוספה
        public static string Add(UserDto u)
        {
            users user = UserDto.Todal(u);
            return Dal.UserDal.Add(user);
        }

        //פונקציה לקבלת כל המתנדבות
        public static List<UserDto> GetAllVolenteer()
        {
            List<users> Volenteers = Dal.UserDal.GetAllVolenteer();
            List<UserDto> volenteersList = Dto.UserDto.ToDto(Volenteers);
            return volenteersList;
        }

        //פונקתיה לקבלת פרטי מתנדבת לפי תז
        public static UserDto GetVolenteerById(string Tz)
        {
            users user = Dal.UserDal.GetVolenteerById(Tz);
            UserDto userdto = new UserDto(user);
            return userdto;
        }

        public static bool Delete(string tz)
        {
            return Dal.UserDal.Delete(tz);
        }
    }
}