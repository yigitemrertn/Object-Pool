using UnityEngine;
using System.Collections.Generic;

public class ArcherShoot : MonoBehaviour
{
    public GameObject poolobj;
    Queue arrows;

    public int ammo = 100;
    float fireRate = .7f;
    float lastShootTime = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        poolobj = GameObject.Find("Pool");
        arrows = poolobj.GetComponent<Pool>().pool;
    }

    // Update is called once per frame
    void Update()
    {

        if (lastShootTime + fireRate < Time.time)
        {

            Arrow a = arrows.Dequeue();
            if (arrows.Count> 0 && !a.gameObject.activeInHierarchy && ammo > 0)
            {
                a.transform.position = gameObject.transform.position;
                a.gameObject.SetActive(true);
                lastShootTime = Time.time;
                ammo--;
            }
            else
            {
                arrows.Enqueue(a);
            }


        }

    }
}
