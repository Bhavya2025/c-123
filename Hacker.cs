using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello bhavya");
        print ("Hello"+"World");
    }
void ShowMainMenu(string greeting){
    Terminal.ClearScreen();
    Terminal.WriteLine(greeting);
    Terminal.WriteLine("What do u want to hack into?");
    Terminal.WriteLine("Press 1 for the School");
    Terminal.WriteLine("Press 2 for your city bank$Vault");
    Terminal.WriteLine("Press 3 for NASA headQuaters");
    Terminal.WriteLine("Enter your selection:");
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
