﻿using PayrollGuiWinformsImpl.viewimpl.mainframe;

namespace PayrollGuiWinformsImpl.viewimpl
{
    using global::GuiWinformsModule;
    using System.Windows.Forms;

    public class MainFrameWindow : Form
    {
        private Panel mainPanelHolder;
        private Panel statusBarHolder;

        public MainFrameWindow(MainPanel mainPanel, StatusBarPanel statusBarPanel)
        {
            InitUI();
            mainPanelHolder.Controls.Add(mainPanel);
            statusBarHolder.Controls.Add(statusBarPanel);
        }

        private void InitUI()
        {
            this.FormClosing += (sender, e) => Application.Exit();
            this.Text = GuiConstants.APP_TITLE; // Assuming GuiConstants.AppTitle is a constant for the title
            this.Size = new System.Drawing.Size(850, 500);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            Panel contentPane = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };
            this.Controls.Add(contentPane);

            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top
            };
            contentPane.Controls.Add(topPanel);

            Panel centerPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            contentPane.Controls.Add(centerPanel);

            mainPanelHolder = new Panel
            {
                Dock = DockStyle.Fill
            };
            centerPanel.Controls.Add(mainPanelHolder);

            Panel bottomPanel = new Panel
            {
                Dock = DockStyle.Bottom
            };
            contentPane.Controls.Add(bottomPanel);

            statusBarHolder = new Panel
            {
                Dock = DockStyle.Top
            };
            bottomPanel.Controls.Add(statusBarHolder);
        }

        public void ShowIt()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                this.Visible = true;
            }));
        }
    }

}