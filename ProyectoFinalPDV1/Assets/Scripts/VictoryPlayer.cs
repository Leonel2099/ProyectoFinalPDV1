using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rehen")
        {
            SceneManager.LoadScene("YouWon");
            //AudioManager.YouWin();
        }
    }
}
