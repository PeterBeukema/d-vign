namespace dvign.Droid
{
	using Android.App;
	using Android.Content.PM;
	using Android.OS;

	[Activity (Label = "d-vign.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
		}
	}
}

