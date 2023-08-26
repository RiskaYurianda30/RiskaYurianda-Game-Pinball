using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class switchcontroler : MonoBehaviour
{
    public Collider bola;
    public Material ofMaterial;
    public Material onMaterial;
    public float score;
    public ScoreManager scoreManager;

    private bool isOn;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        Set(false); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Set(!isOn);
        }
    }

    private void Set(bool active)
    {
        isOn = active;

        if (isOn == true)
        {
            renderer.material = onMaterial;
        }
        else
        {
            renderer.material = ofMaterial;
        }

        //score
        scoreManager.AddScore(score);
    }
}
