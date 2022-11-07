using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {
    private static Dictionary<string, Consts.TileTypes> stringToTileMap = new Dictionary<string, Consts.TileTypes>() {
        { "high", Consts.TileTypes.High },
        { "low", Consts.TileTypes.Low },
        { "mid", Consts.TileTypes.Middle },
        { "water", Consts.TileTypes.Water },
        { "tree", Consts.TileTypes.Tree },
        { "rock", Consts.TileTypes.Rock }
    };
    
    public static List<List<Consts.TileTypes?>> GetLevel() {
        string?[,] stringLevel = new string?[,] {
            { null, null, "high", "mid", "low", "low", null, null, null },
            { null, "rock", "high", "low", "low", "low", "low", null, null },
            { "high", "high", "rock", "low", "water", "tree", "low", "low", null },
            { "mid", "low", "low", "low", "low", "water", "tree", "low", "low" },
            { "low", "low", "water", "low", "tree", "low", "water", "low", "low" },
            { "low", "low", "tree", "water", "low", "low", "low", "low", "mid" },
            { null, "low", "low", "tree", "water", "low", "rock", "high", "high" },
            { null, null, "low", "low", "low", "low", "high", "rock", null },
            { null, null, null, "low", "low", "mid", "high", null, null }
        };

        List<List<Consts.TileTypes?>> tileLevel = new List<List<Consts.TileTypes?>>();
        for (int i = 0; i < 9; i++) {
            tileLevel.Add(new List<Consts.TileTypes?>());
            for (int j = 0; j < 9; j++) {
                if (stringLevel[i, j] is null) {
                    tileLevel[i].Add(null);
                }
                else {
                    tileLevel[i].Add(stringToTileMap[stringLevel[i, j]]);
                }
            }
        }

        return tileLevel;
    }
}
