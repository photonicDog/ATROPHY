using Assets.Scripts.Gameplay.Input;
using Assets.Scripts.Gameplay.Types.Implementations;
using Assets.Scripts.Gameplay.Types.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Gameplay.Controllers
{
    public class RightHandWeaponController : MonoBehaviour
    {
        public List<IBullet> Ammo;
        public int maxAmmo = 6;
        public Transform cameraTransform;
        public ParticleSystem muzzleFlash;
        public GameObject bulletHole;

        private InputManager inputManager;

        // Use this for initialization
        void Start()
        {
            inputManager = InputManager.Instance;
            cameraTransform = Camera.main.transform;
            Ammo = new List<IBullet>();
            Reload();

        }

        // Update is called once per frame
        void Update()
        {
            if (Ammo.Count > 0 && inputManager.RightHandFired())
            {
                var currentBullet = Ammo[0];
                Ammo.RemoveAt(0);
                Fire(currentBullet);
            }
        
            if (inputManager.Reloaded())
            {
                Reload();
            }

            //Debug.Log(Ammo.Count);
        }

        void Fire(IBullet bullet)
        {
            RaycastHit target;
            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out target))
            {
                bullet.OnImpact(target);
                muzzleFlash.Play();
                Instantiate(bulletHole, target.point + 0.1f*(target.normal), Quaternion.LookRotation(-target.normal));
            }
        }

        void CollectBullet(IBullet bullet)
        {
            if(Ammo.Count < maxAmmo)
            {
                Ammo.Add(bullet);
            }
        }

        void Reload()
        {
            Ammo.Clear();
            for (int i = 0; i < maxAmmo; i++)
            {
                CollectBullet(new GrayBullet());
            }
        }
    }
}