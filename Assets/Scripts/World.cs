using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class World : MonoBehaviour {

    public GameObject TilePrefab;
    public List<List<Tile>> Tiles = new List<List<Tile>>();
    
    public GameObject ActorPrefab;
    public List<Actor> Actors = new List<Actor>();

    void Start() {
        List<List<Consts.TileTypes?>> tiles = LevelLoader.GetLevel();
        
        for (int j = 0; j < 9; j++) {
            Tiles.Add(new List<Tile>());
            for (int i = 0; i < 9; i++) {
                if (tiles[j][i] is not null) {
                    Vector3 position = new Vector3(-1.5f + i - (j * 0.5f), 3f + -j * 0.72f, 0f);
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
    }

    public Actor AddActor(Vector2Int coordinates, Consts.Characters type) {
        Tile tile = GetTile(coordinates);
        GameObject actor = Instantiate(ActorPrefab, tile.transform.position, Quaternion.identity, tile.transform);
        Actor script = actor.GetComponent<Actor>();
        script.SetType(type);
        Actors.Add(script);
        return script;
    }

    public Tile GetTile(Vector2Int coordinates) {
        return Tiles[coordinates.y][coordinates.x];
    }
}
