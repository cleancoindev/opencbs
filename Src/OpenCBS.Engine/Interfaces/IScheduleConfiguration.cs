﻿

namespace OpenCBS.Engine.Interfaces
{
    public interface IScheduleConfiguration : IBaseScheduleConfiguration
    {
        IPeriodPolicy PeriodPolicy { get; set; }
        IYearPolicy YearPolicy { get; set; }
        IRoundingPolicy RoundingPolicy { get; set; }
        IInstallmentCalculationPolicy CalculationPolicy { get; set; }
        IAdjustmentPolicy AdjustmentPolicy { get; set; }
        IDateShiftPolicy DateShiftPolicy { get; set; }
    }
}
