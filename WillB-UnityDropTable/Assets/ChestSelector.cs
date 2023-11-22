using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSelector : MonoBehaviour
{
    [Header("All Chests")]
    [SerializeField] private int WoodChests;
    [SerializeField] private int BronzeChests;
    [SerializeField] private int SilverChests;
    [SerializeField] private int GoldChests;
    [SerializeField] private int PlatinumChests;
    [SerializeField] private List<string> Chests;

    [Header("Wood chest probabilites")]
    [SerializeField] private int WoodCommon;
    [SerializeField] private int WoodUnCommon;
    [SerializeField] private int WoodRare;
    [SerializeField] private int WoodEpic;
    [SerializeField] private int WoodLegendary;
    [SerializeField] private List<string> WoodChestDrop;

    static int Woodtotal;

    [Header("Bronze chest probabilites")]
    [SerializeField] private int BronzeCommon;
    [SerializeField] private int BronzeUnCommon;
    [SerializeField] private int BronzeRare;
    [SerializeField] private int BronzeEpic;
    [SerializeField] private int BronzeLegendary;
    [SerializeField] private List<string> BronzeChestDrop;

    static int Bronzetotal;

    [Header("Silver chest probabilites")]
    [SerializeField] private int SilverCommon;
    [SerializeField] private int SilverUnCommon;
    [SerializeField] private int SilverRare;
    [SerializeField] private int SilverEpic;
    [SerializeField] private int SilverLegendary;
    [SerializeField] private List<string> SilverChestDrop;

    [Header("Gold chest probabilites")]
    [SerializeField] private int GoldCommon;
    [SerializeField] private int GoldUnCommon;
    [SerializeField] private int GoldRare;
    [SerializeField] private int GoldEpic;
    [SerializeField] private int GoldLegendary;
    [SerializeField] private List<string> GoldChestDrop;

    [Header("Platinum chest probabilites")]
    [SerializeField] private int PlatinumCommon;
    [SerializeField] private int PlatinumUnCommon;
    [SerializeField] private int PlatinumRare;
    [SerializeField] private int PlatinumEpic;
    [SerializeField] private int PlatinumLegendary;
    [SerializeField] private List<string> PlatinumChestDrop;


    // Start is called before the first frame update
    void Start()
    {
        //All chest ints
        WoodChests = 300;
        BronzeChests = 250;
        SilverChests = 200;
        GoldChests = 150;
        PlatinumChests = 50;
        //List
        Chests = new List<string>();
        Chests.Add("Wood");
        Chests.Add("Bronze");
        Chests.Add("Silver");
        Chests.Add("Epic");
        Chests.Add("Platinum");
        //Wood
        //Wood chest probability ints and strings
        WoodCommon = 150;
        WoodUnCommon = 100;
        WoodRare = 50;
        WoodEpic = 25;
        WoodLegendary = 0;
        //List
        WoodChestDrop = new List<string>();
        WoodChestDrop.Add("Common");
        WoodChestDrop.Add("UnCommon");
        WoodChestDrop.Add("Rare");
        WoodChestDrop.Add("Epic");
        WoodChestDrop.Add("Legendary");
        //Bronze
        //Bronze chest probability ints and strings
        BronzeCommon = 125;
        BronzeUnCommon = 125;
        BronzeRare = 75;
        BronzeEpic = 50;
        BronzeLegendary = 25;
        //List
        BronzeChestDrop = new List<string>();
        BronzeChestDrop.Add("Common");
        BronzeChestDrop.Add("UnCommon");
        BronzeChestDrop.Add("Rare");
        BronzeChestDrop.Add("Epic");
        BronzeChestDrop.Add("Legendaray");
        //Silver
        //Silver chest probability and strings

        for (int i = 0; i < Chests.Count; i++)
        {
            if (Random.Range(0, Chests.Count) == 1)
            {
                Debug.Log("Wood Selected");
                for (int j = 0; j < WoodChestDrop.Count; j++)
                {
                    Woodtotal = WoodCommon + WoodUnCommon + WoodRare + WoodEpic + WoodLegendary;
                }
                break;
            }
            if (Random.Range(0, Chests.Count) == 2)
            {
                Debug.Log("Bronze Selected");
                break;
            }
            if (Random.Range(0, Chests.Count) == 3)
            {
                Debug.Log("Silver Selected");
                break;
            }
            if (Random.Range(0, Chests.Count) == 4)
            {
                Debug.Log("Epic Selected");
                break;
            }
            else
            {
                Debug.Log("Platinum Selected");
                break;
            }

        }

    }
}