﻿namespace PhoneStore;

public class PhoneNotFoundException : Exception
{
    public PhoneNotFoundException(string message)
        : base(message)
    {
    }
}
