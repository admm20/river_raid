using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace RiverRaidAndroid
{
#if ANDROID
    [Activity(Label = "RiverRaidAndroid"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = Android.Content.PM.LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.Landscape
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize | ConfigChanges.ScreenLayout)]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var g = new RiverRaid.RiverRaidGame();
            SetContentView((View)g.Services.GetService(typeof(View)));
            
            g.Run();
        }
    }
#endif
}

