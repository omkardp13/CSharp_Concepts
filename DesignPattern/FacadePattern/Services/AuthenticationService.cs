namespace FacadeDesignPatter.Services
{
    public class AuthenticationService
    {
        public bool Authenticate(string username, string password)
        {
            // Simulate authentication logic
            return username == "admin" && password == "password";
        }
    }

}
