using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject player;
    public float zOffset;
    void Update()
    {
        Vector3 screenPoint = Input.mousePosition; // Recibimos pos del mouse en pixeles
        screenPoint.z = player.transform.position.z; // Le igualamos la z a la del player. 
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(screenPoint); //Transformamos la posicion del mouse de pixeles
                                                                           // a mundo
        
        Vector3 playerPos = player.transform.position; // Agarramos la posicion del player
         
        Vector3 cameraDis = (worldPoint - playerPos)/2; // Creamos nuestro vector de displacement.
        
        Camera.main.transform.position = playerPos + cameraDis; // Movemos la camara a player+displacement.
        Camera.main.transform.position -= Camera.main.transform.forward*zOffset; // Offset a la z
    }
}
