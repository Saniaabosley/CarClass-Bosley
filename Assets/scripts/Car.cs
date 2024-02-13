using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private string carMake;
    private string carYear;
    public float currentSpeed;
    private float maximumSpeed = 100;


    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = 0;
    }





    void Accelrate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("placeholder");
        }
    }

    void Decelerate()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("placeholder");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
