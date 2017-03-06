using Android.App;
using Android.Widget;
using Android.OS;

namespace Modulo2_Licao1
{
	[Activity(Label = "App_M2_1", MainLauncher = true, Icon = "@drawable/android_icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//Atribui o btnConverter presente em Main.axml a variável btnConverter
			Button btnConverter = FindViewById<Button>(Resource.Id.btnConverter);
			//Atribui o txtDolares presente em Main.axml a variável txtDolares
			EditText txtDolares = FindViewById<EditText>(Resource.Id.txtdolares);
			//Atribui o txtReais presente em Main.axml a variável txtReais
			EditText txtReais = FindViewById<EditText>(Resource.Id.txtreais);

			double dolares, reais;

			btnConverter.Click += delegate
			{
				try
				{
					dolares = double.Parse(txtDolares.Text);
					reais = dolares * 4;
					txtReais.Text = reais.ToString();
				}
				catch (System.Exception ex)
				{
					Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
				}
			};

		}
	}
}

