using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hsDotNet
{
    public class Card
    {
        public string cardId{ get; set; }
        public string name{ get; set; }
        public string cardSet{ get; set; }
        public string type{ get; set; }
        public string faction{ get; set; }
        public string rarity{ get; set; }
        public int cost{ get; set; }
        public int attack{ get; set; }
        public int health{ get; set; }
        public string text{ get; set; }
        public string inPlayText{ get; set; }
        public string flavor{ get; set; }
        public string artist{ get; set; }
        public bool collectible{ get; set; }
        public bool elite{ get; set; }
        public string race{ get; set; }
        public string playerClass{ get; set; }
        public string howToGet{ get; set; }
        public string howToGetGold{ get; set; }
        public string img{ get; set; }
        public string imgGold{ get; set; }
        public string locale{ get; set; }
        public string[] mechanics{ get; set; }

    }
}