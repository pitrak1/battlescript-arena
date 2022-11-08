using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {
    public GameObject WorldGameObject;
    
    void Start() {
        
    }

    void Update() {
        World worldScript = WorldGameObject.GetComponent<World>();
        Debug.Log(worldScript.GetTile(new Vector2Int(2, 5)).GetComponent<Tile>().Type);
    }
}
