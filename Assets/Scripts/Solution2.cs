using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Solution2 : MonoBehaviour
{
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

    private int hillDwarfModifier = 1;

    private int toughFeatModifier = 2;





    [SerializeField]
    public Character PlayerCharacter = new Character();
    void Start()
    {
        for (int i = 0; i < ConstitutionModifier.GetLength(0); i++)
        {
            ConstitutionModifier[i, 0] = lowestConstitutionModifier + Mathf.FloorToInt((i + 1) / 2);
        }

        string isHillDwarfStringCheck = "";
        if (PlayerCharacter.isHillDwarf) {isHillDwarfStringCheck = "is";}
        else {isHillDwarfStringCheck = "is not"; hillDwarfModifier = 0;}

        string hasToughFeatStringCheck = " ";
        if (PlayerCharacter.hasToughFeat) {hasToughFeatStringCheck = "has";}
        else {hasToughFeatStringCheck = "does not have"; toughFeatModifier = 0;}

        string HPBeingAveragedOrRandom = "";
        if (PlayerCharacter.isScoreAveraged == true)
        {
            HPBeingAveragedOrRandom = "to be averaged";
            PlayerCharacter.characterHP = GetCharacterHPAverage();
        }
        else
        {
            HPBeingAveragedOrRandom = "to be random";
            PlayerCharacter.characterHP = GetCharacterHPRandom();
        }


        Debug.Log("My character " + PlayerCharacter.characterName + " is a level " + PlayerCharacter.characterLevel + " " + PlayerCharacter.characterClass + " with a CON score of " + PlayerCharacter.characterConstitution + " and " + isHillDwarfStringCheck + " a Hill Dwarf and " + hasToughFeatStringCheck + " the Tough feat. I want the HP " + HPBeingAveragedOrRandom + ".");
        Debug.Log("The character HP is " + PlayerCharacter.characterHP);
    }

    int GetCharacterHPAverage()
    {
        int characterHP;
        characterHP = (PlayerCharacter.characterLevel * hillDwarfModifier) + (PlayerCharacter.characterLevel * toughFeatModifier) + (PlayerCharacter.characterLevel * ConstitutionModifier[(PlayerCharacter.characterConstitution - 1), 0]) + (PlayerCharacter.characterLevel * ((characterClasses5E[PlayerCharacter.characterClass] / 2) + 1));
        return characterHP;
    }

    int GetCharacterHPRandom()
    {
        int characterHP;
        characterHP = (PlayerCharacter.characterLevel * hillDwarfModifier) + (PlayerCharacter.characterLevel * toughFeatModifier) + (PlayerCharacter.characterLevel * ConstitutionModifier[(PlayerCharacter.characterConstitution - 1), 0]);        

        //Adding a new HP for every level
        for (int i = 0; i < PlayerCharacter.characterLevel; i++)
        {
            characterHP += Random.Range(1, characterClasses5E[PlayerCharacter.characterClass]);
        }
        return characterHP;
    }
}
