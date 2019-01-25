using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScizzorsLizardSpock
{
    class Human : Player
    {
        // class - … Is A …
        // member variables - … Has A …

        // constructor … Spawns A …
        public Human(string name, bool isHuman)
            :base(name,isHuman)
        {
            this.name = name;
            this.isHuman = isHuman;
            this.score = 0;
        }
        // member methods - … Can Do …


    }
}
