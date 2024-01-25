using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge_2 : MonoBehaviour
{
    public float BookPrice;
    // Value of a book's price. Can be edited in Inspector.
    // Expected value is a price with 2 decimal places.

    public int CopyCount;
    // Value of how many copies are being ordered. Can be edited in Inspector.
    // Expected Minimum is 1.

    int ShippingCost = 3;
    float AddedShippingCost = 0.75f;
    // Value of shipping the first book, and the added cost of any additional book. Not in Inspector.

    float Discount = 0.6f;
    // Value of the discount the bookstore gets when buying.

    // Goal of Code: Book Price and Copy Count are input in the editor.
    // Then, Total Cost and Profit will be calculated based on those values, shipping, and discount.

    void Start()
    {
        float TotalCost;
        float TotalProfit;
        float ProfitMargin;
        // Variables for placing finalized Cost and Profit.
        // Also a variable for placing the difference of the original price and discounted price.

        // Debug.Log(BookPrice);
        // Debug.Log(CopyCount);
        // Testing for input variables.

        TotalCost = (BookPrice * CopyCount) * Discount;
        TotalCost = Mathf.Round(TotalCost * 100.0f) * 0.01f;
        Debug.Log("Total Cost is $" + TotalCost + ".");
        ProfitMargin = (BookPrice * CopyCount) - TotalCost;
        ProfitMargin = Mathf.Round(ProfitMargin * 100.0f) * 0.01f;
        // Debug.Log("Profit Margin is $" + ProfitMargin + ".");
        // Calculates the discounted cost of the books.
        // Then, rounds the calculation to two decimal points.
        // Then, prints the result to the debug log.
        // Then, calculates the difference between original and discounted cost.
        // Then, rounds that calculation to two decimal places.

        TotalProfit = ProfitMargin - (ShippingCost + (AddedShippingCost * (CopyCount - 1)));
        TotalProfit = Mathf.Round(TotalProfit * 100.0f) * 0.01f;
        Debug.Log("Total Profit is $" + TotalProfit + ".");
        // Calculates the total profit of the books.
        // Then, rounds the calculation to two decimal places.
        // Then, prints the result to the debug log.

    }

}
