using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumbercontroler : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    public audiomanager audioManager;
    public vfxmanager vfxManager;
    public ScoreManager scoreManager;
    public void Start()
    {
        GetComponent<Renderer>().material.color = color;
    }
    private void OnCollisionEnter(Collision collision)    
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //playsfx
            audioManager.PlaySFX(collision.transform.position);

            //playvfx
            vfxManager.PlayVFX(collision.transform.position);

            //add score
            scoreManager.AddScore(score);
        }
    }
}
