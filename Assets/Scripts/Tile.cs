using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    public Sprite LowSprite;
    public Sprite HighSprite;
    public Sprite MiddleSprite;
    public Sprite RockSprite;
    public Sprite WaterSprite;
    public Sprite TreeSprite;

    public Consts.TileTypes Type;

    public void SetType(Consts.TileTypes type) {
        Type = type;
        
        Dictionary<Consts.TileTypes, Sprite> spriteMap = new Dictionary<Consts.TileTypes, Sprite>() {
            { Consts.TileTypes.Low, LowSprite },
            { Consts.TileTypes.High, HighSprite },
            { Consts.TileTypes.Middle, MiddleSprite },
            { Consts.TileTypes.Rock, RockSprite },
            { Consts.TileTypes.Water, WaterSprite },
            { Consts.TileTypes.Tree, TreeSprite },
        };
        
        GetComponent<SpriteRenderer>().sprite = spriteMap[type];
    }
}
