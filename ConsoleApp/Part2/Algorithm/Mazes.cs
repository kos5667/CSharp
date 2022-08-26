﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Part2.Algorithm {

    // Map 만들기
    // Binary Tree 미로 생성 알고리즘
    internal class Mazes {

        const char CIRCLE = '\u25cf';
        public TileType[,] Tile { get; private set; }
        public int Size { get; private set; }

        public int DestY {get; private set; }
        public int DestX { get; private set; }

        Player _player;

        public enum TileType {
            Empty,
            Wall,
        }

        public void Initalize(int size, Player player) {

            if (size % 2 == 0)
                return;

            _player = player;

            Tile = new TileType[size, size];
            Size = size;

            DestY = Size - 2;
            DestX = Size - 2;

            // Mazes for Programmers
            //GenerateByBinaryTree();
            GenerateBySideWinder();
        }

        void GenerateBySideWinder() {
            // 일단 길을 다 막아버리는 작업
            for (int y = 0; y < Size; y++) {
                for (int x = 0; x < Size; x++) {
                    //if (x == 0 || x == Size - 1 || y == 0 || y == size - 1)
                    if (x % 2 == 0 || y % 2 == 0)
                        Tile[y, x] = TileType.Wall;
                    else
                        Tile[y, x] = TileType.Empty;
                }
            }

            // 랜덤으로 우측 혹은 아래로 길을 뚫는 작업
            // Binary Tree Algorithm
            Random rand = new Random();
            for (int y = 0; y < Size; y++) {
                int count = 1;
                for (int x = 0; x < Size; x++) {
                    //if (x == 0 || x == Size - 1 || y == 0 || y == size - 1)
                    if (x % 2 == 0 || y % 2 == 0)
                        continue;

                    if (y == Size - 2 && x == Size - 2)
                        continue;

                    if (y == Size - 2) {
                        Tile[y, x + 1] = TileType.Empty;
                        continue;
                    }

                    if (x == Size - 2) {
                        Tile[y + 1, x] = TileType.Empty;
                        continue;
                    }

                    if (rand.Next(0, 2) == 0) {
                        Tile[y, x + 1] = TileType.Empty;
                        count++;
                    } else {
                        int randomindex = rand.Next(0, count);
                        Tile[y + 1, x - randomindex * 2] = TileType.Empty;
                        count = 1;
                    }
                }
            }
        }

        void GenerateByBinaryTree() {
            // 일단 길을 다 막아버리는 작업
            for (int y = 0; y < Size; y++) {
                for (int x = 0; x < Size; x++) {
                    //if (x == 0 || x == Size - 1 || y == 0 || y == size - 1)
                    if (x % 2 == 0 || y % 2 == 0)
                        Tile[y, x] = TileType.Wall;
                    else
                        Tile[y, x] = TileType.Empty;
                }
            }

            // 랜덤으로 우측 혹은 아래로 길을 뚫는 작업
            // Binary Tree Algorithm
            Random rand = new Random();
            for (int y = 0; y < Size; y++) {
                for (int x = 0; x < Size; x++) {
                    //if (x == 0 || x == Size - 1 || y == 0 || y == size - 1)
                    if (x % 2 == 0 || y % 2 == 0)
                        continue;

                    if (y == Size - 2 && x == Size - 2)
                        continue;

                    if (y == Size - 2) {
                        Tile[y, x + 1] = TileType.Empty;
                        continue;
                    }

                    if (x == Size - 2) {
                        Tile[y + 1, x] = TileType.Empty;
                        continue;
                    }

                    if (rand.Next(0, 2) == 0) {
                        Tile[y, x + 1] = TileType.Empty;
                    } else {
                        Tile[y + 1, x] = TileType.Empty;
                    }

                }
            }
        }

        public void Render() {
            ConsoleColor prevColor = Console.ForegroundColor;

            for (int y = 0; y < Size; y++) {
                for (int x = 0; x < Size; x++) {
                    // 플레이어 좌표를 고 와서, 그 좌표랑 현재 y,x가 일치하면 플레이어 전용 색상으로 표시
                    if (y == _player.PosY && x == _player.PosX)
                        Console.ForegroundColor = ConsoleColor.Blue;
                    else if (y == DestY && x == DestX)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = GetTileColor(Tile[y, x]);
                    
                    Console.Write(CIRCLE);
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = prevColor;
        }

        ConsoleColor GetTileColor(TileType type) {
            switch (type) {
                case TileType.Empty:
                    return ConsoleColor.Green;
                case TileType.Wall:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Green;
            }
        }

        //static void Main(string[] args) {
        //    Mazes board = new Mazes();
        //    Player player = new Player();
        //    board.Initalize(25, player);
        //    player.Initalize(1, 1, board);

        //    Console.CursorVisible = false;

        //    const int WAIT_TICK = 1000 / 30;

        //    int lastTick = 0;
        //    while (true) {
        //        #region 프레임 관리
        //        // FPS 프레임 (60프레임 OK 30프레임 이하로 NO)
        //        // 만약에 경과한 시간이 1/30초보다 작다면
        //        int currentTick = System.Environment.TickCount;
        //        if (currentTick - lastTick < WAIT_TICK)
        //            continue;
        //        int deltaTick = currentTick - lastTick;
        //        lastTick = currentTick;
        //        #endregion
        //        // 입력

        //        // 로직
        //        player.Update(deltaTick);

        //        // 렌더링
        //        Console.SetCursorPosition(0, 0);
        //        board.Render();
        //    }
        //}
    }
}
