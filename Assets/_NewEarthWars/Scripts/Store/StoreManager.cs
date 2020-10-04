using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NEW.Shop {
    public class StoreManager : MonoBehaviour {
        [SerializeField]
        private Sprite ChasisImage;

        void Start() {
            ShopItemChasis chasis = new ShopItemChasis("LowChasis",ChasisImage,200);


        }
        public void LoadeItems() {

        }

        public void GetSpecialOffer(ShopItem item, int discount = 5) {
            SpecialOffer offer =  new SpecialOffer(item);

            offer.DiscountPercentage = discount;
            offer.Offer = discount + "% discount in " + item.ItemName;
        }
    }

}
