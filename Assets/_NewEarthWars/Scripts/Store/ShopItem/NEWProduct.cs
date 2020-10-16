using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NEW.Shop {
    public class NEWProduct : MonoBehaviour {
        private ShopItem item;

        [Header("ProductComponent")]
        public Text productName;
        public Text ProductPrice;

        public ShopItem Item { get => item; set => item = value; }

        public void SetupItem(ShopItem newItem) {
            Item = newItem;
            RestorePrice();
        }

        public void GetSpecialOffer(ShopItem item, int discount = 5) {
            SpecialOffer offer =  new SpecialOffer(item);

            offer.DiscountPercentage = discount;
            offer.Offer = discount + "% discount in " + item.ItemName;

            ChangePrice(offer.Price);
        }

        public void ChangePrice(float newPrice) {
            ProductPrice.text = "Current Price: " + newPrice;
        }

        public void RestorePrice() {
            ChangePrice(item.Price);
        }
    }
}

