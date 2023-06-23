using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float moveSpeed = 50f;
    [SerializeField]
    float rotateSpeed = 100f;
    [SerializeField]
    float boostSpeed = 30f;
    [SerializeField]
    float lowerSpeed = 15f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotateAmount = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotateAmount);
        print(rotateAmount);
        transform.Translate(0, moveAmount, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
        if (other.tag == "LowerSpeed")
        {
            moveSpeed = lowerSpeed;
        }

    }

}
