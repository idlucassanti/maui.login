using Flurl;
using Flurl.Http;
using Santi.LoginApp.Interfaces.Services;
using Santi.LoginApp.Models.Register;
using Santi.LoginApp.Options;

namespace Santi.LoginApp.Services
{
    public class RegisterService : IRegisterService
    {
        public async Task<bool> CriarConta(RegisterRequest registerRequest)
        {
            try
            {
                //var response = await Settings.BASE_URL.AppendPathSegment("/register").PostJsonAsync(registerRequest);


                //return response.ResponseMessage.IsSuccessStatusCode;

                await Task.Delay(3000);

                return true;
            }
            catch (FlurlHttpException ex)
            {

                Console.WriteLine(ex.Message);
            }

            return false;            
        }
    }
}
