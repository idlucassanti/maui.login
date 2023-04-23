namespace Santi.LoginApp.Models.Register
{
    public class RegisterResponse
    {
        public RegisterResponse(bool success)
        {
            Success = success;    
        }

        public bool Success { get; set; }
    }
}
