using System;
using System.Windows.Input;
using DataModel.ViewModel;
using MvvmCross.Core.ViewModels;
using Tareas.Core.Services;

namespace Tareas.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        // Commands
        public ICommand CmdLogin { get; set; }

        // Services
        private readonly IServicioDatos _servicioDatos;

        // Labels
        public string EmailLbl => "Email";
        public string PasswordLbl => "Password";
        public string LoginBtnLbl => "Entrar";

        // Specific
        private UsuarioModel _usuario;
        public UsuarioModel Usuario
        {
            get { return _usuario; }
            set { SetProperty(ref _usuario, value); }
        }

        public LoginViewModel(IServicioDatos servicioDatos)
        {
            _servicioDatos = servicioDatos;
            CmdLogin = new MvxCommand(RunLogin);
            _usuario = new UsuarioModel();
        }
        public async void RunLogin()
        {
            try
            {
                var us = await _servicioDatos.Validar(Usuario);

                if (us != null)
                {
                    ShowViewModel<HomeViewModel>();
                }
                else
                {
                    // No encontrado
                }
            }
            catch (Exception e)
            {
                // Error
            }
        }
    }
}