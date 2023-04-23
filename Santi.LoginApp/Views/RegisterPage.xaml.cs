namespace Santi.LoginApp.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;//Binding context da tela com a ViewModel
	}
}