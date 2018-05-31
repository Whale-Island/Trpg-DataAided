using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Trpg_DataAided
{
    public class Manager
    {
        private static readonly Manager manager = new Manager();
        private Manager() { Init(); }
        public static Manager Instance { get { return manager; } }

        private int index;

        public List<Player> list;

        public void Init()
        {
            Tool.Deserialize(out list);
            if (list == null) list = new List<Player>();
            index = list.Count > 0 ? list[list.Count - 1].ID + 1 : 1;
        }

        public void Save(int id, string Nickname, PlayerSnapshot snapshot)
        {
            var player = list.Find(p => p.ID == id);
            player.Nickname = Nickname;
            player.SnapshotList.Add(snapshot);
            player.CurrentProperty = (PlayerProperty)Tool.CopyOjbect(snapshot.Property);

            Tool.Serialize(list);
        }

        internal void Remove(int id)
        {
            list.RemoveAll(p => p.ID == id);
            Tool.Serialize(list);
        }

        internal void Create()
        {
            Player player = new Player
            {
                ID = index++,
                Nickname = "未命名",
            };
            player.SnapshotList.Add(new PlayerSnapshot() {
                Date = DateTime.Now,
                Category = CategoryEnum.Init,
                Description = "初始化!",
                Property = (PlayerProperty)Tool.CopyOjbect(player.CurrentProperty),
            });
            list.Add(player);
            Tool.Serialize(list);
        }
    }
}
