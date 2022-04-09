using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    public static float speed = 10f;
    public static float MaxHealth = 10f;
    public static float Damage = 2f;
    [HideInInspector] public float CurrentHealth;
    public GameObject model;
    private Rigidbody rb;

    public enum DragonType
    {
        Red, 
        Blue
    }
    public DragonType type;

    private void Awake()
    {
        CurrentHealth = MaxHealth;
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    private void FixedUpdate()
    {
        // Make speed a constant
        rb.velocity = rb.velocity.normalized * speed;
        // Look towards forward
        model.transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    private void OnCollisionEnter(Collision other)
    {
        // Inflict damage to itself and the other dragon if its a different type
        if (other.transform.tag == "Dragon" && other.gameObject.GetComponent<Dragon>().type != type)
        {
            InflictDamage(Damage);
            other.gameObject.GetComponent<Dragon>().InflictDamage(Damage);
        }
    }

    public void InflictDamage(float amount)
    {
        // Reduce health
        CurrentHealth -= amount;
        if (CurrentHealth <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
