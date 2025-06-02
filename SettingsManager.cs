using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodist
{
    public static class SettingsManager
    {
        public static int PomodoroTime { get; set; } = 60;
        public static int LongBreakTime { get; set; } = 10;
        public static int ShortBreakTime { get; set; } = 5;

    }
}
