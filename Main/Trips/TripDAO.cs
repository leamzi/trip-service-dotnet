using System.Collections.Generic;
using Main.Exceptions;
using Main.Users;

namespace Main.Trips
{
    public class TripDAO
    {
        public static List<Trip> FindTripsByUser(User user) {
            throw new CollaboratorCallException("TripDAO should not be invoked on an unit test.");
        }   
    }
}