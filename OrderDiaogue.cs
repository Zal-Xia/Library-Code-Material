using UnityEngine;

namespace Game.FoodOrdering
{
    public class FoodOrder
    {
        public string customerName;
        public string foodName;
        public int foodQuantity;

        public FoodOrder(string customerName, string foodName, int foodQuantity)
        {
            this.customerName = customerName;
            this.foodName = foodName;
            this.foodQuantity = foodQuantity;
        }
    }
}