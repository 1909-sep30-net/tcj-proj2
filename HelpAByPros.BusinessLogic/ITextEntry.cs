﻿namespace HelpAByPros.BusinessLogic
{
    public interface ITextEntry
    {
        string Text { get; set; }
        IUser Author{ get; set; }
    }
}
