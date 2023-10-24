using AjudaCertaIndustrial.ViewModels.Usuarios;

namespace AjudaCertaIndustrial.Views;

public partial class Feed : ContentPage
{
	UsuarioViewModel usuarioViewModel;
	public Feed()
	{
		InitializeComponent();
		usuarioViewModel = new UsuarioViewModel();
		BindingContext = usuarioViewModel;
	}
}