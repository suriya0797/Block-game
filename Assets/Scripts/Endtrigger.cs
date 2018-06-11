using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour {

    public GameManager GameManager;

    public void OnTriggerEnter()
    {
        GameManager.Levelcomplete();
    }
}