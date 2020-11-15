using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
 public   class UserDto
    {
        public int userCode { get; set; }
        public string Tz { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string phon { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public System.DateTime dateborn { get; set; }
        public string status { get; set; }
        public Nullable<bool> isAviable { get; set; }

        public UserDto()
        {
                
        }

        public static List<UserDto> ToDto(List<users> volenteers)
        {
            List<UserDto> lusers = new List<UserDto>();
            foreach (users user in volenteers)
            {
                UserDto u = new UserDto(user);
                lusers.Add(u);
            }
            return lusers;
        }
        public UserDto(users u)
        {
            userCode = u.userCode;
            Tz = u.Tz;
            lastName = u.lastName;
            
        }
       

        public static users Todal(UserDto u)
        {
            return new Dal.users
            {
                lastName = u.lastName,
                firstName = u.firstName,
                city = u.city,
                street = u.street,
                mail = u.mail,
                password = u.password,
                phon = u.phon,
                dateborn = u.dateborn

            };
        }
    }
}
