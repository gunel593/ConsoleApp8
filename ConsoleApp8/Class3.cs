using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Fighter : IFighter, IKiller
    {
        public void canAttack()
        {
            Console.WriteLine("Fighter can attack");
        }

        public void canFire()
        {
            Console.WriteLine("Fighter can attack");
        }

        public void canKill()
        {
            Console.WriteLine("Killer can attack");
        }

        public void canShot()
        {
            Console.WriteLine("Fighter can attack");
        }
    }
    public class Commander : IFighter, IKiller, IManage
    {
        void IFighter.canAttack()
        {
            Console.WriteLine("Fighter can attack");
        }

        void IFighter.canFire()
        {
            Console.WriteLine("Fighter can attack");
        }

        void IKiller.canKill()
        {
            Console.WriteLine("Fighter can attack");
        }

        void IFighter.canShot()
        {
            Console.WriteLine("Fighter can attack");
        }

        void IManage.completeMission()
        {
            Console.WriteLine("Manage can attack");
        }

        void IManage.control()
        {
            Console.WriteLine("Manage can attack");
        }

        void IManage.gatherPeople()
        {
            Console.WriteLine("Manage can attack");
        }
    }
}
