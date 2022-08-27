using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;

namespace GeometryPainting
{
    //Напишите здесь код, который заставит работать методы segment.GetColor и segment.SetColor
    public static Color GetColor (this Segment segment)
    {

    }

    public static void SetColor (this Segment segment, Color  color)
    {

    }
}

/*

Чтобы заработали методы GetColor и SetColor. Открываете SegmentExtensions.cs и там создаете класс, в него записываете методы расширения
public static Color GetColor(this Segment segment) и public static void SetColor(this Segment segment, Color colour).
Цвета удобно хранить в словаре, где сегмент - это ключ, цвет - значение.
Метод GetColor возвращает Color.Black если цвет не задан. Соответственно, по ключу проверяем есть ли у сегмента цвет, если нет то возвращаете Color.Black, если есть - значение цвета сегмента.
Метод SetColor устанавливает цвет, здесь нужно проверить, есть ли такой сегмент в словаре, если нет - добавляете, если есть то перезаписываете его цвет.

 */