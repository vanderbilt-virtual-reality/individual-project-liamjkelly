using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottleCalculation : MonoBehaviour
{
    static int total = 0;
    public Text myText;
    private BoxCollider grabbable;
    private bool hasBeenGrabbed = false;
    
    private float totalTons = 8000000f;
    private float weight = 30f;
    private float tonsLeft;
    // Start is called before the first frame update
    void Start()
    {
        grabbable = grabbable.GetComponent<BoxCollider>();
        myText = myText.GetComponent<Text>();
        myText.text = "Plastic Bottles picked up: " + total + "\n" + tonsLeft + " tons of plastic in the ocean this year.";
    }
    
    private void OnTriggerEnter(Collider other)
    {
        tonsLeft = totalTons - (total * weight);
        total++;
        myText.text = "Plastic Bottles picked up: " + total + "\n" + tonsLeft + " tons of plastic in the ocean this year.";
        Destroy(other.gameObject);
    }
}
