using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameState
    {
        Worm worm = new Worm('O');
        Food food = new Food('@');
        Wall wall = new Wall('#');

        public GameState()
        {
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
        }
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            worm.Draw();
            food.Draw();
            wall.Draw();

        }
        public void CheckCollision()
        {
            if (worm.CheckIntersection())
            {

            }
            else if (worm.CheckIntersection(food.body[0]))
            {
                worm.Eat(food.body[0]);
                food.GenerateLocation(worm.body, wall.body);
            }

        }

        public void ProcessKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    worm.Move(0, 1);
                    break;
                case ConsoleKey.RightArrow:
                    worm.Move(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Move(-1, 0);
                    break;
            }
            CheckCollision();
        }


    }

}
