﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Part2.Algorithm {

    class Pos {
        public Pos(int y, int x) { Y = y; X = x; }
        public int Y;
        public int X;
    }

    class Player {

        public int PosY { get; private set; }
        public int PosX { get; private set; }
        Random _random = new Random();
        Mazes _board;

        enum Dir {
            Up = 0,
            Left = 1,
            Down = 2,
            Right = 3
        }

        int _dir = (int)Dir.Up;

        List<Pos> _points = new List<Pos> ();

        public void Initalize(int posY, int posX, Mazes board) {
            PosY = posY;
            PosX = posX;
            _board = board;

            // 현재 바라보고 있는 방향을 기준으로, 좌표 변화를 나타낸다.
            int[] frontY = new int[] { -1, 0, 1, 0};
            int[] frontX = new int[] { 0, -1, 0, 1};
            int[] rightY = new int[] { 0, -1, 0, 1 };
            int[] rightX = new int[] { 1, 0, -1, 0 };

            _points.Add(new Pos(PosY, PosX));
            while (PosY != board.DestY || PosX != board.DestX) {
                // 1. 현재 바라보는 방향을 기준으로 오른쪽으로 갈 수 있는지 확인.
                if (_board.Tile[PosY + rightY[_dir], PosX + rightX[_dir]] == Mazes.TileType.Empty) {
                    // 오른쪽 방향으로 90도 회원
                    // 0 1 2 3 보장
                    _dir = (_dir - 1 + 4) % 4;

                    // 앞으로 한 보 전진
                    PosY = PosY + frontY[_dir];
                    PosX = PosX + frontX[_dir];
                    _points.Add(new Pos(PosY, PosX));
                }
                // 2. 현재 바라보는 방향을 기준으로 전진할 수 있는지 확인
                else if (_board.Tile[PosY + frontY[_dir], PosX + frontX[_dir]] == Mazes.TileType.Empty) {
                    // 앞으로 한 보 전진
                    PosY = PosY + frontY[_dir];
                    PosX = PosX + frontX[_dir];
                    _points.Add(new Pos(PosY, PosX));
                } else {
                    // 왼쪽 방향으로 90도 회전
                    _dir = (_dir + 1 + 4) % 4;
                }
            }
        }

        const int MOVE_TICK = 10;
        int _sumTick = 0;
        int _lastIndex = 0;
        public void Update(int deltaTick) {
            if (_lastIndex >= _points.Count)
                return;

            _sumTick += deltaTick;
            if (_sumTick >= MOVE_TICK) {
                _sumTick = 0;

                PosY = _points[_lastIndex].Y;
                PosX = _points[_lastIndex].X;
                _lastIndex++;

                // 여기에다가 0.1초마다 실행될 로직을 넣어준다.
                //int randValue = _random.Next(0, 5);
                //switch (randValue) {
                //    case 0: // 상
                //        if (PosY - 1 >= 0 && _board.Tile[PosY - 1, PosX] == Mazes.TileType.Empty)
                //            PosY = PosY - 1;
                //        break;
                //    case 1: // 하
                //        if (PosY + 1 < _board.Size && _board.Tile[PosY + 1, PosX] == Mazes.TileType.Empty)
                //            PosY = PosY + 1;
                //        break;
                //    case 2: // 좌
                //        if (PosX - 1 > 0 && _board.Tile[PosY, PosX - 1] == Mazes.TileType.Empty)
                //            PosX = PosX - 1;
                //        break;
                //    case 3: // 우
                //        if (PosX + 1 < _board.Size && _board.Tile[PosY, PosX + 1] == Mazes.TileType.Empty)
                //            PosX = PosX + 1;
                //        break;
                //}
            }
        }
    }
}