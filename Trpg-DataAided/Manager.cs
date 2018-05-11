using System;
using System.Collections.Generic;

namespace Trpg_DataAided
{
    public class Manager
    {
        private static readonly Manager manager = new Manager();
        private Manager() { Init(); }
        public static Manager Instance { get { return manager; } }


        public List<Player> list = new List<Player>();

        public void Init()
        {
            Player player = new Player
            {
                Nickname = "asd",
                Level = 1,

            };

            list.Add(player);
        }

        public void Save(Player player)
        {
            int index = list.FindIndex(p => p.ID == player.ID);
            list[index] = player;
        }

        internal void Remove(int id)
        {
            list.RemoveAll(p => p.ID == id);
        }

        internal void Create()
        {
            Player player = new Player
            {
                Level = 0
            };

            list.Add(player);
            player.ID = list.IndexOf(player);
        }
    }
}
