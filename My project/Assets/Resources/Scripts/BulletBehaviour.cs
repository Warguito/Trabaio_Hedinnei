using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.vida--;
            Debug.Log("Ai");
        }

        Debug.Log("Au");

        Destroy(this.gameObject);
    }
    void Update()
    {
        this.transform.position += transform.forward * speed *Time.deltaTime;
    }
}
