using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using WinUIExceptionHandling.ExceptionHandlres;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIExceptionHandling
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        //private readonly ApplicationExceptionHandler _applicationExceptionHandler;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            var _applicationExceptionHandler = new ApplicationExceptionHandler();

            Ioc.Default.ConfigureServices(
                new ServiceCollection()
               .AddSingleton<IApplicationExceptionHandler>(_applicationExceptionHandler)
               .AddSingleton<MainWindow>()
               .BuildServiceProvider());
            
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            m_window = Ioc.Default.GetRequiredService<MainWindow>();
            m_window.Activate();
        }

        private Window m_window;
    }
}
