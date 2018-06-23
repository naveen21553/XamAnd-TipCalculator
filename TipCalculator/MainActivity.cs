using Android.App;
using Android.Widget;
using Android.OS;

namespace TipCalculator
{
	[Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
            TextView TipView = FindViewById<TextView>(Resource.Id.TipView);
            EditText BillAmount = FindViewById<EditText>(Resource.Id.BillAmount);
            Button billButton = FindViewById<Button>(Resource.Id.billButton);

            billButton.Click += delegate
            {
                double tip = double.Parse(BillAmount.Text) * 0.15;
                double total = tip + double.Parse(BillAmount.Text);
                string result = "Tip: " + (tip).ToString() + "\nTotal: " + total;
                TipView.Text = result;
            };
		}
	}
}


