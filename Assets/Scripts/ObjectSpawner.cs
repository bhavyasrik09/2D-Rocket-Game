using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public static ObjectSpawner Instance;
    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null )
        {
            Instance = this;

        }
        StartCoroutine(SpawnItems(2f));
    }
    IEnumerator SpawnItems(float time)
    {
        yield return new WaitForSeconds(time);
        Vector2 pos = new Vector2(transform.position.x,Random.RandomRange(0,3));
        Instantiate(obstacle,pos, Quaternion.identity);
        StartCoroutine(SpawnItems(Random.Range(1f,3f)));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
