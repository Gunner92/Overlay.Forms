using System;
using Xamarin.Forms;

namespace OverlayTest
{
	public class App
	{
		public static NavigationPage navMy;
		public static Page GetMainPage ()
		{	
			navMy = new NavigationPage (new MyPage ());
			return navMy;
		}
	}
}

