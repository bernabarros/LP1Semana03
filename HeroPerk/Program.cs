using System;

namespace HeroPerk
{
    [Flags]
    enum Perks
    {
        WarpShift = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
    public class Program
    {
        private static void Main(string[] args)
        {
            Perks player_perks = 0;
            string perk_picks = "";

            for(int i = 0; i < args.Length; i++)
            {
                perk_picks += args[i];
            }

            foreach (char argumento in perk_picks)
            {
                if (argumento.Equals('w') == true)
                {
                    player_perks ^= Perks.WarpShift;
                }
                else if (argumento.Equals('s') == true)
                {
                    player_perks ^= Perks.Stealth;
                }
                else if (argumento.Equals('a') == true)
                {
                    player_perks ^= Perks.AutoHeal;
                }
                else if (argumento.Equals('d') == true)
                {
                    player_perks ^= Perks.DoubleJump;
                }
                else
                {
                    Console.WriteLine("!Unknown perk!");
                    return;
                }
            }
            if(player_perks.HasFlag(Perks.AutoHeal) | player_perks.HasFlag(
                Perks.Stealth) | player_perks.HasFlag(Perks.DoubleJump) |
                player_perks.HasFlag(Perks.WarpShift))
                {
                    Console.WriteLine(player_perks);
                }
            else
            {
                Console.WriteLine("!No perks at all!");
            }
            if (player_perks.HasFlag(Perks.Stealth) & player_perks.HasFlag(
            Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }
            if ((player_perks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}
