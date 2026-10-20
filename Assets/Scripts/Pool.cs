using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;

public class Pool : MonoBehaviour
{
    public int amount;
    [System.NonSerialized] public Queue pool = new Queue();
    public GameObject arrowPrefab;
    public GameObject bulletSpawn;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject obj = Instantiate(arrowPrefab, bulletSpawn.transform.position, quaternion.identity);
            obj.SetActive(false);
            pool.Enqueue(obj.GetComponent<Arrow>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
