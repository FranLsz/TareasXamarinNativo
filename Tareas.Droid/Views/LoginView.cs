using Android.App;
using MvvmCross.Droid.Views;
using Tareas.Core.ViewModels;

namespace Tareas.Droid.Views
{
    [Activity(Label = "Login", MainLauncher = true)]
    public class LoginView : MvxActivity
    {
        public new LoginViewModel ViewModel
        {
            get { return (LoginViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.Login);
        }

        
    }
}