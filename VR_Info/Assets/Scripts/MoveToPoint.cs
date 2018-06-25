using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveToPoint : MonoBehaviour {

    public TextMeshProUGUI displayText;
    public GameObject player;
    public GvrAudioSource[] sources;
    private Behaviour halo;


    void Start()
    {
        halo = (Behaviour)gameObject.GetComponent("Halo");
        halo.enabled = false;
    }

    public void Move()
    {
        //stop any display audio from playing
        for(int i = 0; i < sources.Length; i++)
        {
            sources[i].Stop();
        }
        
        iTween.MoveTo(player,
            iTween.Hash(
                "x", gameObject.transform.position.x,
                "z", gameObject.transform.position.z,
                "time", .2,
                "easetype", "linear"
            )
        );
    }

    public void LookAt(string newText)
    {
        displayText.text = newText;
        halo.enabled = true;
    }

    public void LookAway()
    {
        halo.enabled = false;
        displayText.text = "";
    }


}
