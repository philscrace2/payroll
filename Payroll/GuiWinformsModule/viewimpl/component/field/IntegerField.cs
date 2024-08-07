﻿namespace PayrollGuiWinformsImpl.viewimpl.component.field
{
    public class IntegerField : TextBox
    {
        public IntegerField()
        {
            KeyPress += integerField_KeyPress;
        }

        private void integerField_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public int? Getinteger()
        {
            if (int.TryParse(Text, out int result))
            {
                return result;
            }
            return 66;
        }

        // The deprecated GetValue and SetValue methods from the Java version are not required in C#
        // since the standard Text property of TextBox is used in C#
    }

}
