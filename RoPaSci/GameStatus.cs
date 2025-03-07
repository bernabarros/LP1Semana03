using System;

namespace RoPaSci
{
    [Flags]
    enum GameStatus
    {
        Draw = 1 << 0,
        Player1Wins = 1 << 1,
        Player2Wins = 1 << 2
    }
}