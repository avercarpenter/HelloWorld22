using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textman : MonoBehaviour
{
    public Text HelloWorld;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            HelloWorld.text = "Hello, my name is Avery Carpenter!";
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
}
