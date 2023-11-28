public class OkCancelButtonBar : Panel
{
    public Button OkButton;

    private IOkCancelButtonBarListener _listener;
    private string _okLabelString;
    private string _cancelLabelString;

    public OkCancelButtonBar(IOkCancelButtonBarListener listener)
        : this(listener, "OK", "CANCEL") { }

    public OkCancelButtonBar(IOkCancelButtonBarListener listener, string okLabelString, string cancelLabelString)
    {
        _listener = listener;
        _okLabelString = okLabelString;
        _cancelLabelString = cancelLabelString;
        InitUI();
    }

    private void InitUI()
    {

        this.Layout = new FlowLayoutPanel
        {
            FlowDirection = FlowDirection.RightToLeft,
            AutoSize = true
        };

        OkButton = new Button
        {
            Text = _okLabelString,
            AutoSize = true
        };
        OkButton.Click += (sender, e) => _listener.OnOk();
        this.Controls.Add(OkButton);

        var cancelButton = new Button
        {
            Text = _cancelLabelString,
            AutoSize = true
        };
        cancelButton.Click += (sender, e) => _listener.OnCancel();
        this.Controls.Add(cancelButton);
    }

    public interface IOkCancelButtonBarListener
    {
        void OnOk();
        void OnCancel();
    }
}