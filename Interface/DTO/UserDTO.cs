namespace Interface.DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string Naam { get; set; }
        public string Wachtwoord { get; set; }
        public UserDTO(int UserID, string Naam, string Wachtwoord)
        {
            this.UserID = UserID;
            this.Naam = Naam;
            this.Wachtwoord = Wachtwoord;
        }
        public UserDTO() { }
    }
}
