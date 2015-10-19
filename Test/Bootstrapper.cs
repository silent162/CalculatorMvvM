using System;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;

namespace Test.Views
{
	public class Bootstrapper : UnityBootstrapper
	{
		protected override Xamarin.Forms.Page CreateMainPage()
		{
			return Container.Resolve<MainPage> ();
		}
		protected override void RegisterTypes()
		{
			Container.RegisterInstance (Container);
			Container.RegisterTypeForNavigation<MainPage, MainPageViewModel> ();
		}
	}
}


