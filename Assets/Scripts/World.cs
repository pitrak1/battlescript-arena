using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class World : MonoBehaviour {

    public GameObject TilePrefab;
    public GameObject ActorPrefab;
    public List<List<Tile>> Tiles = new List<List<Tile>>();

    void Start() {
        List<List<Consts.TileTypes?>> tiles = LevelLoader.GetLevel();
        
        for (int j = 0; j < 9; j++) {
            Tiles.Add(new List<Tile>());
            for (int i = 0; i < 9; i++) {
                if (tiles[j][i] is not null) {
                    Vector3 position = new Vector3(-4.5f + i - (j * 0.5f), 4.5f + -j * 0.72f, 0f);
                    GameObject tile = Instantiate(TilePrefab, position, Quaternion.identity, transform);
                    SpriteRenderer renderer = tile.GetComponent<SpriteRenderer>();
                    renderer.sortingOrder = j;
                    Tile script = tile.GetComponent<Tile>();
                    script.SetType((Consts.TileTypes)tiles[j][i]);
                    Tiles[j].Add(script);
                }
                else {
                    Tiles[j].Add(null);
                }
            }
        }
        
        AddActor(new Vector2Int(2, 2));
    }

    public void AddActor(Vector2Int coordinates) {
        Tile tile = GetTile(coordinates);
        GameObject actor = Instantiate(ActorPrefab, new Vector3(0, 0, 0), Quaternion.identity, tile.transform);
        actor.transform.localPosition = Vector3.zero;
    }

    public Tile GetTile(Vector2Int coordinates) {
        return Tiles[coordinates.y][coordinates.x];
    }
}
