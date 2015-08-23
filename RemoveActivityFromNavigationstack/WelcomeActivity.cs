using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;

namespace RemoveActivityFromNavigationstack
{
    [Activity(Label = "RemoveActivityFromNavigationstack", MainLauncher = true, Icon = "@drawable/icon")]
    public class WelcomeActivity : Activity
    {
        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Welcome);

            // Do some meaninthing stuff here, or just wait for 3 seconds...
            await Task.Delay(3000);

            var intent = new Intent(this, typeof(MainActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
            Finish();
        }
    }
}