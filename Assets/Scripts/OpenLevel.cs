using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLevel : MonoBehaviour
{
    public GameObject[] FruitLevels;
    public GameObject[] VegetableLevels;
    public GameObject[] SnackLevels;
    private GameObject[] ChoosenLevel;
    public GameObject StartPanel;
    public GameObject DifficultyPanel;
    void Start()
    {
        
    }
    

    public void ChooseTheme(string theme)
    {
        if (theme=="Fruit")
        {
            ChoosenLevel = FruitLevels;
            StartPanel.SetActive(false);
            DifficultyPanel.SetActive(true);
        }
        if (theme=="Vegetable")
        {
            ChoosenLevel = VegetableLevels;
            StartPanel.SetActive(false);
            DifficultyPanel.SetActive(true);
        }

        if (theme=="Snack")
        {
            ChoosenLevel = SnackLevels;
            StartPanel.SetActive(false);
            DifficultyPanel.SetActive(true);
        }
    }

    public void ChooseDifficulty(int difficulty)
    {
        ChoosenLevel[difficulty].gameObject.SetActive(true);
        DifficultyPanel.SetActive(false);
    }
}
