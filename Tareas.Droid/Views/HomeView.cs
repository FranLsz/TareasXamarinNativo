using Android.App;
using MvvmCross.Droid.Views;
using Tareas.Core.ViewModels;

namespace Tareas.Droid.Views
{
    [Activity(Label = "Home", MainLauncher = false)]
    public class HomeView : MvxActivity
    {
        public new HomeViewModel ViewModel
        {
            get { return (HomeViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.Home);
        }
    }
}