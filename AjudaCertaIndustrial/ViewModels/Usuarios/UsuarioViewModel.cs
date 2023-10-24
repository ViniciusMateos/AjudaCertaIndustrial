using AjudaCertaIndustrial.Models;
using AjudaCertaIndustrial.Services.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AjudaCertaIndustrial.ViewModels.Usuarios
{
    public class UsuarioViewModel : BaseViewModel
    {
        private PessoaService pService;
        public ICommand RegistrarPessoaCommand { get; set; }
        public ICommand DirecionarCadastroCommand { get; set; }
        public ICommand DirecionarInicioCommand { get; set; }
        public ICommand DirecionarAvisoCommand { get; set; }
        public ICommand DirecionarFeedCommand { get; set; }
        public ICommand DirecionarDoacaoCommand { get; set; }
        public ICommand DirecionarAgradCommand { get; set; }
        public ICommand ReiniciarCommand { get; set; }
        public UsuarioViewModel()
        {
            pService = new PessoaService();
            InicializarCommands();
        }

        public void InicializarCommands() 
        {
            DirecionarCadastroCommand = new Command(async () => await DirecionarParaCadastro());
            RegistrarPessoaCommand = new Command(async () => await RegistrarPessoa());
            DirecionarInicioCommand = new Command(async () => await DirecionarParaInicio());
            DirecionarAvisoCommand = new Command(async () => await DirecionarParaAviso());
            DirecionarDoacaoCommand = new Command(async () => await DirecionarParaDoacao());
            DirecionarFeedCommand = new Command(async () => await DirecionarParaFeed());
            DirecionarAgradCommand = new Command(async () => await DirecionarParaAgradecimento());
            ReiniciarCommand = new Command(async () => await ReiniciarApp());
        }

        #region AtributosPropriedades

        private string nome = string.Empty;
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                OnPropertyChanged();
            }
        }

        private DateTime datanasc = DateTime.Now;
        public DateTime Datanasc
        {
            get { return datanasc; }
            set
            {
                datanasc = value;
                OnPropertyChanged();
            }
        }

        private string genero = string.Empty;
        public string Genero
        {
            get { return genero; }
            set
            {
                genero = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Métodos
        
        public async Task RegistrarPessoa()
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Nome = Nome;
                p.Genero = Genero;
                p.DataNasc = Convert.ToDateTime(Datanasc);

                Pessoa pRegistrado = await pService.PostRegistrarPessoaAsync(p);
                if (pRegistrado.Id != 0)
                {
                    await Application.Current.MainPage
                        .Navigation.PushAsync(new Views.Feed());
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }

        public async Task DirecionarParaAviso()
        {
            try 
            {
                await Application.Current.MainPage
                    .Navigation.PushAsync(new Views.Aviso());
            }
            catch (Exception ex) 
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }
        public async Task DirecionarParaCadastro() 
        {
            try
            {
                await Application.Current.MainPage
                    .Navigation.PushAsync(new Views.Cadastro());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }

        public async Task DirecionarParaAgradecimento()
        {
            try
            {
                await Application.Current.MainPage
                    .Navigation.PushAsync(new Views.Agradecimentos());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }

        public async Task DirecionarParaInicio()
        {
            try
            {
                await Application.Current.MainPage
                    .Navigation.PushAsync(new Views.TelaInicial());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }
        
        public async Task ReiniciarApp()
        {
            try
            {
                await Application.Current.MainPage
                   .Navigation.PushAsync(new Views.TelaInicial());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }
        public async Task DirecionarParaDoacao()
        {
            try
            {
                await Application.Current.MainPage
                    .Navigation.PushAsync(new Views.DoacaoPix());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }

        public async Task DirecionarParaFeed()
        {
            try
            {
                await Application.Current.MainPage
                    .Navigation.PushAsync(new Views.Feed());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }
        #endregion
    }
}
