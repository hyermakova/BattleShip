﻿using System;


using BattleShip.GameEngine.Location;



namespace BattleShip.GameEngine.Arsenal.Flot
{
    class TwoStoreyShip : ShipRectangleBase
    {
        public TwoStoreyShip(byte id, Position begin, Position end)
            : base(id, begin, end)
        {
            _storeyCount = 2;
        }
    }
}