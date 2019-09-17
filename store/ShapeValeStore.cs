using UnityEngine;
using System.Collections;
using  Soomla.Store;

public class ShapeValeStore : IStoreAssets {

	 public int GetVersion() {
	    return 0;
	  }

	  // NOTE: Even if you have no use in one of these functions, you still need to
	  // implement them all and just return an empty array.

	  public VirtualCurrency[] GetCurrencies() {
	    return new VirtualCurrency[]{};
	  }

	  public VirtualGood[] GetGoods() {
	    return new VirtualGood[] {NO_ADS_LTVG};
	  }

	  public VirtualCurrencyPack[] GetCurrencyPacks() {
	    return new VirtualCurrencyPack[] {};
	  }

	  public VirtualCategory[] GetCategories() {
	    return new VirtualCategory[]{};
	  }
	  public const string NO_ADS_LIFETIME_PRODUCT_ID = "remove_ads";

	 public static VirtualGood NO_ADS_LTVG = new LifetimeVG(
			"Remove Ads", 														// name
			"No More Ads!",				 									// description
			NO_ADS_LIFETIME_PRODUCT_ID,										// item id
			new PurchaseWithMarket(NO_ADS_LIFETIME_PRODUCT_ID, 1.99));	// the way this virtual good is purchased
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
