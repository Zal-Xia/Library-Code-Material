using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Game.FoodOrdering;

public class OrderDialoguemaker : MonoBehaviour
{
    [SerializeField] TMP_Text customerNameText;
    [SerializeField] TMP_Text customerOrderText;

    public void GenerateOrder(string customerName, string customerOrder)
    {
        customerNameText.text = customerName;
        customerOrderText.text = customerOrder;
    }

    public void CallOrder()
    {
        
    }

    void start()
    {
        FoodOrder foodOrder = new FoodOrder("Luke", "Orange", 1);
        Debug.Log($"{foodOrder.customerName} Ordered {foodOrder.foodQuantity} {foodOrder.foodName}");
        GenerateOrder(foodOrder.customerName, "memesan" + foodOrder.foodQuantity +  foodOrder.foodName);
    }

}
