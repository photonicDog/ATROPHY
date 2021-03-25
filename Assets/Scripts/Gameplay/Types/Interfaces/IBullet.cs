using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Gameplay.Types.Interfaces
{
    public interface IBullet
    {
        public Color Colour { get; }
        public void OnImpact(RaycastHit target);
    }
}