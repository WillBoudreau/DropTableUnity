using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillBChestSelectorUpdate : MonoBehaviour
{
    [Header("Chest Type Update")]
    public int WoodChest;
    public int BronzeChest;
    public int SilverChest;
    public int GoldChest;
    public int PlatinumChest;

    public List<string> ChestTypes;

    [Header("Prizes Type Update ")]
    public int Common;
    public int UnCommon;
    public int Rare;
    public int Epic;
    public int Legendary;
    public List<string> PrizeTypes;
    
    private string ChestAwarded;
    private string PrizeAwarded;
    // Start is called before the first frame update
    void Start()
    { 
       AddChests();
       AddPrizes();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ChestAwarded = ChestTypes[Random.Range(0, ChestTypes.Count)];
            PrizeAwarded = PrizeTypes[Random.Range(0, PrizeTypes.Count)];
            Debug.Log("You got " + ChestAwarded + " and in that chest you find a " + PrizeAwarded + " prize");
        }
        
    }
    void AddChests()
    {
        //Adds Chests to the lists
        for(int i = 0; i < WoodChest; i++)
        { 
            ChestTypes.Add(new string("Wood Chest"));

        }
        for(int i = 0; i < BronzeChest; i++)
        {
            ChestTypes.Add(new string("Bronze Chest"));
        }
        for(int i = 0; i < SilverChest; i++)
        {
            ChestTypes.Add(new string("Silver Chest"));
        }
        for(int i = 0; i < GoldChest; i++)
        {
            ChestTypes.Add(new string("Gold Chest"));
        }
        for(int i = 0; i < PlatinumChest; i++)
        {
            ChestTypes.Add(new string("Platinum Chest"));
        }

    }
    void AddPrizes()
    {
        // Add Prizes 
        for (int i = 0; i < Common; i++)
        {
            PrizeTypes.Add(new string("Common"));

        }
        for (int i = 0; i < UnCommon; i++)
        {
            PrizeTypes.Add(new string("UnCommon"));
        }
        for (int i = 0; i < Rare; i++)
        {
            PrizeTypes.Add(new string("Rare"));
        }
        for (int i = 0; i < Epic; i++)
        {
            PrizeTypes.Add(new string("Epic"));
        }
        for (int i = 0; i < Legendary; i++)
        {
            PrizeTypes.Add(new string("Legendary"));
        }
    }
}
