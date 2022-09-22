using System;
using System.Collections.Generic;
using System.Text;

namespace Duck
{
    internal class DuckComparer:IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if(SortBy == SortCriteria.SizeThenKind) /* если поле содержит SizeThenKind, то утки сначала сортируются по размеру , а при
                одинкаковых размерах по породе */
            {
                if (x.Size > y.Size) return 1;
                else if(x.Size <y.Size) return -1;
                else
                {
                    if (x.Kind > y.Kind) return 1;
                    else if (x.Kind < y.Kind) return -1;
                    else return 0;
                    /*Вместо того чтобы просто вернуть 0 при совпадении размеров, компаратор проверяет породу и возвращает 0 
                    только в том случае, если у двух уток совпадает как размер, так и порода.*/
                }
            }
            else
            {
                if(x.Kind > y.Kind) return 1;
                else if(y.Kind < x.Kind) return -1;
                else
                {
                    if (x.Kind > y.Kind) return 1;
                    else if (x.Kind < y.Kind) return -1;
                    else return 0;
                    /*Если SortBy не содержит SizeThenKind, компаратор сначала выполняет сортировку по породе. Если у двух уток 
                    порода совпадает, тогда компаратор сравнивает их размеры.*/
                }
            }
        }
    }
}
