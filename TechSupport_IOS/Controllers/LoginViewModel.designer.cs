// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TechSupport
{
    [Register ("LoginViewModel")]
    partial class LoginViewModel
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Login { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        TechSupport.LoginView LoginView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Password { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ProfileImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Username { get; set; }

        [Action ("Exit:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Exit (UIKit.UITextField sender);

        [Action ("LoginClick:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LoginClick (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Login != null) {
                Login.Dispose ();
                Login = null;
            }

            if (LoginView != null) {
                LoginView.Dispose ();
                LoginView = null;
            }

            if (Password != null) {
                Password.Dispose ();
                Password = null;
            }

            if (ProfileImage != null) {
                ProfileImage.Dispose ();
                ProfileImage = null;
            }

            if (Username != null) {
                Username.Dispose ();
                Username = null;
            }
        }
    }
}