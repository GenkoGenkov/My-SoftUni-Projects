using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorist;
        private List<IPlayer> counterTerrorist;

        public Map()
        {
            terrorist = new List<IPlayer>();
            counterTerrorist = new List<IPlayer>();
        }

        public string Start(ICollection<IPlayer> players)
        {
            SeparatePlayersInTwoTeams(players);

            while (IsTeamAlive(terrorist) && IsTeamAlive(counterTerrorist))
            {
                AttackTeam(terrorist, counterTerrorist);
                AttackTeam(counterTerrorist, terrorist);


            }

            if (IsTeamAlive(terrorist))
            {
                return "Terrorist wins!";
            }
            else if (IsTeamAlive(counterTerrorist))
            {
                return "Counter Terrorist wins!";
            }

            return "Something whrong!!!";




        }

        private bool IsTeamAlive(List<IPlayer> players)
        {
            return players.Any(p => p.IsAlive);
        }

        private void AttackTeam(List<IPlayer> attakingTeam, List<IPlayer> defendingTeam)
        {
            foreach (var attacker in attakingTeam)
            {
                if (!attacker.IsAlive) continue;

                foreach (var defender in defendingTeam)
                {
                    if (defender.IsAlive)
                    {
                        defender.TakeDamage(attacker.Gun.Fire());
                    }
                }
            }
        }

        public void SeparatePlayersInTwoTeams(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player is CounterTerrorist)
                {
                    counterTerrorist.Add(player);
                }
                else if (player is Terrorist)
                {
                    terrorist.Add(player);
                }
            }
        }
    }
}
