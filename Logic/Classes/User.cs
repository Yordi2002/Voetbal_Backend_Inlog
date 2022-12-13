using Interface.DTO;
using System.Xml.Linq;

namespace Logic.Classes
{
    public class User
    {
        public int UserID { get; set; }
        public string Naam { get; set; }
        public string Wachtwoord { get; set; }

        public User()
        { }
        public User(UserDTO dto)
        {
            this.UserID = dto.UserID;
            this.Naam = dto.Naam;
            this.Wachtwoord = dto.Wachtwoord;
        }

        public User(int UserID, string Naam, string Wachtwoord)
        {
            this.UserID = UserID;
            this.Naam = Naam;
            this.Wachtwoord = Wachtwoord;
        }
        public UserDTO GetDTO()
        {
            UserDTO dto = new UserDTO(UserID, Naam, Wachtwoord);
            return dto;
        }
    }
}
