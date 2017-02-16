using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace Licao2
{
	[Activity(Label = "App_M2_2", MainLauncher = true, Icon = "@drawable/android_icon")]
	public class MainActivity : Activity
	{
		double capitalM, capitalC;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			Button btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);
			EditText txtReceitaM = FindViewById<EditText>(Resource.Id.txtReceitaM);
			EditText txtDespesaM = FindViewById<EditText>(Resource.Id.txtDespesaM);
			EditText txtReceitaC = FindViewById<EditText>(Resource.Id.txtReceitaC);
			EditText txtDespesaC = FindViewById<EditText>(Resource.Id.txtDespesaC);


			btnCalcular.Click += delegate
			{
				try
				{
					capitalM = double.Parse(txtReceitaM.Text) - double.Parse(txtDespesaM.Text);
					capitalC = double.Parse(txtReceitaC.Text) - double.Parse(txtDespesaC.Text);
					Carregar();
				}
				catch (System.Exception ex)
				{
					Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
				}
			};
		}

		private void Carregar()
		{
			Intent objIntent = new Intent(this, typeof(VistaCapital));
			objIntent.PutExtra("CapitalM", capitalM);
			objIntent.PutExtra("CapitalC", capitalC);
			StartActivity(objIntent);
		}
	}
}

