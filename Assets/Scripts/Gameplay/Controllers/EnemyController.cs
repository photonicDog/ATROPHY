using Assets.Scripts.Gameplay.Types.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Gameplay.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        public int hitpoints;
        public List<IBullet> hitBy;
        public GameObject bulletPrefab;

        // Use this for initialization
        void Start()
        {
            hitBy = new List<IBullet>();
        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log($"{gameObject.name}: {hitpoints}");
        }

        public void OnDeath()
        {
            DropBullet();
            Destroy(gameObject);
        }

        void DropBullet()
        {
            if(hitBy.Count == 1)
            {
                bulletPrefab.GetComponent<DroppedBulletController>().isSingle = true;
                Instantiate(bulletPrefab, transform.position, transform.rotation);
            }
        }
    }
}