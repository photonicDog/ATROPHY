using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Gameplay.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        public int hitpoints;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(hitpoints == 0)
            {
                Destroy(gameObject);
            }
            //Debug.Log($"{gameObject.name}: {hitpoints}");
        }
    }
}