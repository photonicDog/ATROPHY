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
            var enemy = target.transform.GetComponent<EnemyController>();
            if (enemy != null)
            {
                enemy.hitpoints -= 1;
            }
        }
    }
}