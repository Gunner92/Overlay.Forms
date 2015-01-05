using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Overlay;
using System.Threading.Tasks;

namespace OverlayTest
{	
	public partial class MyPage : ContentPage
	{	
		public double HeightX;
		public double WidthX;
		public LoadingOverlay loy;
		public MyPage ()
		{
			InitializeComponent ();
			MyButton.Clicked+= async(object sender, EventArgs e) => {
				loy= new LoadingOverlay(MyStack,"Loading...",(int)HeightX,(int)WidthX,this);
				loy.ShowOverlay(this);
				MyStack.HeightRequest=HeightX;
				MyStack.WidthRequest=WidthX;
				App.navMy.PushAsync(new MyPage());

			};
		}
		protected override void OnSizeAllocated (double width, double height)
		{
			HeightX = height;
			WidthX = width;
			base.OnSizeAllocated (width, height);
		}
		protected override void OnDisappearing ()
		{
			if (loy!=null) {

				loy.HideOverlay(this);
			}
			base.OnDisappearing ();
		}
	}
}

