# DIG4714C-Lab-4-D-D-5E-Calculator

public Dictionary<string,int> characterClasses5E = new Dictionary<string, int>();
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
}

private int lowestConstitutionModifier = -5;

public int [30,1] ConstitutionModifier;

foreach(constitution in ConstitutionModifier)
{
    ConstitutionModifier[(constitution+1),0] = lowestConstitutionModifier + (RoundDown((constitution+1)/2))

}

public bool isHillDwarf;
public bool hasToughFeat;
public bool isScoreAveraged;

[Header(“Character Stats”)]
public string characterName;
public int characterLevel;
public int characterConstitution
public characterClasses5E characterClass;
private int characterHP;


void Start()
{
    private string isHillDwarfStringCheck = "";
    if(isHillDwarf) {
      isHillDwarfStringCheck = "is";
    }
    else {
      isHillDwarfStringCheck = "is not";
    }

    private string hasToughFeatStringCheck = "";
    if(hasToughFeat) {
      hasToughFeatStringCheck = "has";
    }
    else {
      hasToughFeatStringCheck = "does not have";
    }
    
    Debug.Log($“My character " + characterName + " is a level " + characterLevel + " " + charactercharacterClass + " with a CON score of " + characterConstitution + " and " isHillDwarfStringCheck + " a Hill Dwarf and " + hasToughFeatStringCheck + " the Tough feat. I want the HP " + isScoreAveraged + ".")

}

GetCharacterHPAverage()
{
    characterHP = (characterLevel  * isHillDwarf) + (characterLevel  * (hasToughFeat + 1)) + (characterLevel * ConstitutionModifier[(characterConstitution - 1), 0] ) + (characterLevel * (characterClass[HitDice] / 2 + 1) );
}

GetCharacterHPRandom()
{
    characterHP = (characterLevel  * isHillDwarf) + (characterLevel  * (hasToughFeat + 1)) + (characterLevel * ConstitutionModifier[(characterConstitution - 1), 0] ) + (characterLevel * //For every level(Random.Range(1, characterClass[HitDice]) );
}
