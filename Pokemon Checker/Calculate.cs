using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Checker
{
    class Calculate
    {
        public double calculateChance(int encounters, int encounterChance)
        {
            double Base;
            double totalChance;

            Base = (encounterChance - 1.0) / encounterChance;
            totalChance = (100 - Math.Round((Math.Pow(Base, encounters)) * 100, 2));

            return totalChance;
            //var d = new frmPokemonChecker();
            //d.display(totalChance);

        }
    }
}