namespace HealthAxis3.Admin.Service
{
    public class AuthService
    {
        private bool _isAuthenticated = false;

        private const string HardcodedPassword = "admin123";

        public bool IsAuthenticated => _isAuthenticated;

        public bool Login(string password)
        {
            if (password == HardcodedPassword)
            {
                _isAuthenticated = true;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            _isAuthenticated = false;
        }
    }
}
