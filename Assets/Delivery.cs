using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(0, 0, 0, 1);
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 1);
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hoy cheteh ? !");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Package picked up ");
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, 0.1f);

        }
        if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            Debug.Log("Package delliverd !");
            spriteRenderer.color = noPackageColor;
            spriteRenderer.color = noPackageColor;
        }
    }
}
