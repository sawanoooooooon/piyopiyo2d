using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed = 3.0f;//移動加速度
    Rigidbody rig;
    public float Upspeed;
 


    // Use this for initialization
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();


    }


    //プレイヤー移動
    void Move()
    {

        //右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        //左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }



    }




    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Ground" && Input.GetKey(KeyCode.Space)) 
        {
            rig.AddForce(transform.up * Upspeed);

        }
    }
}