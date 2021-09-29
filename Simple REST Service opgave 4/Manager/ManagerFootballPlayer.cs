using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simple_REST_Service_opgave_4.Manager;

namespace Simple_REST_Service_opgave_4.Models
{
    public class ManagerFootballPlayer : IManageFootballPlayer
    {
        public static List<FootballPlayer> Players = new List<FootballPlayer>()
        {
            new FootballPlayer(1, "John Johnson", 50000, 20),
            new FootballPlayer(2, "Mikkel Madsen", 70000, 42),
            new FootballPlayer(3, "Bænkebidderen", 2000, 55),
            new FootballPlayer(4, "John H.", 70000, 12),
            new FootballPlayer(5, "Zato Goldlewis", 5000000, 69)
        };
        public bool Create(FootballPlayer value)
        {       
            int NextId =+ Players.Count();
            value.Id = NextId;  //Man bliver stadig spurgt om Id, men den autogeneret Id bliver posted alligevel.
            Players.Add(value);
     
            return true;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = Get(id);
            Players.Remove(player);
            return player;
        }

        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(Players);
        }

        public FootballPlayer Get(int id)
        {
            return Players.Find(i=>i.Id == id);
        }

        public bool Update(int id, FootballPlayer value)
        {
            FootballPlayer player = Get(id);
            if (player != null)
            {
                player.Id = value.Id;
                player.Name = value.Name;
                player.Price = value.Price;
                player.ShirtNumber = value.ShirtNumber;
                return true;
            }
            return false;
        }
    }
}
