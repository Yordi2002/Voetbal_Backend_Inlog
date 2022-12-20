using Interface.DTO;
using Interface.Interface;
using System.Collections.Generic;

namespace UnitTest.DALTest
{
    public class user : IUserContext
    {

        public List<UserDTO> UserDTOs = new List<UserDTO>()
        {
            new UserDTO(){UserID=1, Naam = "test", Wachtwoord = "123"},
            new UserDTO(){UserID=2, Naam = "TEST", Wachtwoord = "000"}
        };



        public UserDTO AttemptLogin(UserDTO userDTO)
        {
            return userDTO;
        }
    }
}