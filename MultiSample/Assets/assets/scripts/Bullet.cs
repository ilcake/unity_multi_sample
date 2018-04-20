using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour {

    private const int bulletDamage = 10;

    void OnCollisionEnter(Collision collision) {
        Destroy(gameObject);

        var hit = collision.gameObject;
        var health = hit.GetComponent<Health>();
        if (health != null) health.TakeDamage(bulletDamage);
    }
}
