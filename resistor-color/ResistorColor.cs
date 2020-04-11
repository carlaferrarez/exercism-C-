using System;
using System.Collections.Generic;
using System.Linq;

public class ResistorColor
{
    public int number { get; set; }
    public string color { get; set; }

    public static List<ResistorColor> CodeColor()
    {
        var _items = new List<ResistorColor>();

        _items.Add(new ResistorColor { number = 0, color = "black" });
        _items.Add(new ResistorColor { number = 1, color = "brown" });
        _items.Add(new ResistorColor { number = 2, color = "red" });
        _items.Add(new ResistorColor { number = 3, color = "orange" });
        _items.Add(new ResistorColor { number = 4, color = "yellow" });
        _items.Add(new ResistorColor { number = 5, color = "green" });
        _items.Add(new ResistorColor { number = 6, color = "blue" });
        _items.Add(new ResistorColor { number = 7, color = "violet" });
        _items.Add(new ResistorColor { number = 8, color = "grey" });
        _items.Add(new ResistorColor { number = 9, color = "white" });

        return _items.ToList();

    }

    public static int ColorCode(string color)
    {
        return CodeColor().Where(x => x.color == color).Select(x => x.number).FirstOrDefault();
    }

    public static string[] Colors()
    {
        return CodeColor().Select(x => x.color).ToArray();
    }

}