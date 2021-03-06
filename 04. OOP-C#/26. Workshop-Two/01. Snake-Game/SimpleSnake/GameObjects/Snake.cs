using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const char SnakeSymbol = '\u25CF';
        private Queue<Point> snakeElements;
        private readonly Food[] foods;
        private readonly Wall wall;
        private int foodIndex;

        public Snake(Wall wall)
        {
            this.wall = wall;
            this.foods = new Food[] 
            { 
                new FoodAsterisk(this.wall),
                new FoodDollar(this.wall),
                new FoodHash(this.wall),
            };

            CreateSnake();
            
        }

        public bool TryMove(Point point)
        {
            Point snakeHead = this.snakeElements.Last();

            int nextLeftX = snakeHead.LeftX + point.LeftX;
            int nextTopY = snakeHead.TopY + point.TopY;

            bool isSnake = snakeElements.Any(x => x.LeftX == nextLeftX && x.TopY == nextTopY);

            if (isSnake)
            {
                return false;
            }

            bool isWall = nextLeftX < 0 || nextTopY < 0 || nextLeftX >= wall.LeftX || nextTopY >= wall.TopY;

            if (isWall)
            {
                return false;
            }

            bool isFood = foods[foodIndex].LeftX == nextLeftX && foods[foodIndex].TopY == nextTopY;

            if (isFood)
            {
                Eat(nextLeftX, nextTopY);
            }

            Point snakePoint = new Point(nextLeftX, nextTopY);
            snakeElements.Enqueue(snakePoint);
            snakePoint.Draw(SnakeSymbol);
            Point lastPoint = snakeElements.Dequeue();
            lastPoint.Draw(' ');

            return true;
        }

        private void Eat(int nextLeftX, int nextTopY)
        {
            Food food = foods[foodIndex];

            for (int i = 0; i < food.Points; i++)
            {
                snakeElements.Enqueue(new Point(nextLeftX, nextTopY));
            }

            this.foodIndex = GetRandomIndex();
            foods[foodIndex].SetRandomPosition(snakeElements);
        }

        private void CreateSnake()
        {
            snakeElements = new Queue<Point>();

            for (int i = 1; i <= 6; i++)
            {
                Point point = new Point(i, 1);
                snakeElements.Enqueue(point);
                point.Draw(SnakeSymbol);
            }

            this.foodIndex = GetRandomIndex();
            this.foods[this.foodIndex].SetRandomPosition(this.snakeElements);
        }

        private int GetRandomIndex() => new Random().Next(0, foods.Length);
    }
}
