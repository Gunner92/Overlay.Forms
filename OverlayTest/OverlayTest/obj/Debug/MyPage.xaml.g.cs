// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace OverlayTest {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MyPage : ContentPage {
        
        private StackLayout MyStack;
        
        private Button MyButton;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MyPage));
            MyStack = this.FindByName <StackLayout>("MyStack");
            MyButton = this.FindByName <Button>("MyButton");
        }
    }
}
