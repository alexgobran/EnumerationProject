using System;

namespace EnumerationProject {

    enum GradStatus { SummCumlaude, MagnaCumlaude, Cumlaude}

    class Program {

        static void Main(string[] args) {

            GradStatus gs = GradStatus.MagnaCumlaude;
            var i = (int)gs;



             if(gs == GradStatus.MagnaCumlaude)
            {

            }
           
        }
    }
}
