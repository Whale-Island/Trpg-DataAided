using System.Collections.Generic;

namespace Trpg_DataAided
{
    public class Player
    {
        public int ID { get; set; }
        public string Nickname { get; set; } = "";

        public PlayerProperty CurrentProperty { get; set; } = new PlayerProperty();

        public List<PlayerSnapshot> SnapshotList { get; set; } = new List<PlayerSnapshot>();


    }
}
