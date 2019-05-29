using Android.App;
using Android.Views.InputMethods;
using SmartHotel.Clients.Core.Services.DismissKeyboard;
using SmartHotel.Clients.Droid.Services.DismissKeyboard;

[assembly: Xamarin.Forms.Dependency(typeof(DismissKeyboardService))]
namespace SmartHotel.Clients.Droid.Services.DismissKeyboard
{
    public class DismissKeyboardService : IDismissKeyboardService
    {
        public void DismissKeyboard()
        {
            var inputMethodManager = InputMethodManager.FromContext(Android.App.Application.Context);

            inputMethodManager.HideSoftInputFromWindow(
#pragma warning disable CS0618 // Type or member is obsolete
                ((Activity)Xamarin.Forms.Forms.Context).Window.DecorView.WindowToken, HideSoftInputFlags.NotAlways);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}