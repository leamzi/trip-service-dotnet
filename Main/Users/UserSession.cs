using Main.Exceptions;

namespace Main.Users
{
    public class UserSession
    {
        private static readonly UserSession userSession = new UserSession();
	
        private UserSession() {
        }
	
        public static UserSession GetInstance() {
            return userSession;
        }

        public User GetLoggedUser() {
            throw new CollaboratorCallException(
                "UserSession.getLoggedUser() should not be called in an unit test");
        }
    }
}