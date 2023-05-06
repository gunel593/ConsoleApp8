

using ConsoleApp8;
using System.Windows.Input;

Fighter fighter = new Fighter();    


List<IFighter> fighters = new List<IFighter>();
List<IKiller> killers = new List<IKiller>();    
fighters.Add(fighter);
killers.Add(fighter);

Commander commander = new Commander();

List<IManage>manages = new List<IManage>();
manages.Add(commander);
fighters.Add(commander);
killers.Add(commander);
