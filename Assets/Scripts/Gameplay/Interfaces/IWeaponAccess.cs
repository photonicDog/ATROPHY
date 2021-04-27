using Assets.Scripts.Gameplay.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Gameplay.Interfaces
{
    public interface IWeaponAccess
    {
        void CollectBullet(IBullet bullet);
    }
}
