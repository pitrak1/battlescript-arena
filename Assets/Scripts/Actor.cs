using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {
    public Sprite DruidSprite;
    public Sprite HunterSprite;
    public Sprite MageSprite;
    public Sprite PaladinSprite;
    public Sprite PriestSprite;
    public Sprite RogueSprite;
    public Sprite ShamanSprite;
    public Sprite WarlockSprite;
    public Sprite WarriorSprite;
    
    public Consts.Characters Type { get; private set; }

    public void SetType(Consts.Characters type) {
        Type = type;
        
        Dictionary<Consts.Characters, Sprite> spriteMap = new Dictionary<Consts.Characters, Sprite>() {
            { Consts.Characters.Druid, DruidSprite },
            { Consts.Characters.Hunter, HunterSprite },
            { Consts.Characters.Mage, MageSprite },
            { Consts.Characters.Paladin, PaladinSprite },
            { Consts.Characters.Priest, PriestSprite },
            { Consts.Characters.Rogue, RogueSprite },
            { Consts.Characters.Shaman, ShamanSprite },
            { Consts.Characters.Warlock, WarlockSprite },
            { Consts.Characters.Warrior, WarriorSprite }
        };
        
        GetComponent<SpriteRenderer>().sprite = spriteMap[type];
    }
    
}
