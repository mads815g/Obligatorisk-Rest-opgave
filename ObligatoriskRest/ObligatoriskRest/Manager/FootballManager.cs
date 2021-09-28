using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football;

namespace ObligatoriskRest.Manager
{
    public class FootballManager
    {
        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer("Mads", 200, 2),
            new FootballPlayer ("Peter", 100, 6),
            new FootballPlayer ("Jakob", 300, 9),
            new FootballPlayer ("Niels", 400, 4)
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }

        public FootballPlayer GetById(int id)
        {
            return Data.Find(FootballPlayer => FootballPlayer.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newFootballPlayer)
        {
            Data.Add(newFootballPlayer);
            return newFootballPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer FootballPlayer = Data.Find(FootballPlayer1 => FootballPlayer1.Id == id);
            if (FootballPlayer == null) return null;
            Data.Remove(FootballPlayer);
            return FootballPlayer;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer FootballPlayer = Data.Find(FootballPlayer1 => FootballPlayer1.Id == id);
            if (FootballPlayer == null) return null;
            FootballPlayer.Name = updates.Name;
            FootballPlayer.Price = updates.Price;
            FootballPlayer.ShirtNumber = updates.ShirtNumber;
            return FootballPlayer;
        }
    }
}
