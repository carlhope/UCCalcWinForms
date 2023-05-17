using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCCalcWinForms
{
    public static class Class1
    {

        private static decimal u18SingleRate = 292.11M;
        private static decimal u18CoupleRate= 458.51M;
        private static decimal o18SingleRate=368.74M;
        private static decimal o18CoupleRate=578.82M;
        private static decimal wragRate=146.31M;
        private static decimal supportRate=390.06M;
        private static decimal totalBaseRate = 0M;
        private static decimal taperRate=0.55M;
        private static decimal rentingWorkAllowance = 379M;
        private static decimal homeownerWorkAllowance = 631M;
        

        public static decimal CalcUC( decimal netMonthlyIncome, decimal housing, bool WRAG, bool supportGroup, bool isOver18, bool isCouple)
        {
            //calculate baserate
            totalBaseRate = 0;
            totalBaseRate += housing;
            totalBaseRate += (WRAG && !supportGroup) ? wragRate : 0M;
            totalBaseRate += (supportGroup) ? supportRate : 0M;
            totalBaseRate = (isCouple) ? 
                totalBaseRate += (isOver18) ? o18CoupleRate : u18CoupleRate 
                : 
                totalBaseRate += (isOver18) ? o18SingleRate : u18SingleRate;

            //calculate work allowance
            bool rentDue = false;
            if (housing>0) { rentDue = true; }
            decimal workAllowance = (rentDue) ? rentingWorkAllowance : homeownerWorkAllowance;

            //calculate amount payable after deductions for earnings
            decimal UCPayable = (totalBaseRate - (netMonthlyIncome * taperRate));
            UCPayable = (UCPayable < 0) ? 0 : UCPayable;
            
            return UCPayable;
        }

        
    }

   
}
