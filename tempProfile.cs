using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystemApp {
    internal class tempProfile(int mathScore, int memoryScore, int wordScore) {
        public static Dictionary<string, tempProfile> profiles; // name,scores

        public int mathScore = mathScore;
        public int memoryScore = memoryScore;
        public int wordScore = wordScore;
    }
}
