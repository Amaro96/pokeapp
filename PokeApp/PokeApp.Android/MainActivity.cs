﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using FFImageLoading.Forms.Platform;
using Lottie.Forms.Droid;
using PanCardView.Droid;
using Prism;
using Prism.Ioc;

namespace PokeApp.Droid
{
    [Activity(Label = "PokeApp", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            Rg.Plugins.Popup.Popup.Init(this, bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            CachedImageRenderer.Init(true);
            CardsViewRenderer.Preserve();
            AnimationViewRenderer.Init();
            LoadApplication(new App(new AndroidInitializer()));
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }


}

