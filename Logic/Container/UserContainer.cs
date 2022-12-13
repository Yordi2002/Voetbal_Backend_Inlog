using Interface.Interface;
using Logic.Classes;


namespace Logic.Container
{
    public class UserContainer
    {
        private readonly IUserContext _IUserContext;

        public UserContainer(IUserContext _context)
        {
            this._IUserContext = _context;
        }
        public User attemptLogin(User user)
        {
            User us = new User(_IUserContext.AttemptLogin(user.GetDTO()));
            return us;
        }
    }
}
