using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace AppAndroid1
{
    [Activity(Label = "AppAndroid1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            EditText textEntry = FindViewById<EditText>(Resource.Id.textView1);
            textEntry.Text = "Button Click is working";
        }
    }
}

