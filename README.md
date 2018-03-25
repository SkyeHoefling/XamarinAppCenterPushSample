# XamarinAppCenterPushSample
Xamarin Forms Push Notification Sample using App Center Push

# Setup


## 1. Configure App Center

1. Open browser and navigate to [App Center](https://appcenter.ms)
2. Create iOS App
3. Create Android App

## 2. Configure Android (Firebase)

1. Open browser and navigate to your App Center Android app
2. Select Push notification
3. Open your AndroidManifest.xml and copy over permissions documented in App Center portal
4. Open browser and navigate to [Firebase](https://console.firebase.google.com/)
5. Create new Firebase App for Android
6. Register your app
7. Head to console (you don't need any json or config files)
8. Navigate to Project Settings -> Cloud Messaging (do not close this page you will need it later)
9. Copy the Sender ID into your MainActivity.cs right before the `LoadApplication` call
10. Back in the FIrebase window find the `Server Key` and add that into the App Center SDK key

Everything is configured for Android Push Notifications with App Center

## 3. Configure iOS (APN)

1. Open browser and navigate to your App Center iOS app
2. Select Push Notification
3. We already app center config so select the next button
4. Open a new tab and go to your apple developer account profile to create certificates
5. Create a new APN Key
6. Copy over the Key ID to App Center
7. Enter your prefix to App Center
8. Enter your app name into the ID in our case here it is `com.hoeflingsoftware.PushSample`
9. Enter your auth key into App Center

Everything is configured for iOS Push Notifications with App Center