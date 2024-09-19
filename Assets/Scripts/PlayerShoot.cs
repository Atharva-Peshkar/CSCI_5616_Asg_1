using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerShoot : MonoBehaviour
{
    // [SerializeField]
    // private GameObject BulletTemplate;
    // private float shootPower = 100f;

    public GameObject BulletTemplate;
    public float shootPower = 100000f;

    public InputActionReference trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot(InputAction.CallbackContext _) {
        GameObject redBullet = Instantiate(BulletTemplate,transform.position,transform.rotation);
        redBullet.GetComponent<Rigidbody>().AddForce(transform.forward*shootPower);
    }

    // void OnCollisionEnter(Collision BulletTemplate) {
    //     Debug.Log(BulletTemplate.gameObject.name);
    // }
}


