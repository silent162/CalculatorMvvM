using System;
using Xamarin.Forms;
using Prism.Mvvm;
using Prism.Commands;
using System.Windows.Input;

namespace Test
{
	public class MainPageViewModel : BindableBase, Prism.Navigation.INavigationAware
	{
		string m_title = "Main Page";//так работать не будет уведомлений
		public string Title
		{
			get { return m_title; }
			set { SetProperty(ref m_title, value); }
		}
		public ICommand NavigateCommand { get; set; }

		public MainPageViewModel()
		{
			NavigateCommand = new DelegateCommand(Navigate);
		}

		void Navigate()
		{
			throw new Exception ("Test");
		}

		#region INavigationAware implementation

		public virtual void OnNavigatedFrom(Prism.Navigation.NavigationParameters parameters)
		{

		}

		public virtual void OnNavigatedTo(Prism.Navigation.NavigationParameters parameters)
		{

		}

		#endregion
	}
}


