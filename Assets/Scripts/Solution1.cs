using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution1 : MonoBehaviour
{
    // Start is called before the first frame update

    //TO DO: CLEAN UP PSEUDOCODE, resolve characterClass calling 

    public Dictionary<string, int> characterClasses5E = new Dictionary<string, int>()
    {
        {"Artificer", 8},
        {"Barbarian",12},
        {"Bard", 8},
        {"Cleric",8},
        {"Druid",8},
        {"Fighter",10},
        {"Monk", 8},
        {"Ranger", 10 },
        {"Rogue", 8 },
        {"Paladin", 10 },
        {"Sorcerer", 6},
        {"Warlock", 8},
        {"Wizard", 6}
    };

    private int lowestConstitutionModifier = -5;

    public int[,] ConstitutionModifier = new int[30, 1];


    [Header("Character stats")]
    public string characterName;
    public int characterLevel;
    public int characterConstitution;
    public string characterClass;

    [Header("Is he..?")]
    public bool isHillDwarf;
    private int hillDwarfMod; 
    public bool hasToughFeat;
    private int toughFeatMod;
    public bool isScoreAveraged;

    private int characterHP;

    void Start() 
    {
        //Checks for if the player is a Hill Dwarf, and edits the Debug Log to accommodate the public bool response
        string isHillDwarfStringCheck = "";
        if (isHillDwarf)
        {
            //TO DO: Gain HP for every character level
            isHillDwarfStringCheck = "is";
            hillDwarfMod = 2;
        }
        else
        {
            isHillDwarfStringCheck = "is not";
            hillDwarfMod = 0;
        }

        //Checks for if the player has the Tough feat, and edits the Debug Log to accommodate the public bool response
        string hasToughFeatStringCheck = "";
        if (hasToughFeat)
        {
            //TO DO: Adds 2 to HP Value for every character level 
            hasToughFeatStringCheck = "has";
            toughFeatMod = 2;
        }
        else
        {
            hasToughFeatStringCheck = "does not have";
            toughFeatMod = 0;
        }

        string HPBeingAveragedOrRandom = "";
        if (isScoreAveraged == true)
        {
            HPBeingAveragedOrRandom = "to be averaged";
            characterHP = GetCharacterHPAverage();
        }
        else
        {
            HPBeingAveragedOrRandom = "to be random";
            characterHP = GetCharacterHPRandom();
        }

        Debug.Log("My character " + characterName + " is a level " + characterLevel + " " + characterClass + " with a CON score of " + characterConstitution + " and " + isHillDwarfStringCheck + " a Hill Dwarf and " + hasToughFeatStringCheck + " the Tough feat. I want the HP " + HPBeingAveragedOrRandom + ".");
        Debug.Log(characterName + "'s HP is: " + characterHP);
    }

    int GetCharacterHPAverage()
    {        
        characterHP = (characterLevel * hillDwarfMod) + (characterLevel * toughFeatMod) + (characterLevel * ConstitutionModifier[(characterConstitution - 1), 0]) + (characterLevel * ((characterClasses5E[characterClass] / 2) + 1));
        return characterHP;
    }

    int GetCharacterHPRandom()
    {
        characterHP = (characterLevel * hillDwarfMod) + (characterLevel * toughFeatMod) + (characterLevel * ConstitutionModifier[(characterConstitution - 1), 0]);
        //Adding a new HP for every level
        for (int i = 0; i < characterLevel; i++)
        {
            characterHP += Random.Range(1, characterClasses5E[characterClass]);
        }

        return characterHP;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
