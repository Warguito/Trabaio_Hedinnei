using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipocoSpawner : MonoBehaviour
{
    public float cooldown;
    public GameObject bullet;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && cooldown < 0)
        {
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            cooldown = 0.2f;
        }
        else cooldown -= Time.deltaTime;

    }
}
