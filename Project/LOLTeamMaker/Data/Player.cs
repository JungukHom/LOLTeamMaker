using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LOLTeamMaker.Enum;

namespace LOLTeamMaker.Data
{
    class Player
    {
        public string NickName { get; set; }
        public string Tier { get; set; }
        public string DesiredPosition { get; set; }
        public string AssignedPosition { get; set; }
    }
}
