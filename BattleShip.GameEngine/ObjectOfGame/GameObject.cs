﻿using BattleShip.GameEngine.GameEventArgs;
using System;

namespace BattleShip.GameEngine.ObjectOfGame
{
    public abstract class GameObject
    {
        public GameObject(byte id)
        {
            ID = id;
        }

        // чи живий
        public abstract bool IsLife { get; }

        public byte ID { get; private set; }

        // івент вмирання об'єкта
        public abstract event Action<GameObject, GameEvenArgs> DeadHandler;

        // івент влучання в об'єкт
        public abstract event Action<GameObject, GameEvenArgs> HitMeHandler;

        public abstract void OnHitMeHandler(GameObject g, GameEvenArgs e);
    }
}