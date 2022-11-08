using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    private Dictionary<Consts.TileTypes, string> spriteMap = new Dictionary<Consts.TileTypes, string>() {
        { Consts.TileTypes.Low, "Sprites/Tiles/Low" },
        { Consts.TileTypes.High, "Sprites/Tiles/High" },
        { Consts.TileTypes.Middle, "Sprites/Tiles/Middle" },
        { Consts.TileTypes.Rock, "Sprites/Tiles/Rock" },
        { Consts.TileTypes.Water, "Sprites/Tiles/Water" },
        { Consts.TileTypes.Tree, "Sprites/Tiles/Tree" },
    };

    public Consts.TileTypes Type;

    public void SetType(Consts.TileTypes type) {
        Type = type;
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(spriteMap[type]);
    }
}
