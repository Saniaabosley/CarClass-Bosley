using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{

    public InputField carYearInput;
    public InputField carMakeInput;
    public TextMeshProUGUI carMakeText;
    public TextMeshProUGUI carYearText;
    public TextMeshProUGUI speedText;

    Car newCar = new Car();

    // Start is called before the first frame update
    public void Start()
    {
        newCar.CurrentSpeed = 0;
        //newCar.Accelrate();
       // Debug.Log(newCar.Make);

        newCar.Make = carMakeInput.text;
         newCar.Year = carYearInput.text;
        carMakeText.text = "Car Make: " + newCar.Make;
        carYearText.text = "Car Year: " + newCar.Year;
        speedText.text = "Current Speed: " + newCar.CurrentSpeed;

       


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            newCar.Accelrate();
            Debug.Log(newCar.CurrentSpeed);
            speedText.text = "Current Speed: " + newCar.CurrentSpeed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            newCar.Decelerate();
            speedText.text = "Current Speed: " + newCar.CurrentSpeed;
        }
    }


}
