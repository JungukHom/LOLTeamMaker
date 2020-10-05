using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLTeamMaker.Data
{
    class PlayerDataContainer
    {
        // private class instance holder
        private static PlayerDataContainer _instance = null;

        // static instance getter
        public static PlayerDataContainer GetOrCreateInstance()
        {
            return _instance ?? (_instance = new PlayerDataContainer());
        }

        // private class constructor
        private PlayerDataContainer()
        {   
            data = new List<Player>(); // initialize data holder list
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        // private data holder
        private readonly List<Player> data = null;

        public List<Player> GetListData()
        {
            return this.data;
        }

        // check data overlapping and add data
        public bool AddData(Player player)
        {
            if (CheckListDataExists(player.NickName))
            {
                return false;
            }

            data.Add(player);
            return true;
        }

        // check data existing and remove data
        public bool RemoveData(Player player)
        {
            if (!CheckListDataExists(player.NickName))
            {
                return false;
            }

            data.Remove(player);
            return true;
        }

        // return assigned player data count
        public int GetPlayerCount()
        {
            return data.Count;
        }

        // check data overlapping
        private bool CheckListDataExists(string playerNickName)
        {
            foreach (Player player in data)
            {
                if (player.NickName == playerNickName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
