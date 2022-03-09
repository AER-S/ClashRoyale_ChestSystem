using UnityEngine;

namespace Player
{
    [System.Serializable]
    public class PlayerProfile
    {
        [SerializeField] private string name = "Put a Name here.";
        [SerializeField] private int coins = 1000;
        [SerializeField] private int gems = 20;

        public string Name => name;
        public int Coins => coins;
        public int Gems => gems;
    }
}
