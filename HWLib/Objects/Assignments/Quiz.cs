﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class Quiz : Assignment
    {
        public Quiz(String IDentify, String nameIt, DueDate duePeriod, int pointsNeeded, bool Balloony)
        {
            this.setID(IDentify);
            this.setName(nameIt);
            this.setDueDate(duePeriod);
            this.setMaxPoints(pointsNeeded);
            this.setShowBalloons(Balloony);
        }
        #region Extension
        private String extension = ".quiz";
        public override string getExtension()
        {
            return extension;
        }
        #endregion

        public override int ResponseInt()
        {
            return 3;
        }
    }
}
