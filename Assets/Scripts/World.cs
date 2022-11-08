using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class World : MonoBehaviour {

    public GameObject TilePrefab;
    public GameObject ActorPrefab;
    public List<Tile> Tiles;

    void Start() {
        List<List<Consts.TileTypes?>> tiles = LevelLoader.GetLevel();
        
        for (int j = 0; j < 9; j++) {
            for (int i = 0; i < 9; i++) {
                if (tiles[j][i] is not null) {
                    Vector3 position = new Vector3(-4.5f + i - (j * 0.5f), 4.5f + -j * 0.72f, 0f);
                    GameObject tile = Instantiate(TilePrefab, position, Quaternion.identity, transform);
                    SpriteRenderer renderer = tile.GetComponent<SpriteRenderer>();
                    renderer.sortingOrder = j;
                    Tile script = tile.GetComponent<Tile>();
                    script.SetType((Consts.TileTypes)tiles[j][i]);
                    Tiles.Add(script);
                }
            }
        }
        
        AddActor(new Vector2Int(2, 2));
    }

    public void AddActor(Vector2Int coordinates) {
        Transform tile = GetTile(coordinates);
        GameObject actor = Instantiate(ActorPrefab, new Vector3(0, 0, 0), Quaternion.identity, tile);
        actor.transform.localPosition = Vector3.zero;
    }

    public Transform GetTile(Vector2Int coordinates) {
        return transform.GetChild(coordinates.x + coordinates.y * 3);
    }
}
