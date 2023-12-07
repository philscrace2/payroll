using Timer = System.Windows.Forms.Timer;

public class StatusBarTextPane : RichTextBox
{
    private static readonly Color DefaultFontColor = Color.White;
    private static readonly Color DefaultBgColor = Color.White;
    private const int TimerPeriodMs = 1000;

    private enum Status { Stopped, Leading, ShowBig, ShowSmall }

    private const int DelayLeading = 100;
    private const int DelayShowBig = 10000;
    private const int DelayShowSmall = 10000;

    private Timer _timer;
    private Status _timerStatus = Status.Stopped;
    private Message _waitForLeadingMessage;

    public StatusBarTextPane()
    {
        //Init();
    }

    private void Init()
    {
        //this.Dock = DockStyle.Fill;
        ReadOnly = true;
        InitDefaultStyles();
        InitTimer();
        ClearText();
    }

    private void InitDefaultStyles()
    {
        // Set font color
        SelectionStart = 0;
        SelectionLength = TextLength;
        SelectionColor = DefaultFontColor;
        SelectionAlignment = HorizontalAlignment.Center;

        // Reset selection
        SelectionStart = TextLength;
        SelectionLength = 0;
    }

    private void InitTimer()
    {
        _timer = new Timer
        {
            Interval = TimerPeriodMs
        };
        _timer.Tick += (sender, args) => TimerRing();
    }

    private void SetStatus(Status newStatus)
    {
        _timer.Stop();
        switch (newStatus)
        {
            case Status.Leading:
                _timer.Interval = DelayLeading;
                break;
            case Status.ShowBig:
                _timer.Interval = DelayShowBig;
                break;
            case Status.ShowSmall:
                _timer.Interval = DelayShowSmall;
                break;
        }

        if (newStatus != Status.Stopped)
        {
            _timer.Start();
        }

        _timerStatus = newStatus;
    }

    private void TimerRing()
    {
        switch (_timerStatus)
        {
            case Status.Leading:
                SetStatus(Status.ShowBig);
                SetBgColor(_waitForLeadingMessage.Col);
                SetNewText(_waitForLeadingMessage.Msg);
                _waitForLeadingMessage = null;
                break;
            case Status.ShowBig:
            case Status.ShowSmall:
                SetStatus(Status.Stopped);
                ClearText();
                break;
        }
    }

    private void SetBgColor(Color col)
    {
        BackColor = col;
    }

    public void SetMessage(string message, Color backgroundColor)
    {
        if (_timerStatus == Status.ShowBig || _timerStatus == Status.ShowSmall)
        {
            _waitForLeadingMessage = new Message(message, backgroundColor);
            SetStatus(Status.Leading);
        }
        else if (_timerStatus == Status.Leading)
        {
            _waitForLeadingMessage = new Message(message, backgroundColor);
        }
        else if (_timerStatus == Status.Stopped)
        {
            SetStatus(Status.ShowBig);
            SetBgColor(backgroundColor);
            SetNewText(message);
        }
    }

    private void SetNewText(string text)
    {
        Text = text;
    }

    private void ClearText()
    {
        Text = "";
        SetBgColor(DefaultBgColor);
    }

    private class Message
    {
        public string Msg;
        public Color Col;

        public Message(string msg, Color col)
        {
            Msg = msg;
            Col = col;
        }
    }
}
