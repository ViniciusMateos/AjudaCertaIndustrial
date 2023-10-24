using AjudaCertaIndustrial.ViewModels.Usuarios;

namespace AjudaCertaIndustrial.Views;

public partial class Aviso : ContentPage
{
	UsuarioViewModel usuarioViewModel;	
	public Aviso()
	{
		InitializeComponent();
		usuarioViewModel = new UsuarioViewModel();
		BindingContext = usuarioViewModel;
	}
}