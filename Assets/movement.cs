using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movement : MonoBehaviour
{
    public int speed = 0;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        // get input data from keyboard or controller
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // update player position based on input
        Vector3 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.z += moveVertical * speed * Time.deltaTime;
        //position = Quaternion.AngleAxis(transform.eulerAngles.y, Vector3.up) * position;
        transform.position = position;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y - Input.GetAxis("Fire1") * speed * 13 * Time.deltaTime, 0);
    }
}