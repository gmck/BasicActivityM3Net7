using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.Core.View;
using AndroidX.Navigation;
using AndroidX.Navigation.Fragment;
using AndroidX.Navigation.UI;
using Google.Android.Material.AppBar;

namespace com.companyname.basicactivitym3net7
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private AppBarConfiguration? appBarConfiguration;
        private NavController? navController;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            WindowCompat.SetDecorFitsSystemWindows(Window!, false);

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            MaterialToolbar? toolbar = FindViewById<MaterialToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            //navController = FindNavController(Resource.Id.nav_host_fragment_content_main);
            NavHostFragment? navHostFragment = SupportFragmentManager.FindFragmentById(Resource.Id.nav_host_fragment_content_main) as NavHostFragment;
            navController = navHostFragment!.NavController;


            appBarConfiguration = new AppBarConfiguration.Builder(navController.Graph).Build();
            NavigationUI.SetupActionBarWithNavController(this, navController, appBarConfiguration);
        }

        public override bool OnSupportNavigateUp()
        {
            return NavigationUI.NavigateUp(navController!, appBarConfiguration!) || base.OnSupportNavigateUp();
        }
    }
}