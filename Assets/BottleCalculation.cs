using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottleCalculation : MonoBehaviour
{
    static int total = 0;
    public Text myText;
    
    private int totalTons = 8000000;
    private int weight = 30;
    private int tonsLeft;
    // Start is called before the first frame update
    void Start()
    {
        tonsLeft = totalTons;
        myText = myText.GetComponent<Text>();
        myText.text = "Bottles picked up: " + total.ToString() + ". " + tonsLeft.ToString() + " grams of plastic in the ocean this year.";
        print(total);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bottle")
        {
            total++;
            tonsLeft = totalTons - (total * weight);
            print(tonsLeft);
            print(other.gameObject);
            print(total);
            myText.text = "Bottles picked up: " + total.ToString() + ". " + tonsLeft.ToString() + " grams of plastic will enter the ocean this year.";
            print("Bottles picked up: " + total.ToString() + ". " + tonsLeft.ToString() + " grams of plastic will enter the ocean this year.");
            Destroy(other.gameObject);
        }
           
    }
}
