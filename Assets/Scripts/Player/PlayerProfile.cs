using System.Collections.Generic;
using Chests;
using UnityEngine;

namespace Player
{
    [System.Serializable]
    public class PlayerProfile
    {
        [SerializeField] private string name = "Put a Name here.";
        [SerializeField] private int coins = 1000;
        [SerializeField] private int gems = 20;

        [SerializeReference] private ChestSlot slot0;
        [SerializeReference] private ChestSlot slot1;
        [SerializeReference] private ChestSlot slot2;
        [SerializeReference] private ChestSlot slot3;

        private ChestSlot _currentlyUnlocking;
        private Queue<ChestSlot> _toUnlockSlots;

        public string Name => name;
        public int Coins => coins;
        public int Gems => gems;
    }
}
