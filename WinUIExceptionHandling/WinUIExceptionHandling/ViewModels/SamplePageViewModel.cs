using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading;
using System.Threading.Tasks;
using WinUIExceptionHandling.Exceptions;

namespace WinUIExceptionHandling.ViewModels
{
    public partial class SamplePageViewModel : ObservableRecipient
    {
        [ICommand]
        public void NormalThrow()
        {
            throw new SampleException("Sample");
        }

        [ICommand]
        public async Task ThrownOnTaskAsync()
        {
            Task t = Task.Run(() =>
            {
                throw new SampleException("Sample");
            });
            t.Start();
        }

        [ICommand]
        public async Task ThrownOnThreadAsync()
        {
            Thread t = new Thread(() =>
            {
                throw new SampleException("Sample");
            });
            t.Start();
        }
    }
}
