﻿using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;

using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Core.Contracts
{
    public class Controller : IController
    {
        private GunRepository gunRepository;
        private PlayerRepository playerRepository;
        private IMap map;

        public Controller()
        {
            gunRepository = new GunRepository();
            playerRepository = new PlayerRepository();
            map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            IGun gun;
            if (type == "Pistol")
            {
                gun = new Pistol(name, bulletsCount);

            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name, bulletsCount);

            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }

            gunRepository.Add(gun);
            return $"Successfully added gun {gun.Name}.";
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IPlayer player;
            IGun gun = gunRepository.FindByName(gunName);

            if (gun == null)
            {
                throw new ArgumentException("Gun cannot be found!");
            }

            if (type == "Terrorist")
            {
                player = new Terrorist(username, health, armor, gun);
            }
            else if (type == "CounterTerrorist")
            {
                player = new CounterTerrorist(username, health, armor, gun);
            }
            else
            {
                throw new ArgumentException("Invalid player type!");
            }

            playerRepository.Add(player);
            return $"Successfully added player {username}.";
        }

        public string Report()
        {
            var sortedPlayers = playerRepository.Models
                .OrderBy(p => p.GetType().Name)
                .ThenByDescending(p => p.Health)
                .ThenBy(p => p.Username);

            StringBuilder sb = new StringBuilder();

            foreach (var player in sortedPlayers)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string StartGame()
        {
            return map.Start(playerRepository.Models.ToList());
        }
    }
}