using AdvancedAflevering.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AdvancedAflevering
{
     public class World
    {
        private List<ICharacter> _characters = new List<ICharacter>();
        private List<IWorldObject> _worldObject = new List<IWorldObject>();
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public List<ICharacter> Characters
        {
            get { return _characters; }   
            set { _characters = value; }
        }

        public List<IWorldObject> WorldObject
        {
            get { return _worldObject; }
            set { _worldObject = value; }
        }

        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
        }

    }
}
