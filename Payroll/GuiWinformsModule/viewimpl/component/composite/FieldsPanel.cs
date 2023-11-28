public class FieldsPanel : Panel
{
    private TableLayoutPanel _tableLayoutPanel;
    private int _fieldCount = 0;

    public FieldsPanel()
    {
        _tableLayoutPanel = new TableLayoutPanel
        {
            AutoSize = true,
            ColumnCount = 2
        };
        _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.Controls.Add(_tableLayoutPanel);
        this.Padding = new Padding(5);
    }

    public void AddField(string labelText, Control component)
    {
        var label = new Label
        {
            Text = labelText,
            TextAlign = ContentAlignment.MiddleRight,
            AutoSize = true
        };
        _tableLayoutPanel.Controls.Add(label);
        _tableLayoutPanel.Controls.Add(component);
        _tableLayoutPanel.RowCount = ++_fieldCount;
        _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
    }
}
