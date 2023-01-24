using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalHungry : MonoBehaviour
{
    public int maxHungry = 3;
    public int currentHungry;
    public HungryBar hungryBar;
    static public bool feedCheck = false;
    //public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        currentHungry = 0;
        hungryBar.SetMaxHungry(maxHungry);
    }

    // Update is called once per frame
    void Update()
    {
        feedAnimal();
    }

    private void feedAnimal()
    {
        if (feedCheck == true && currentHungry < maxHungry)
        {
            currentHungry++;
            hungryBar.SetHungry(currentHungry);
            feedCheck = false;
        }
        else if (currentHungry == maxHungry)
        {
            Destroy(this.gameObject);
            GameManager.scoreCheck = true;
        }
    }
}
