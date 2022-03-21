using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    bool isCollided;
    public float speed;
    void Start()
    {
        isCollided = false;
        BulletLauncher scr = GameObject.FindObjectOfType<BulletLauncher>();
        transform.LookAt(scr.objectToDestroy.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isCollided)
        {
            transform.Translate(Vector3.forward*Time.deltaTime*speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);
            isCollided = false;
        }
    }


}
