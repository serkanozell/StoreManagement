using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public static class Message
    {
        public static string AuthorizationDenied = "Authorization Denied!!!";
        public static string TokenCreated = "Token Created";
        public static string PersonnelRegistered = "Personnel Registered";
        public static string Added = "Added";
        public static string Deleted = "Deleted";
        public static string Updated = "Updated";
        public static string PersonnelNotFound = "Personnel Not Found";
        public static string PasswordError = "Password Error";
        public static string PersonnelExist = "Personnel Already Exist";
        public static string LoginSuccessfull = "Successfull Login";
    }
}
