using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_Serveur
{
    class Player
    {        
        public String[] PorteAvion = new String[5];
        public String[] Croiseur = new String[4];
        public String[] ContreTourpilleur = new String[3];
        public String[] SousMarin = new String[3];       
        public String[] Tourpilleur = new String[2];

        public bool alive_PorteAvion = true;
        public bool alive_Croiseur = true;
        public bool alive_ContreTourpilleur = true;
        public bool alive_SousMarin = true;
        public bool alive_Tourpilleur = true;

        public bool bPorteAvion = false;
        public bool bCroiseur = false;
        public bool bContreTourpilleur = false;
        public bool bSousMarin = false;
        public bool bTourpilleur = false;

    }
}
