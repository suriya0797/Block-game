using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    bool Gameend = false;
    public float gamedelay = 1f;
    public GameObject Levelcompleteui;
  
    public void Levelcomplete()
    {
        Levelcompleteui.SetActive(true);
       
    }
	public void EndGame()
    {
        if (Gameend == false)
        {
            Gameend = true;
            Invoke("Restart", gamedelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
