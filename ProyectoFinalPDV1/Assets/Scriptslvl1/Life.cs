using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    [SerializeField] private GameObject vida0;
    [SerializeField] private GameObject vida1;
    [SerializeField] private GameObject vida2;
    [SerializeField] private GameObject vida3;
    [SerializeField] private GameObject vida4;
    [SerializeField] private GameObject vida5;
    [SerializeField] private GameObject vida6;
    [SerializeField] private GameObject vida7;
    [SerializeField] private GameObject vida8;
    [SerializeField] private GameObject vida9;
    [SerializeField] private GameObject vida10;
    private Canvas acivar;
    public int vida = 100;
    void Start()
    {

        acivar = GetComponentInChildren<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Sword"))
        {
            Debug.Log("holaaaa" + vida);
            vida -= 10; ;
            if (vida == 90)
            {
                GameObject.Destroy(vida10);
            }
            if (vida == 80)
            {
                GameObject.Destroy(vida9);
            }
            if (vida == 70)
            {
                GameObject.Destroy(vida8);
            }
            if (vida == 60)
            {
                GameObject.Destroy(vida7);
            }
            if (vida == 50)
            {
                GameObject.Destroy(vida6);
            }
            if (vida == 40)
            {
                GameObject.Destroy(vida5);
            }
            if (vida == 30)
            {
                GameObject.Destroy(vida4);
            }
            if (vida == 20)
            {
                GameObject.Destroy(vida3);
            }
            if (vida == 10)
            {
                GameObject.Destroy(vida2);
            }
            if (vida == 0)
            {
                SceneManager.LoadScene("GameOver");
                GameObject.Destroy(vida1);
                //CambioEscena(indiceFin);
                Debug.Log("SOS UN MUERTO");
            }
        }
    }
}
