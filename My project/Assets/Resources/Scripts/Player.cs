using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform lookAtObject;
    public int vida;
    [SerializeField] float speed;

    void Start()
    {
        this.vida = 5;
    }

    void Update()
    {
        float AxisY = Input.GetAxis("Vertical");

        Vector3 directon = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        directon = new Vector3(directon.x, -95, directon.z);

        this.transform.LookAt(directon);

          if(this.vida == 0)
            Destroy(this.gameObject);

        if (AxisY > 0)
            this.transform.position += this.transform.forward * speed * AxisY * Time.deltaTime;


    }
}
