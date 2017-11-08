using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace tipcalculator
{
    [Activity(Label = "tipcalculator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button calculatebutton = FindViewById<Button>(Resource.Id.button1);
            EditText amount = FindViewById<EditText>(Resource.Id.editText1);
            EditText percentage = FindViewById<EditText>(Resource.Id.editText2);
            TextView totaltotal = FindViewById<TextView>(Resource.Id.textView6);
            TextView tiptotal = FindViewById<TextView>(Resource.Id.textView7);

            calculatebutton.Click += (sender, e) =>
            {
                double tippage = Core.Calculate.Tips(Convert.ToDouble(amount.Text), Convert.ToDouble(percentage.Text));
                tiptotal.Text = tippage.ToString();
                double t = Convert.ToDouble(amount.Text) + tippage;
                totaltotal.Text = t.ToString();



            };
        }
    }
}

