namespace Snake
{
    public partial class Form1 : Form
    {
        private const int CELL_SIZE = 30;
        private int CurrentSize;
        private int Score;
        private bool EscState;
        private Food Food;
        private List<Point> Snake;
        private Direction Direction;
        private bool IsEnd;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            DoubleBuffered = true;
            FormParams.Width = this.Width;
            FormParams.Height = this.Height;
            Snake = new List<Point>(512) { new Point(420, 300), new Point(420, 270) };
            CurrentSize = 2;
            Score = 0;
            EscState = true;
            Food = new Food();
            Direction = Direction.Up;
            IsEnd = false;
            timer1.Start();
        }

        private bool IsEatFood()
        {
            foreach (Point snake in Snake)
            {
                if (snake.X == Food.FoodCoords.X && snake.Y == Food.FoodCoords.Y)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsCollision()
        {
            for (int i = 1; i < CurrentSize; i++)
            {
                if (Snake[0].X == Snake[i].X && Snake[0].Y == Snake[i].Y)
                {
                    return true;
                }
            }
            return false;
        }

        private void MoveSnake()
        {
            Point point = new Point();
            for (int i = CurrentSize - 2; i >= 0; i--)
            {
                point.X = Snake[i].X;
                point.Y = Snake[i].Y;
                Snake[i + 1] = point;
            }
            switch (Direction)
            {
                case Direction.Down:
                    point.X = Snake[1].X;
                    point.Y = Snake[1].Y + CELL_SIZE;
                    break;
                case Direction.Left:
                    point.X = Snake[1].X - CELL_SIZE;
                    point.Y = Snake[1].Y;
                    break;
                case Direction.Right:
                    point.X = Snake[1].X + CELL_SIZE;
                    point.Y = Snake[1].Y;
                    break;
                default:
                    point.X = Snake[1].X;
                    point.Y = Snake[1].Y - CELL_SIZE;
                    break;
            }
            Snake[0] = point;
            if (IsEatFood())
            {
                if (CurrentSize < Snake.Capacity)
                {
                    switch (Direction)
                    {
                        case Direction.Down:
                            Snake.Add(new Point(Snake[CurrentSize - 1].X, Snake[CurrentSize - 1].Y - CELL_SIZE));
                            break;
                        case Direction.Left:
                            Snake.Add(new Point(Snake[CurrentSize - 1].X + CELL_SIZE, Snake[CurrentSize - 1].Y));
                            break;
                        case Direction.Right:
                            Snake.Add(new Point(Snake[CurrentSize - 1].X - CELL_SIZE, Snake[CurrentSize - 1].Y));
                            break;
                        default:
                            Snake.Add(new Point(Snake[CurrentSize - 1].X, Snake[CurrentSize - 1].Y + CELL_SIZE));
                            break;
                    }
                    CurrentSize++;
                }
                Food = new Food();
                Score++;
            }
            if (IsCollision())
            {
                IsEnd = true;
            }
        }

        private void DrawSnake(Graphics g)
        {
            foreach (Point snake in Snake)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(82, 242, 125)), snake.X, snake.Y, CELL_SIZE, CELL_SIZE);
            }
        }

        private void DrawFood(Graphics g)
        {
            g.FillRectangle(Food.BrushColor, Food.FoodCoords.X, Food.FoodCoords.Y, CELL_SIZE, CELL_SIZE);
        }

        private void SetDirection(Direction restrictedDir, Direction newDir)
        {
            Direction = Direction != restrictedDir ? newDir : Direction;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawFood(e.Graphics);
            DrawSnake(e.Graphics);
        }

        private void GameOver()
        {
            timer1.Stop();
            MessageBox.Show($"Конец игры. Размер змейки: {CurrentSize}");
            InitializeGame();
            timer1.Start();
        }

        private void Pause()
        {
            if (EscState)
            {
                timer1.Stop();
                EscState = false;
            }
            else
            {
                timer1.Start();
                EscState = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                SetDirection(Direction.Right, Direction.Left);
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                SetDirection(Direction.Left, Direction.Right);
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                SetDirection(Direction.Up, Direction.Down);
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                SetDirection(Direction.Down, Direction.Up);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Pause();
            }
        }

        // Game Loop
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!IsEnd)
            {
                ScoreNumberLabel.Text = Score.ToString();
                MoveSnake();
                Invalidate();
            }
            else
            {
                GameOver();
            }
        }
    }
}