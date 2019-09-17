using UnityEngine;
using System.Collections;
using Soomla;
using Soomla.Store;
using System;
using System.Collections.Generic;

public class ShapeValePurchases : MonoBehaviour {

	void Start(){
		StoreEvents.OnMarketPurchase += onMarketPurchase;
		StoreEvents.OnMarketRefund += onMarketRefund;
		StoreEvents.OnItemPurchased += onItemPurchased;
		StoreEvents.OnItemPurchaseStarted += onItemPurchaseStarted;
	}
	public void onItemPurchaseStarted(PurchasableVirtualItem pvi) {
    // pvi - the PurchasableVirtualItem whose purchase operation has just started

    // ... your game specific implementation here ...
	}

	public void onMarketPurchase(PurchasableVirtualItem pvi, string payload,
                                                         Dictionary<string, string> extra) {
    // pvi - the PurchasableVirtualItem that was just purchased
    // payload - a text that you can give when you initiate the purchase operation and
    //    you want to receive back upon completion
    // extra - contains platform specific information about the market purchase
    //    Android: The "extra" dictionary will contain: 'token', 'orderId', 'originalJson', 'signature', 'userId'
    //    iOS: The "extra" dictionary will contain: 'receiptUrl', 'transactionIdentifier', 'receiptBase64', 'transactionDate', 'originalTransactionDate', 'originalTransactionIdentifier'

	  	
	}
	public void onMarketRefund(PurchasableVirtualItem pvi) {
    // pvi - the PurchasableVirtualItem to refund
    	if(pvi.ID == ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID){
	  		StoreInventory.TakeItem(ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID, 1);
	  	}
    // ... your game specific implementation here ...
	}
	public void onItemPurchased(PurchasableVirtualItem pvi, string payload) {
    // pvi - the PurchasableVirtualItem that was just purchased
    // payload - a text that you can give when you initiate the purchase operation
    //    and you want to receive back upon completion

    // ... your game specific implementation here ...
	}

}
