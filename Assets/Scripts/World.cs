using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class World : MonoBehaviour {

    public GameObject TilePrefab;
    void Start() {
        List<List<Consts.TileTypes?>> tiles = LevelLoader.GetLevel();
        
        for (int j = 0; j < 3; j++) {
            for (int i = 0; i < 3; i++) {
                if (tiles[j][i] is not null) {
                    Vector3 position = new Vector3(i + (j * 0.5f), -j * 0.72f, 0f);
                    GameObject tile = Instantiate(TilePrefab, position, Quaternion.identity, transform);
                    SpriteRenderer renderer = tile.GetComponent<SpriteRenderer>();
                    renderer.sortingOrder = j;
                    Tile script = tile.GetComponent<Tile>();
                    script.SetType((Consts.TileTypes)tiles[j][i]);
                }
            }
        }
    }

    public Transform GetTile(Vector2Int coordinates) {
        return transform.GetChild(coordinates.x + coordinates.y * 3);
    }
}
