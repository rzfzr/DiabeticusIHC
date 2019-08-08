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

namespace Diabeticus1
{
    [Activity(Label = "MainPage")]
    public class MainPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.main_page);


            Button btnnew = FindViewById<Button>(Resource.Id.addnew);
            btnnew.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(AddNew));
                StartActivity(nextActivity);
            };

            var btnagenda = FindViewById<Button>(Resource.Id.agenda);
            btnagenda.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(Agenda));
                StartActivity(nextActivity);
            };


            var btnSend1 = FindViewById<Button>(Resource.Id.button1);
            btnSend1.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(Graph));
                StartActivity(nextActivity);
            };


            var btnSend2 = FindViewById<Button>(Resource.Id.button2);
            btnSend2.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(Alarms));
                StartActivity(nextActivity);
            };
            var btnSend3 = FindViewById<Button>(Resource.Id.button3);
            btnSend3.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(Graph));
                StartActivity(nextActivity);
            };

        }
    }
}