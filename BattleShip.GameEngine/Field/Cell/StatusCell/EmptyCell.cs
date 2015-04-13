﻿using System;

using BattleShip.GameEngine.GameObject;
using BattleShip.GameEngine.Location;

namespace BattleShip.GameEngine.Field.Cell.StatusCell
{
    // клас пустої клітинки
    class EmptyCell : StatusCell
    {
        public EmptyCell(Position position)
            : base(position)
        { }
    }
}