using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NEW.Shop {
    public class StoreManager : MonoBehaviour {
        [SerializeField]
        private Sprite ChasisImage;

        public int discountAmmount = 25;
        public Text discountAmmountText;

        public NEWProduct product;

        void Start() {
            ShopItemChasis chasis = new ShopItemChasis("LowChasis",ChasisImage,200);
            product.SetupItem(chasis);
        }
        public void LoadeItems() {

        }

        public void GetOffer() {
            product.GetSpecialOffer(product.Item, discountAmmount);
        }

        public void ChangeAmmountValue(Slider slider) {
            discountAmmount = (int)slider.value;
            discountAmmountText.text = discountAmmount + " %";
        }
    }

}
