using ObjCRuntime;

[assembly: LinkWith ("OneSignal.a", ForceLoad = true, Frameworks= "SystemConfiguration UserNotifications WebKit CoreGraphics UIKit")]
