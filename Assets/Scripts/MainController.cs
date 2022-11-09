using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {
    public GameObject WorldGameObject;
    public GameObject UIGameObject;

    public void HandleClick() {
        World worldScript = WorldGameObject.GetComponent<World>();
        Debug.Log(worldScript.GetTile(new Vector2Int(2, 5)).GetComponent<Tile>().Type);
        Actor actor = worldScript.AddActor(new Vector2Int(2, 2), Consts.Characters.Warlock);
        UIGameObject.GetComponent<UI>().AddActorLabel(worldScript.GetTile(new Vector2Int(2, 2)), actor);
    }
}
