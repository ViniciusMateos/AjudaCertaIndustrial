
using AjudaCertaIndustrial.ViewModels.Usuarios;
using System.Runtime.CompilerServices;

namespace AjudaCertaIndustrial.Views;

public partial class TelaInicial : ContentPage
{
	UsuarioViewModel usuarioViewModel;
	public TelaInicial()
	{
		InitializeComponent();
		usuarioViewModel = new UsuarioViewModel();
		BindingContext = usuarioViewModel;
	}
}