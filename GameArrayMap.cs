using System;

namespace MMayinTarlasi
{
    class GameArrayMap
    {
        private static readonly sbyte[] x = { 1, -1,  1, -1, 1, -1,  0, 0};
        private static readonly sbyte[] y = { 1, -1, -1,  1, 0,  0, -1, 1};
        Random rand = new Random();

        private readonly byte mapWidth;
        private readonly byte mapHeight;
        private readonly byte mapMine;
        public  byte[,] map;


        public GameArrayMap(byte width, byte height, byte mine)
        {
            this.mapWidth   = width;
            this.mapHeight  = height;
            this.mapMine    = mine;

            SetMapArr();
            AddMines(this.mapMine);
        }

        public void SetMapArr()
        {
            this.map = new byte[this.mapWidth, this.mapHeight];
        }
        
        public void AddMines(byte mineNum) // Matrisin içine rastgele indislere 9 değeri yazılıyor, 9 => mayınlı indisi temsil ediyor.
        {
            byte randWidth;
            byte randHeight;

            while (mineNum != 0)
            {
                randWidth   = (byte)rand.Next(this.mapWidth);
                randHeight  = (byte)rand.Next(this.mapHeight);
                if (this.map[randWidth, randHeight] != 9)
                {
                    this.map[randWidth, randHeight] = 9;
                    MineCounter(randWidth, randHeight);
                    mineNum--;
                }
            }
        }
        
        //
        // X = WIDTH = COLUMN   ||  Y = HEIGHT = ROW
        // 

        private void MineCounter(byte cordX, byte cordY)
        {
            for (byte k = 0; k < 8; k++)
            {
                if 
                (   
                       cordX + x[k] >= 0
                    && cordY + y[k] >= 0
                    && cordX + x[k] < this.mapWidth
                    && cordY + y[k] < this.mapHeight
                    && this.map[(cordX + x[k]), (cordY + y[k])] != 9
                )
                { this.map[cordX + x[k], cordY + y[k]]++; }

            }
        }
    
    }
}
