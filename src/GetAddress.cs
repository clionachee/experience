// Import required namespaces
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Define the getAddress class, responsible for displaying the account address
public class getAddress : MonoBehaviour
{
    public Text myAccount; // Reference to the Text component where the account address will be displayed

    // Start is called before the first frame update
    void Start()
    {
        // Retrieve the account address from PlayerPrefs
        string account = PlayerPrefs.GetString("Account");

        // Assign the account address to the Text component
        myAccount.text = account;
    }

    // Update is called once per frame
    // No need to update anything here, so the method is left empty
    void Update()
    {
    }
}
