using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCCalcWinForms
{
    public static class UCCalculation
    {

        private static decimal u18SingleRate = 292.11M;
        private static decimal u18CoupleRate= 458.51M;
        private static decimal o18SingleRate=368.74M;
        private static decimal o18CoupleRate=578.82M;
        private static decimal wragRate=146.31M;
        private static decimal supportRate=390.06M;
        private static decimal totalBaseRate = 0M;
        private static decimal taperRate=0.55M;
        private static bool workallowanceEligibility = false;
        private static decimal rentingWorkAllowance = 379M;
        private static decimal homeownerWorkAllowance = 631M;
        private static decimal firstChild = 315M-additionalChildren;//born before 6 april 2017, else additionalChildren rate applies.
        private static DateTime firstchildpremiumcutoff = new DateTime(2017, 4, 6);
        private static decimal additionalChildren = 269.58M; //max 2 children. this app wont deal with exceptions.
        private static decimal disabledChild = 146.31M;//add these later
        private static decimal severeDisabledChild = 456.89M;//add these later
        

        public static decimal CalcUC( decimal netMonthlyIncome, decimal housing, bool WRAG, bool supportGroup, bool isOver18, bool isCouple, List<Children> childrens)
        {
            //calculate baserate
            totalBaseRate = 0;
            totalBaseRate += housing;
            totalBaseRate += (WRAG && !supportGroup) ? wragRate : 0M;
            totalBaseRate += (supportGroup) ? supportRate : 0M;
           
            
           /* totalBaseRate = (isCouple) ? 
                totalBaseRate += (isOver18) ? o18CoupleRate : u18CoupleRate 
                : 
                totalBaseRate += (isOver18) ? o18SingleRate : u18SingleRate;
           */
           if (!isCouple&&!isOver18) { totalBaseRate += u18SingleRate; }
           else if (!isCouple && isOver18) { totalBaseRate += o18SingleRate; }
           else if(isCouple && !isOver18) { totalBaseRate += u18CoupleRate; }
           else totalBaseRate += u18CoupleRate;
            
            
            
            //calculate if eligible for work allowance
            if (WRAG|supportGroup|childrens.Count>0) { workallowanceEligibility = true; }
            
            //calculate work allowance
            bool rentDue = false;
            if (housing>0) { rentDue = true; }
            decimal workAllowance = (rentDue) ? rentingWorkAllowance : homeownerWorkAllowance;
            if (!workallowanceEligibility) { workAllowance = 0; }

            //calculate child elements
            int count = childrens.Count;
            bool firstchildpremiumtrue = false;
            switch (count)
            {
                case 0: totalBaseRate += 0;break;
                case 1: totalBaseRate += additionalChildren; break;
                default: totalBaseRate += 2 * additionalChildren; break;
            }

            foreach (Children Child in childrens)
            {
                if (Child.dateOfBirth < firstchildpremiumcutoff) { firstchildpremiumtrue=true; break; }
               
            }

            if (firstchildpremiumtrue) { totalBaseRate += firstChild; }

            //calculate amount payable after deductions for earnings
            decimal UCPayable = (totalBaseRate - ((netMonthlyIncome-workAllowance) * taperRate));
            UCPayable = (UCPayable < 0) ? 0 : UCPayable;
            
            return UCPayable;
        }

        
    }

   
}
