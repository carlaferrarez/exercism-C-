using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // using ^ (xor operator) if true & false : true
        //                        if true & true || false & false : false
        if (year % 4 == 0 && (year % 400 != 0 ^ year % 100 == 0))
            return true;
        return false;
    }
}