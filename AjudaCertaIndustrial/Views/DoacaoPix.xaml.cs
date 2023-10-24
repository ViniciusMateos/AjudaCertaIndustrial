using AjudaCertaIndustrial.ViewModels.Usuarios;

namespace AjudaCertaIndustrial.Views;

public partial class DoacaoPix : ContentPage
{
	UsuarioViewModel usuarioViewModel;
	public DoacaoPix()
	{
		InitializeComponent();
		usuarioViewModel = new UsuarioViewModel();
		BindingContext = usuarioViewModel;
	}
}