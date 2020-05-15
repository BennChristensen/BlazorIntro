using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public partial class Counter
    {
        [Parameter]
        public int IncremenAmount { get; set; } = 1;
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount+=IncremenAmount;
        }
    }
}
