using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class frmMatchingGame : Form
    {
        System.Windows.Forms.Timer tmr = new() { Interval = 950 };
        Random random = new Random();
        Label firstClicked = null;
        Label secondClicked = null;


        public frmMatchingGame()
        {
            InitializeComponent();
            InitialSetup();
            ControlsDisabled();

            foreach (Control c in tblBoard.Controls)
            {
                if (c is Label)
                {
                    c.Click += Label_Click;
                }
            }

            tmr.Tick += Tmr_Tick;
            BtnStart.Click += BtnStart_Click;
        }

        private void Start()
        {
            foreach (Control c in tblBoard.Controls)
            {
                Label iconLabel = (Label)c;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor != iconLabel.BackColor)
                    {
                        iconLabel.ForeColor = iconLabel.BackColor;
                        return;
                    }
                }
            }
            AssignIconsToSquares();
            ControlsEnabled();
        }

        //AS Move procedure up above the event handlers
        private void ClearBoard()
        {
            foreach (Control control in tblBoard.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.Text = string.Empty;
                    iconLabel.BackColor = Color.CornflowerBlue;
                    iconLabel.ForeColor = iconLabel.BackColor;
                }
            }
        }

        private void InitialSetup()
        {
            foreach (Control c in tblBoard.Controls)
            {
                Label iconLabel = (Label)c;
                if (iconLabel != null)
                {
                    iconLabel.BackColor = Color.CornflowerBlue;
                    iconLabel.ForeColor = iconLabel.BackColor;
                    iconLabel.Text = string.Empty;
                }
            }
        }

        private void ControlsDisabled()
        {
            foreach (Control c in tblBoard.Controls)
            {
                c.Enabled = false;
            }
        }

        private void ControlsEnabled()
        {
            foreach (Control c in tblBoard.Controls)
            {
                c.Enabled = true;
            }
        }

        private void CheckForWinner()
        {
            foreach (Control control in tblBoard.Controls)
            {
                Label iconLabel = (Label)control;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("You matched all the pictures!", "Congratulations!");
            ControlsDisabled();
        }

        private void AssignIconsToSquares()
        {
            //AS Why do you have to instantiate the list of icons again?
            List<string> icons = new()
            {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
            };

            foreach (Control control in tblBoard.Controls)
            {
                Label iconLabel = (Label)control;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }

        }

        private void LabelClick(Label clickedLbl)
        {
            //AS Code should be moved out of event handler into a procedure and called from here.
            if (tmr.Enabled == true)
                return;

            if (clickedLbl.ForeColor == Color.Black)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedLbl;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLbl;
            secondClicked.ForeColor = Color.Black;
            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }

            tmr.Start();
        }


        private void Tmr_Tick(object? sender, EventArgs e)
        {
            tmr.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void Label_Click(object? sender, EventArgs e)
        {
            if (sender is Label clickedLbl)
            {
                LabelClick(clickedLbl);
            }
        }


        private void BtnStart_Click(object? sender, EventArgs e)
        {
            //AS Why do you need a try catch?

            ClearBoard();
            Start();

        }
    }
}

