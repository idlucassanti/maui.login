namespace Santi.LoginApp.Models.Register
{
    public class RegisterRequest
    {
        public RegisterRequest(string nomeCompleto, string email, string senha)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            Senha = senha;
        }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
