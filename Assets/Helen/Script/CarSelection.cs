using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
   
    public static int currentCar=0;

    private void Awake()
    {
        SelectCar(0);
    }

    private void SelectCar(int _index)
    {
        previousButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount-1);
        Debug.Log(currentCar);
        
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }

    }

    public void ChangeCar(int _change)
{

    currentCar += _change;
    SelectCar(currentCar);
}

}
