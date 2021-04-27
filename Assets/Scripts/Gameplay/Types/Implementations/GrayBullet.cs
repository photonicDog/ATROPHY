using Assets.Scripts.Gameplay.Controllers;
using Assets.Scripts.Gameplay.Types.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Gameplay.Types.Implementations
{
    public class GrayBullet : IBullet
    {
        public Color Colour => Color.gray;

        public void OnImpact(RaycastHit target)
        {
            if (target.transform.CompareTag("Enemy"))
            {
                var enemy = target.transform.GetComponent<EnemyController>();
                enemy.hitBy.Add(this);

                if (enemy != null)
                {
                    enemy.hitpoints -= 1;

                    if (enemy.hitpoints == 0)
                    {
                        enemy.OnDeath();
                    }
                }
            }
        }
    }
}