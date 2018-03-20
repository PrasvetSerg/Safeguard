using System;

namespace ServiceTypes
{
    /// <summary>
    /// выполняемое действие над объектом/записью
    /// </summary>
    public enum ActionType
    {
        Refresh = 0,
        Add,
        Edit,
        Remove,
        Archive,
        None,
        ManualCheck,
        ShowWriteOff,
        Copy,
        ShowDeletedRecord
    }
}
