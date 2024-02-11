using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

[Serializable]
public class Character
{
    [Header("Character stats")]
    public string characterName;
    public int characterLevel;
    public int characterConstitution;
    public string characterClass;
    [HideInInspector]
    public int characterHP;

    [Header("Is he..?")]
    public bool isHillDwarf;
    public bool hasToughFeat;
    public bool isScoreAveraged;


    public Character()
    {

    }

    public Character(string characterName, int characterLevel, int characterConstitution, string characterClass, bool isHillDwarf, bool hasToughFeat, bool isScoreAveraged)
    {
        this.characterName = characterName;
        this.characterLevel = characterLevel;
        this.characterConstitution = characterConstitution;
        this.characterClass = characterClass;
        this.isHillDwarf = isHillDwarf;
        this.hasToughFeat = hasToughFeat;
        this.isScoreAveraged = isScoreAveraged;
    }
}
