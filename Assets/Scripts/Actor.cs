using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {
    private Dictionary<Consts.Characters, string> spriteMap = new Dictionary<Consts.Characters, string>() {
        { Consts.Characters.Druid, "Sprites/Actors/Druid" },
        { Consts.Characters.Hunter, "Sprites/Actors/Hunter" },
        { Consts.Characters.Mage, "Sprites/Actors/Mage" },
        { Consts.Characters.Paladin, "Sprites/Actors/Paladin" },
        { Consts.Characters.Priest, "Sprites/Actors/Priest" },
        { Consts.Characters.Rogue, "Sprites/Actors/Rogue" },
        { Consts.Characters.Shaman, "Sprites/Actors/Shaman" },
        { Consts.Characters.Warlock, "Sprites/Actors/Warlock" },
        { Consts.Characters.Warrior, "Sprites/Actors/Warrior" }
    };

    public Consts.Characters Type;

    public void SetType(Consts.Characters type) {
        Type = type;
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(spriteMap[type]);
    }
    
}
