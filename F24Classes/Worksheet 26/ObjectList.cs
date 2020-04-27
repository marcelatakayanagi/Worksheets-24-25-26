using System;
using System.Collections.Generic;
using System.Text;
using WorkSheets.Pets;
using WorkSheets.Worksheet_26.Interfaces;

namespace WorkSheets.Worksheet_26
{
    public class ObjectList : ITrashable
    {
        private bool _isTrashable;


        public List<object> Lists(List<object> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is ITrashable)
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }

        public void Trashable()
        {
            _isTrashable = true;

        }

    }
}
