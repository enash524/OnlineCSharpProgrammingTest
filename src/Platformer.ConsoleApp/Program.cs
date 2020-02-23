using System;
using System.Collections.Generic;

namespace Platformer.ConsoleApp
{
    public class Platformer
    {
        private readonly List<int> _tiles = new List<int>();
        private int _position;

        public Platformer(int numberOfTiles, int position)
        {
            _position = position;

            for (int i = 0; i < numberOfTiles; i++)
            {
                _tiles.Add(i);
            }
        }

        public void JumpLeft()
        {
            int index = _tiles.IndexOf(_position);
            int newPosition = _tiles[index - 2];
            _tiles.Remove(_position);
            _position = newPosition;
        }

        public void JumpRight()
        {
            int index = _tiles.IndexOf(_position);
            int newPosition = _tiles[index + 2];
            _tiles.Remove(_position);
            _position = newPosition;
        }

        public int Position()
        {
            return _position;
        }

        public static void Main(string[] args)
        {
            Platformer platformer = new Platformer(6, 3);
            Console.WriteLine(platformer.Position());

            platformer.JumpLeft();
            Console.WriteLine(platformer.Position());

            platformer.JumpRight();
            Console.WriteLine(platformer.Position());
        }
    }
}
