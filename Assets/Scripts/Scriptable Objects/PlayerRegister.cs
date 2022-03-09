using System;
using Player;
using UnityEngine;

namespace Scriptable_Objects
{
    [CreateAssetMenu(fileName = "NewPlayerRegister", menuName = "User/Player/Player Register", order = 0)]
    public class PlayerRegister : UnityEngine.ScriptableObject
    {
        [SerializeField] private PlayerProfile[] players;

        public PlayerProfile[] Players => players;

        private int _lastLength;

        private void Awake()
        {
            _lastLength = players.Length;
        }

        private void OnValidate()
        {
            if (players.Length > _lastLength) players[_lastLength] = new PlayerProfile();
            _lastLength = players.Length;
        }
    }
}