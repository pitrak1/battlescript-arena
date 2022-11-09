using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public GameObject CameraGameObject;
    public GameObject ActorLabelPrefab;

    public void AddActorLabel(Tile tile, Actor actor) {
        Vector3 viewPos = CameraGameObject.GetComponent<Camera>().WorldToViewportPoint(tile.transform.position);
        Rect pixelRect = CameraGameObject.GetComponent<Camera>().pixelRect;
        Vector3 position = new Vector3(pixelRect.width * viewPos.x, pixelRect.height * viewPos.y);
        GameObject actorInfo = Instantiate(ActorLabelPrefab, position, Quaternion.identity, transform);
    }
}
