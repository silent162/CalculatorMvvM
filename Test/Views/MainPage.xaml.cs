using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			throw new Exception("Если приложение запуститься то проблема в кешах, нужно будет удалить приложение с эмулятора и удалить папки бин и обдж");
		}
	}
}

