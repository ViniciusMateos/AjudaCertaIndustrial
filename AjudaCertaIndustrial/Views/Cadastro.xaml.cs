using AjudaCertaIndustrial.ViewModels.Usuarios;

namespace AjudaCertaIndustrial.Views;

public partial class Cadastro : ContentPage
{
	UsuarioViewModel usuarioViewModel;
	public Cadastro()
	{
		InitializeComponent();
		usuarioViewModel = new UsuarioViewModel();
		BindingContext = usuarioViewModel;
	}
}