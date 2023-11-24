using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class WillBChestSelector : MonoBehaviour
{


    [Header("All Chests")]
    [SerializeField] private int WoodChests = 300;
    [SerializeField] private int BronzeChests = 250;
    [SerializeField] private int SilverChests = 200;
    [SerializeField] private int GoldChests = 150;
    [SerializeField] private int PlatinumChests = 50;
    [SerializeField] private List<string> Chests;


    [Header("Wood chest probabilites")]
    [SerializeField] private int WoodCommon = 150;
    [SerializeField] private int WoodUnCommon = 100;
    [SerializeField] private int WoodRare = 50;
    [SerializeField] private int WoodEpic = 25;
    [SerializeField] private int WoodLegendary = 0;
    [SerializeField] private List<string> WoodChestDrop;


    [Header("Bronze chest probabilites")]
    [SerializeField] private int BronzeCommon = 125;
    [SerializeField] private int BronzeUnCommon = 125;
    [SerializeField] private int BronzeRare = 75;
    [SerializeField] private int BronzeEpic = 50;
    [SerializeField] private int BronzeLegendary = 25;
    [SerializeField] private List<string> BronzeChestDrop;


    [Header("Silver chest probabilites")]
    [SerializeField] private int SilverCommon = 100;
    [SerializeField] private int SilverUnCommon = 125;
    [SerializeField] private int SilverRare = 100;
    [SerializeField] private int SilverEpic = 50;
    [SerializeField] private int SilverLegendary = 25;
    [SerializeField] private List<string> SilverChestDrop;

    [Header("Gold chest probabilites")]
    [SerializeField] private int GoldCommon = 75;
    [SerializeField] private int GoldUnCommon = 100;
    [SerializeField] private int GoldRare = 125;
    [SerializeField] private int GoldEpic = 75;
    [SerializeField] private int GoldLegendary = 50;
    [SerializeField] private List<string> GoldChestDrop;

    [Header("Platinum chest probabilites")]
    [SerializeField] private int PlatinumCommon = 75;
    [SerializeField] private int PlatinumUnCommon = 50;
    [SerializeField] private int PlatinumRare = 125;
    [SerializeField] private int PlatinumEpic = 100;
    [SerializeField] private int PlatinumLegendary = 50;
    [SerializeField] private List<string> PlatinumChestDrop;


    // Start is called before the first frame update
    void Start()
    {
        //List
        Chests = new List<string>();
        Chests.Add("Wood");
        Chests.Add("Bronze");
        Chests.Add("Silver");
        Chests.Add("Epic");
        Chests.Add("Platinum");
        //Wood
        //List
        WoodChestDrop = new List<string>();
        WoodChestDrop.Add("Common");
        WoodChestDrop.Add("UnCommon");
        WoodChestDrop.Add("Rare");
        WoodChestDrop.Add("Epic");
        WoodChestDrop.Add("Legendary");
        //Bronze
        //List
        BronzeChestDrop = new List<string>();
        BronzeChestDrop.Add("Common");
        BronzeChestDrop.Add("UnCommon");
        BronzeChestDrop.Add("Rare");
        BronzeChestDrop.Add("Epic");
        BronzeChestDrop.Add("Legendaray");
        //Silver
        //List
        SilverChestDrop = new List<string>();
        SilverChestDrop.Add("Common");
        SilverChestDrop.Add("UnCommon");
        SilverChestDrop.Add("Rare");
        SilverChestDrop.Add("Epic");
        SilverChestDrop.Add("Legendaray");
        //Gold
        //List
        GoldChestDrop = new List<string>();
        GoldChestDrop.Add("Common");
        GoldChestDrop.Add("UnCommon");
        GoldChestDrop.Add("Rare");
        GoldChestDrop.Add("Epic");
        GoldChestDrop.Add("Legendaray");
        //Platinum
        //List
        PlatinumChestDrop = new List<string>();
        PlatinumChestDrop.Add("Common");
        PlatinumChestDrop.Add("UnCommon");
        PlatinumChestDrop.Add("Rare");
        PlatinumChestDrop.Add("Epic");
        PlatinumChestDrop.Add("Legendaray");
    }
    private void Update()
    {
        //Debug.Log("Press space");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChestSelection();
        }
    }
    private void ChestSelection()
    {
        for (int i = 0; i < Chests.Count; i++)
        {
            int chestTotal = (WoodChests + BronzeChests + SilverChests + GoldChests + PlatinumChests);
            int randomPick = UnityEngine.Random.Range(0, chestTotal + 1);
            
            if(randomPick <= WoodChests &&  randomPick >= 0)
            {
                Debug.Log("Wood Chest selected");
                int WoddChestOutcomes = (WoodCommon + WoodUnCommon + WoodRare + WoodEpic + WoodLegendary);
                int randomWood = UnityEngine.Random.Range(0, WoddChestOutcomes + 1);

                for(int j = 0; j < WoodChestDrop.Count; j++)
                {
                    if (randomWood <= WoodCommon && randomWood >= 0)
                    {
                        Debug.Log("Wood Common");
                    }
                    if(randomWood <= WoodCommon + WoodUnCommon && randomWood > WoodCommon)
                    {
                        Debug.Log("Wood UnCommon");
                    }
                    if(randomWood <= WoodCommon + WoodUnCommon + WoodRare &&  randomWood >= WoodCommon + WoodUnCommon)
                    {
                        Debug.Log("Wood Rare");
                    }
                    if(randomWood <= WoodCommon + WoodUnCommon + WoodRare + WoodEpic && randomWood >= WoodCommon + WoodUnCommon + WoodRare)
                    {
                        Debug.Log("Wood Epic");
                    }
                    if(randomWood <= WoodCommon + WoodUnCommon + WoodRare + WoodEpic + WoodLegendary && randomWood >= WoodCommon + WoodUnCommon + WoodRare + WoodEpic)
                    {
                        Debug.Log("Wood Legendaray");
                    }
                    break;
                }
            }
            if (randomPick <= BronzeChests + WoodChests && randomPick > WoodChests)
            {
                Debug.Log("Bronze Chest selected");
                int BronzeChestOutComes = (BronzeCommon + BronzeUnCommon + BronzeRare + BronzeEpic + BronzeLegendary);
                int randomBronze = UnityEngine.Random.Range(0,BronzeChestOutComes + 1);
                
                for(int k = 0; k < BronzeChestDrop.Count; k++)
                {
                    if (randomBronze <= BronzeCommon && randomBronze >= 0)
                    {
                        Debug.Log("Bronze Common");
                    }
                    if (randomBronze <= BronzeCommon + BronzeUnCommon && randomBronze > BronzeCommon)
                    {
                        Debug.Log("Bronze UnCommon");
                    }
                    if (randomBronze <= BronzeCommon + BronzeUnCommon + BronzeRare && randomBronze >= BronzeCommon + BronzeUnCommon)
                    {
                        Debug.Log("Bronze Rare");
                    }
                    if (randomBronze <= BronzeCommon + BronzeUnCommon + BronzeRare + BronzeEpic && randomBronze >= BronzeCommon + BronzeUnCommon + BronzeRare)
                    {
                        Debug.Log("Bronze Epic");
                    }
                    if (randomBronze <= BronzeCommon + BronzeUnCommon + BronzeRare + BronzeEpic + BronzeLegendary && randomBronze >= BronzeCommon + BronzeUnCommon + BronzeRare + BronzeEpic)
                    {
                        Debug.Log("Bronze Legendaray");
                    }
                    break;
                }
            }
            if (randomPick <= SilverChests + BronzeChests + WoodChests && randomPick > BronzeChests + WoodChests)
            {
                Debug.Log("Silver Chest selected");
                int SilverChestOutComes = (SilverCommon + SilverUnCommon + SilverRare + SilverEpic + SilverLegendary);
                int randomSilver = UnityEngine.Random.Range(0, SilverChestOutComes + 1);

                for (int k = 0; k < SilverChestDrop.Count; k++)
                {
                    if (randomSilver <= SilverCommon && randomSilver >= 0)
                    {
                        Debug.Log("Silver Common");
                    }
                    if (randomSilver <= SilverCommon + SilverUnCommon && randomSilver > SilverCommon)
                    {
                        Debug.Log("Silver UnCommon");
                    }
                    if (randomSilver <= SilverCommon + SilverUnCommon + SilverRare && randomSilver >= SilverCommon + SilverUnCommon)
                    {
                        Debug.Log("Silver Rare");
                    }
                    if (randomSilver <= SilverCommon + SilverUnCommon + SilverRare + SilverEpic && randomSilver >= SilverCommon + SilverUnCommon + SilverRare)
                    {
                        Debug.Log("Silver Epic");
                    }
                    if (randomSilver <= SilverCommon + SilverUnCommon + SilverRare + SilverEpic + SilverLegendary && randomSilver >= SilverCommon + SilverUnCommon + SilverRare + SilverEpic)
                    {
                        Debug.Log("SilverLegendaray");
                    }
                    break;
                }
            }
            if (randomPick <= GoldChests + SilverChests + BronzeChests + WoodChests && randomPick >= SilverChests + BronzeChests + WoodChests)
            {
                Debug.Log("Gold Chest selected");
                int GoldChestOutComes = (GoldCommon + GoldUnCommon + GoldRare + GoldEpic + GoldLegendary);
                int randomGold = UnityEngine.Random.Range(0, GoldChestOutComes + 1);

                for (int k = 0; k < GoldChestDrop.Count; k++)
                {
                    if (randomGold <= GoldCommon && randomGold >= 0)
                    {
                        Debug.Log("Gold Common");
                    }
                    if (randomGold <= GoldCommon + GoldUnCommon && randomGold > GoldCommon)
                    {
                        Debug.Log("Gold UnCommon");
                    }
                    if (randomGold <= GoldCommon + GoldUnCommon + GoldRare && randomGold >= GoldCommon + GoldUnCommon)
                    {
                        Debug.Log("Gold Rare");
                    }
                    if (randomGold <= GoldCommon + GoldUnCommon + GoldRare + GoldEpic && randomGold >= GoldCommon + GoldUnCommon + GoldRare)
                    {
                        Debug.Log("Gold Epic");
                    }
                    if (randomGold <= GoldCommon + GoldUnCommon + GoldRare + GoldEpic + GoldLegendary && randomGold >= GoldCommon + GoldUnCommon + GoldRare + GoldEpic)
                    {
                        Debug.Log("Gold Legendaray");
                    }
                    break;
                }
            }
            if (randomPick <= PlatinumChests + GoldChests + SilverChests + BronzeChests + WoodChests && randomPick > GoldChests + SilverChests + BronzeChests + WoodChests)
            {
                Debug.Log("Platinum Chest selected");
                int PlatinumChestOutComes = (PlatinumCommon + PlatinumUnCommon + PlatinumRare + PlatinumEpic + PlatinumLegendary);
                int randomPlatinum = UnityEngine.Random.Range(0, PlatinumChestOutComes + 1);

                for (int k = 0; k < PlatinumChestDrop.Count; k++)
                {
                    if (randomPlatinum <= PlatinumCommon && randomPlatinum >= 0)
                    {
                        Debug.Log("Platinum Common");
                    }
                    if (randomPlatinum <= PlatinumCommon + PlatinumUnCommon && randomPlatinum > PlatinumCommon)
                    {
                        Debug.Log("Platinum UnCommon");
                    }
                    if (randomPlatinum <= PlatinumCommon + PlatinumUnCommon + PlatinumRare && randomPlatinum >= PlatinumCommon + PlatinumUnCommon)
                    {
                        Debug.Log("Platinum Rare");
                    }
                    if (randomPlatinum <= PlatinumCommon + PlatinumUnCommon + PlatinumRare + PlatinumEpic && randomPlatinum >= PlatinumCommon + PlatinumUnCommon + PlatinumRare)
                    {
                        Debug.Log("Platinum Epic");
                    }
                    if (randomPlatinum <= PlatinumCommon + PlatinumUnCommon + PlatinumRare + PlatinumEpic + PlatinumLegendary && randomPlatinum >= PlatinumCommon + PlatinumUnCommon + PlatinumRare + PlatinumEpic)
                    {
                        Debug.Log("Platinum Legendaray");
                    }
                    break;
                }
            }
            break;
        }
    }
}