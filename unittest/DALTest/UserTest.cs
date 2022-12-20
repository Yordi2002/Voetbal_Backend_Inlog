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
            for(var i =0; i < UserDTOs.Count; i++)
            {
                if (UserDTOs[i].Naam == userDTO.Naam)
                {
                    if (UserDTOs[i].Wachtwoord == userDTO.Wachtwoord)
                    {
                        return userDTO;
                    }
                }
            }
            return new UserDTO() { UserID = 0, Naam = "", Wachtwoord = "" };
        }
    }
}