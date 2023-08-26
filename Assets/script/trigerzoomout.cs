using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerzoomout : MonoBehaviour
{
    public Collider bola;
    public cameracontroler cameraController;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.GoBackToDefault();
        }
    }

    
}
