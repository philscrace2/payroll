namespace PayrollGuiWinformsImpl.viewimpl.component.composite
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class ValidationErrorMessagesLabel : Label
    {
        public ValidationErrorMessagesLabel()
        {
            ForeColor = Color.Red;
        }

        public void SetMessages(List<string> messages)
        {
            Text = ToListAsHtml(messages);
        }

        private string ToListAsHtml(List<string> strings)
        {
            return "<html>" + string.Join("<br/>", strings) + "</html>";
        }
    }

}
