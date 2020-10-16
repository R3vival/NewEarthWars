using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NEW.Engine;

namespace NEW.Shop {
    //Component
    public interface ShopItem {
        string ItemName { get; }
        Sprite ItemImage { get; }
        float Price { get; }
    }
    //ConcreteComponent
    public class ShopItemChasis : ShopItem {
        string itemName;
        Sprite itemImage;
        float itemPrice;

        public ShopItemChasis(string name, Sprite image, float price = 0) {
            itemName = name;
            itemImage = image;
            itemPrice = price;            
        }

        public string ItemName {
            get { return itemName; }
        }

        public Sprite ItemImage {
            get { return itemImage; }
        }

        public float Price {
            get { return itemPrice; }
        }
    }
    //Decorator
    public abstract class ShopItemDecorator: ShopItem {
        private ShopItem item;

        public ShopItemDecorator(ShopItem shopItem) {
            item = shopItem;
        }

        public string ItemName {
            get { return item.ItemName; }
        }

        public Sprite ItemImage {
            get { return item.ItemImage; }
        }

        public float Price {
            get { return item.Price; }
        }
    }

    //Concrete Decorator
    public class SpecialOffer : ShopItemDecorator {
        public SpecialOffer(ShopItem item) : base(item) { }

        public int DiscountPercentage { get; set; }
        public string Offer { get; set; }

        public float Price {
            get {
                float price = base.Price;
                int percentage = 100-DiscountPercentage;
                return Mathf.Round((price * percentage) / 100);
            }
        }
    }
}

