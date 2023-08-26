using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigerzoomincontroler : MonoBehaviour
{
    public Collider bola;
    public cameracontroler cameraControler;
    public float length;

    private void OnTrigerEnter(Collider other)
    {
        if(other == bola)
        {
            cameraControler.FollowTarget(bola.transform, length);
        }
    } 
}
