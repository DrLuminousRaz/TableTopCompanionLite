using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TableTopCompanionLite
{
    [Activity(Label = "TableTopCompanionLite", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var spinner = FindViewById<Spinner>(Resource.Id.spinner);
            var button = FindViewById<Button>(Resource.Id.button);
            var text = FindViewById<TextView>(Resource.Id.result);
            spinner.Prompt = "Choose A Dice";
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.Counter, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
            button.Click += delegate
            {

                switch (spinner.SelectedItem.ToString())
                {

                    case "D4":

                        text.Text = ("D4: " + Roll.Roll.D4().ToString());
                        break;
                    case "D6":

                        text.Text = ("D6: " + Roll.Roll.D6().ToString());
                        break;
                    case "D8":
  
                        text.Text = ("D8: " + Roll.Roll.D8().ToString());
                        break;
                    case "D10":

                        text.Text = ("D10: " + Roll.Roll.D10().ToString());
                        break;
                    case "D10 Percentile":

                        text.Text = ("D10 Percentile: " + Roll.Roll.D10Pecentile().ToString());
                        break;
                    case "D12":

                        text.Text = ("D12: " + Roll.Roll.D12().ToString());
                        break;
                    case "D20":

                        text.Text = ("D20: " + Roll.Roll.D20().ToString());
                        break;


                }
            };
        }
    }
    }


