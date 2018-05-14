﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace PolyNavi
{
	[Activity(
		Label = "PolyNavi",
		ScreenOrientation = ScreenOrientation.Portrait,
		ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
	public class CopyrightActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			MainApp.ChangeLanguage(this);
			SetTheme(Resource.Style.MyAppTheme);
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_map_routing);

			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar_route);
			SetSupportActionBar(toolbar);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);

			Title = GetString(Resource.String.title_copyright_activity);

			// Create your application here
		}

		public override bool OnSupportNavigateUp()
		{
			Finish();
			return true;
		}
	}
}