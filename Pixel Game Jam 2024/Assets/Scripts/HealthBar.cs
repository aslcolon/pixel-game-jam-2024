using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;

    public KeyHolder refIsSpawn4, refIsSpawn8;

    // Implement decrease timer
    public double decRate = 0.1;
    private float timer = 0;

    private void Start()
    {
        refIsSpawn4 = GameObject.Find("Key4").GetComponent<KeyHolder>();
        refIsSpawn8 = GameObject.Find("Key8").GetComponent<KeyHolder>();
    }

    private void Update()
    {
        if (timer < decRate)
        {
            timer += Time.deltaTime;
        }
        else if (refIsSpawn4.isSpawnP1 == false && gameObject.name == "Health bar P2")
        {
            if (slider.value >= 50)
            {
                slider.value -= 50;
            }
            timer = 0;
        }
        /*else if (refIsSpawn4.isSpawnP1 == true && slider.value == 0)
        {
            for (int i = 1; i < 9; i++)
            {
                GameObject.Find("Prefab Spawn" + (i).ToString()).GetComponent<SpriteRenderer>().enabled = false;
            }
        }*/
        else if (refIsSpawn8.isSpawnP2 == false && gameObject.name == "Health bar P1")
        {
            if (slider.value >= 50)
            {
                slider.value -= 50;
            }
            timer = 0;
        }
        /*else if (refIsSpawn8.isSpawnP2 == true && slider.value == 0)
        {
            for (int i = 1; i < 9; i++)
            {
                GameObject.Find("Prefab Spawn" + (i).ToString()).GetComponent<SpriteRenderer>().enabled = false;
            }
        }*/

    }
}
