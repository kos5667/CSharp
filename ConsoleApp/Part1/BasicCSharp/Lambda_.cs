using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    // Lambda : 일회용 함수를 만드는데 사용하는 문법이다.
    internal class Lambda_
    {
        static List<Item> _items = new List<Item>();

        delegate bool ItemSelector(Item item);

        delegate Return MyFunc<Return>();

        delegate Return MyFunc<T, Return>(T item);

        delegate Return MyFunc<T, T2, Return>(T item);

        static bool IsWeapon(Item item)
        {
            return item.ItemType == ItemType.Weapon;
        }

        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if(selector(item))
                    return item;
            }
            return null;
        }

        static Item FindItem2(MyFunc<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        static Item FindWeapon()
        {
            foreach(Item item in _items)
            {
                if(item.ItemType == ItemType.Weapon)
                    return item;
            }
            return null;
        }

        //static void Main(string[] args)
        //{
        //    run();
        //}

        static void run()
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            Item item1 = FindItem(IsWeapon);

            // Anonymous Function : 무명 함수 / 익명 함수
            Item item2 = FindItem(delegate (Item item)
            {
                return item.ItemType == ItemType.Weapon;
            });

            // Lambda 무명 함수 / 익명 함수
            Item item3 = FindItem((Item item) =>
            {
                return item.ItemType == ItemType.Weapon;
            });

            // 다회용.
            ItemSelector selector = new ItemSelector((Item item) =>
            {
                return item.ItemType == ItemType.Weapon;
            });

            Item item4 = FindItem(selector);


            MyFunc<Item, bool> selector2 = (Item item) => { return item.ItemType == ItemType.Weapon; };

            // delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재한다.
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없을 경우 Action
            Func<Item, bool> selector3 = (Item item) => { return item.ItemType == ItemType.Weapon; };

            //Action<Item, bool> selector4 = () => {};
        }
        enum ItemType
        {
            Weapon,
            Armor,
            Amulet,
            Ring
        }
        enum Rarity
        {
            Normal,
            Uncommon,
            Rare
        }

        class Item
        {
            public ItemType ItemType;
            public Rarity Rarity;

        }
    }

   
}
