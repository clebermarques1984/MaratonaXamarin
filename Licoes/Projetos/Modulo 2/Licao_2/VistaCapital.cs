using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Licao2
{
	[Activity(Label = "VistaCapital")]
	public class VistaCapital : Activity
	{
		double defaultValue;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.VistaCapital);

			Button btnSair = FindViewById<Button>(Resource.Id.btnSair);
			EditText txtCapitalM = FindViewById<EditText>(Resource.Id.txtCapitalM);
			EditText txtCapitalC = FindViewById<EditText>(Resource.Id.txtCapitalC);

			try
			{
				txtCapitalM.Text = Intent.GetDoubleExtra("CapitalM", defaultValue).ToString();
				txtCapitalC.Text = Intent.GetDoubleExtra("CapitalC", defaultValue).ToString();
			}
			catch (Exception ex)
			{
				Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
			}

			btnSair.Click += delegate
			{
				try
				{
					Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
				}
				catch (System.Exception ex)
				{
					Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
				}
			};
		}
	}
}