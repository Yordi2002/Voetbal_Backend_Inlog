using Interface.DTO;

namespace Interface.Interface
{
    public interface IUserContext
    {
        public UserDTO AttemptLogin(UserDTO userDTO);

    }
}
