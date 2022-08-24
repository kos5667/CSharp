﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TextRPG2
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    internal class Player
    {
        protected PlayerType type = PlayerType.None;
        protected int hp = 0;
        protected int attack = 0;

        protected Player(PlayerType type)
        {
            this.type = type;
        }

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public int GetHp() { return hp;}
        public int GetAttack() { return attack; }
        public bool IsDead() { return hp <= 0; }
        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }
    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(70, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 22);
        }
    }
}
