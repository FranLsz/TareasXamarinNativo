using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Tareas.Core.Services;
using Tareas.Core.ViewModels;

namespace Tareas.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IServicioDatos, ServicioDatos>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<LoginViewModel>());
        }
    }
}