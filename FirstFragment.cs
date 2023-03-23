using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Navigation;

namespace com.companyname.basicactivitym3net7
{
    public class FirstFragment : Fragment
    {

        public FirstFragment() { }

        #region OnCreateView
        public override View OnCreateView(LayoutInflater inflater, ViewGroup? container, Bundle? savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            View? view = inflater.Inflate(Resource.Layout.fragment_first, container, false);
            Button? buttonFirst = view!.FindViewById<Button>(Resource.Id.button_first);

            buttonFirst!.Click += (sender, args) => {
                Navigation.FindNavController(Activity!, Resource.Id.nav_host_fragment_content_main).Navigate(Resource.Id.action_FirstFragment_to_SecondFragment);
            };

            return view;
        }
        #endregion
    }
}
