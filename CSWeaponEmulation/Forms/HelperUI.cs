using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Patterns.Forms
{
    internal static class HelperUI
    {
        public static void ToggleEmulation(List<Button> buttons, Button button)
        {
            ButtonsColorReset(buttons);

            //Тернарный оператор
            //Результат = (условие) ? ЗначениеЕслиПравда : ЗначениеЕслиЛожь
            button.BackColor = (button.BackColor == Color.Green) ? Color.White : Color.Green;
        }

        public static void ButtonsColorReset(List<Button> buttons)
        {
            foreach (Button b in buttons) { b.BackColor = Color.White; }
        }
    }
}
