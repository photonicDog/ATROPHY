using Assets.Scripts.Gameplay.Types.Implementations;
using Assets.Scripts.Gameplay.Types.Interfaces;
using System.Collections;
using UnityEngine;

public class DroppedBulletController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public IBullet bullet;
    public bool isSingle;

    private Collider bulletCollider;
    private Rigidbody bulletRigidbody;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = bulletPrefab.GetComponent<Rigidbody>();
        bulletCollider = bulletPrefab.GetComponent<Collider>();
        bullet = new GrayBullet();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            var player = collider.gameObject.GetComponent<PlayerController>();
            if (player.AddBullet(bullet))
            {
                Destroy(gameObject);
            }
        }
    }
}
