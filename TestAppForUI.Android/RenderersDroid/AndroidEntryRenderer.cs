using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TestAppForUI.CustomRenderers;
using TestAppForUI.Droid.RenderersDroid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderLessEntry), typeof(AndroidEntryRenderer))]
namespace TestAppForUI.Droid.RenderersDroid
{
    public class AndroidEntryRenderer: EntryRenderer
    {
        private readonly Context context;
        public AndroidEntryRenderer(Context context):base(context)
        {
            this.context = context;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null) return;

            Control.Background = null;
        }
    }
}