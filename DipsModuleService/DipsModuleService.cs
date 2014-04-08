using System;
using Android.Util;
using System.Collections.Generic;

namespace DipsModuleService
{	
	[Android.App.Service]
	public class DipsModuleService : Android.App.Service
	{
		System.Threading.Timer _timer;

		public override void OnStart (Android.Content.Intent intent, int startId)
		{
			base.OnStart (intent, startId);

			Log.Debug ("DipsServiceModule", "DipsServiceModule started");

			DoStuff ();
		}

		public override void OnDestroy ()
		{
			base.OnDestroy ();

			_timer.Dispose ();

			Log.Debug ("DipsServiceModule", "DipsServiceModule stopped");      
		}

		public void DoStuff ()
		{
			_timer = new System.Threading.Timer ((o) => {
				Log.Debug ("DipsServiceModule", "hello from DipsServiceModule, lal");
			}, null, 0, 4000);
		}

		public string getName(string pnumber)
		{
			return "Frank Stangelberg";
		}

		public bool uploadImages(List<string> patientData, List<string> imagePaths)
		{
			return true;
		}

		public override Android.OS.IBinder OnBind (Android.Content.Intent intent)
		{
			throw new NotImplementedException ();
		}
	}
}

