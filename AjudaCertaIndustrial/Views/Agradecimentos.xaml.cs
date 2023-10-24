using AjudaCertaIndustrial.ViewModels.Usuarios;

namespace AjudaCertaIndustrial.Views;

public partial class Agradecimentos : ContentPage
{
	UsuarioViewModel usuarioViewModel;
	public Agradecimentos()
	{
		InitializeComponent();
		usuarioViewModel = new UsuarioViewModel();
		BindingContext = usuarioViewModel;
	}
}