using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalErgasia2.Classes
{
    class FinalMessage
    {
        public FinalMessage()
        {
        }

        public string dialogResult(int grade, string finishedBeforeCountdown, int wrongAnswers, int playingDuration)
        {
            return ("Statistics:" + Environment.NewLine
                                    + "★ Grade: " + grade + "/100" + Environment.NewLine + Environment.NewLine
                                    + "● Finished Before Countdown: " + finishedBeforeCountdown + Environment.NewLine
                                    + "● Wrong Answers: " + wrongAnswers + Environment.NewLine
                                    + "● Time Spent: " + string.Format("{0:00}:{1:00}", (playingDuration / 60) % 60, playingDuration % 60)) + Environment.NewLine;
        }
    }
}
