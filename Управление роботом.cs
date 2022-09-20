using System;

namespace Управление_роботом
{
    internal class Program
    {
		static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
		{
			bool shouldFire = true;
			if (enemyInFront == true)
			{
				if (enemyName == "boss")
				{
					if (robotHealth < 50) shouldFire = false;
					if (robotHealth > 100) shouldFire = true;
				}
			}
			else
			{
				return false;
			}
			return shouldFire;
		}
		static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
		{
			return (enemyInFront && enemyName == "boss" && robotHealth >= 50) || (enemyInFront && enemyName != "boss");
		}
		static void Main(string[] args)
        {
            
        }
    }
}
