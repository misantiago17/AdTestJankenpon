using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using GoogleMobileAds;
using System;

public class AdsHandler : MonoBehaviour {

	void Start () {

		#if UNITY_ANDROID
			string appID = "ca-app-pub-5614812286442730~2172769096";
		#elif UNITY_IPHONE
			string appID = "ca-app-pub-5614812286442730~5653968661";
		#else 
			string appID = "unexpected_plataform";
		#endif

		// Initialize the Google Mobile Ads SDK
		MobileAds.Initialize(appID);

		this.RequestBanner();
		
	}
	
	private void RequestBanner(){

		#if UNITY_ANDROID

			string adUnitId = "ca-app-pub-3940256099942544/6300978111"; // Dummy
 
 			if (SceneManager.GetActiveScene().name == "MenuScene"){
				// Real Deal: ca-app-pub-5614812286442730/3805414968
				adUnitId = "ca-app-pub-5614812286442730/3805414968"; 

			} else if (SceneManager.GetActiveScene().name == "PlayerDefinition"){
				// Real Deal: ca-app-pub-5614812286442730/8335972327
				adUnitId = "ca-app-pub-5614812286442730/8335972327"; 

			} else if (SceneManager.GetActiveScene().name == "GameScene"){
				// Real Deal: ca-app-pub-5614812286442730/2345279041
				adUnitId = "ca-app-pub-5614812286442730/2345279041"; 
			}

			// falta o add do botão com clique

		#elif UNITY_IPHONE

			string adUnitId = "ca-app-pub-3940256099942544/2934735716"; // Dummy

			if (SceneManager.GetActiveScene().name == "MenuScene"){
				// Real Deal: ca-app-pub-5614812286442730/8826926914
				adUnitId = "ca-app-pub-5614812286442730/8826926914"; 

			} else if (SceneManager.GetActiveScene().name == "PlayerDefinition"){
				// Real Deal: ca-app-pub-5614812286442730/1642286054
				adUnitId = "ca-app-pub-5614812286442730/1642286054"; 

			} else if (SceneManager.GetActiveScene().name == "GameScene"){
				// Real Deal: ca-app-pub-5614812286442730/6703041040
				adUnitId = "ca-app-pub-5614812286442730/6703041040"; 
			}

			// falta o add do botão com clique

		#else
			string adUnitId = "unexpected_plataform";
		#endif

		// Create a 320x50 banner at the bottom of the screen.
        BannerView bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

		// Called when an ad request has successfully loaded.
        bannerView.OnAdLoaded += HandleOnAdLoaded;
		// Called when an ad request failed to load.
        bannerView.OnAdFailedToLoad += HandleOnAdFailedToLoad;
		// Called when an ad is clicked.
        bannerView.OnAdOpening += HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        bannerView.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        bannerView.OnAdLeavingApplication += HandleOnAdLeavingApplication;

		// Create an empty ad request
		AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
		
		bannerView.Show();
	}

	public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

	   public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }
}
