using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{

    public GameObject carYearInput;
    public InputField carMakeInput;
    public TextMeshProUGUI carMakeText;
    public TextMeshProUGUI carYearText;
    public TextMeshProUGUI speedText;


    // Start is called before the first frame update
    public void Start()
    {
        Car newCar = new Car();
        //newCar.Accelrate();
       // Debug.Log(newCar.Make);

        newCar.Make = carMakeInput.text;
       //newCar.Year = carYearInput.GetComponent<InputField>().text;
        carMakeText.text = "Car Make: " + newCar.Make;
        carYearText.text = "Car Year: " + newCar.Year;
        //speedText.text = "Current Speed: " + newCar.CurrentSpeed;


    }

    
}
