using UnityEngine;
using Game.FoodOrdering;
using System.Collections.Specialized;

public class FoodOrderhandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FoodOrder foodOrder = new FoodOrder("Luke", "Orange", 1);
        Debug.Log($"{foodOrder.customerName} Ordered {foodOrder.foodQuantity} {foodOrder.foodName}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
