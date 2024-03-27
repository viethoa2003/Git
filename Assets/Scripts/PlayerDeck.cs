using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<GameObject> count = new List<GameObject>();

    public List<GameObject> display = new List<GameObject>();

    public int index;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RandomCount();
        }
    }
    public void RandomCount()
    {
        index = Random.Range(0, count.Count);
        {
            display.Add(count[index]);
            count.Remove(count[index]);
        }
    }
}
