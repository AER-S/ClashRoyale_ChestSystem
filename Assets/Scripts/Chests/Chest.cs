using UnityEngine;

namespace Chests
{
    [UnityEngine.CreateAssetMenu(fileName = "NewChestType", menuName = "User/Chests/Chest Type", order = 0)]
    public class Chest : UnityEngine.ScriptableObject
    {
        [System.Serializable]
        private struct CurrencyRange
        {
            public int min;
            public int max;
        }

        [SerializeField] private float timeToOpen;
        [SerializeField] private CurrencyRange coinsRange;
        [SerializeField] private CurrencyRange gemsRange;
    }
}