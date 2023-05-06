using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public interface IFighter
    {
         void canAttack();
         void canFire(); 
         void canShot();
       
    }
    public interface IKiller
    {
         void canKill();

    }
    public interface IManage
    {
        void control();
        void completeMission();
        void gatherPeople();
    }
}
