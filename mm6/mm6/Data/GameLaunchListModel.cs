using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mm6_controls.Data
{
    public class GameLaunchListModel
    {
        Dictionary<string, GameInstance> gameInstances;

        public IList<GameInstance> Instances { get { return gameInstances.Values.ToList().AsReadOnly(); } }

        public GameLaunchListModel()
        {
            gameInstances = new Dictionary<string, GameInstance>();
        }

        /*public ListViewGroup[] GetListGroups()
        {
            return gameInstances.Select(dr => new ListViewGroup(dr.GetTitle())).ToArray();
        }*/

        private void InstanceFilenameChanged(string oldFilename, string newFilename)
        {
            GameInstance tmp = gameInstances[oldFilename];
            gameInstances.Add(newFilename, tmp);
            gameInstances.Remove(oldFilename);
        }

        public void AddGameInstance(GameInstance NewInstance)
        {
            gameInstances.Add(NewInstance.ID, NewInstance);
            NewInstance.idChanged += InstanceFilenameChanged;
        }

        public GameInstance GetInstanceByName(string key)
        {
            return gameInstances[key];
        }
    }
}
