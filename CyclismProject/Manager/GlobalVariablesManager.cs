using CyclismProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclismProject.Manager
{
    internal class GlobalVariablesManager
    {
        public static GlobalVariables Read(GlobalVariables score)
        {
            return score;
        }
        
        public static GlobalVariables Update(GlobalVariables scoreBefore, GlobalVariables scoreAfter)
        {
            return scoreAfter;
        }
        
        public static GlobalVariables Delete(GlobalVariables score)
        {
            return score;
        }
        
        public static GlobalVariables Modify(GlobalVariables scoreBefore, GlobalVariables scoreAfter)
        {
            return scoreAfter;
        }
    }
}
