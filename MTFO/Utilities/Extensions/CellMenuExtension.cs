using CellMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MTFO.Utilities.Extensions;
internal static class CellMenuExtension
{
    public static void SetPressEvent(this CM_Item item, Action onPress)
    {
        if (onPress == null)
        {
            item.OnBtnPressCallback = null;
            return;
        }

        item.OnBtnPressCallback = (Action<int>)((i) =>
        {
            onPress?.Invoke();
        });
    }

    public static void SetOpenURLOnPress(this CM_Item item, string url)
    {
        item.SetPressEvent(() => { Application.OpenURL(url); });
    }
}
