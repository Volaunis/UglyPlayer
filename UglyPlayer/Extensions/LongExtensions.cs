using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using UglyPlayer.Models;

namespace UglyPlayer.Extensions
{
    public static class LongExtensions
    {
        public static string ToRemainingDuration(this long duration)
        {
            var totalHours = duration / 3600;
            var remainingMinutes = duration % 3600;
            var totalMinutes = remainingMinutes / 60;
            var remainingSeconds = remainingMinutes % 60;
            return $"-{totalHours:00}:{totalMinutes:00}:{remainingSeconds:00}";
        }

        public static string ToPlayedDuration(this long duration)
        {
            var totalHours = duration / 3600;
            var remainingMinutes = duration % 3600;
            var totalMinutes = remainingMinutes / 60;
            var remainingSeconds = remainingMinutes % 60;
            return $"{totalHours:00}:{totalMinutes:00}:{remainingSeconds:00}";
        }
    }
}
