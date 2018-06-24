using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShips
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> shipsA = new Dictionary<string, int>();
        Dictionary<string, int> shipsB = new Dictionary<string, int>();
        bool readyA = false;
        bool readyB = false;
        bool turn = true;  //true - first player (A), false - second player (B)
        string passwordA;
        string passwordB;
        public Form1()
        {
            InitializeComponent();
            AddLabels();
            AddButtons();
            showA.Visible = false;
            showB.Visible = false;
            gridA.Visible = false;
            gridB.Visible = false;
            turnLabel.Visible = false;
            playerBPassword.Visible = false;
            playerAPassword.Visible = false;
            hideA.Enabled = false;
            hideB.Enabled = false;
            showA.Enabled = false;
            showB.Enabled = false;
        }

        private void Map_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);

            Graphics g = e.Graphics;

            for (int i = 0; i<11; i++)
            {
                g.DrawLine(blackPen, 0, 20 + i * 25, 270, 20 + i * 25);
                g.DrawLine(blackPen, 20 + i * 25, 0, 20 + i * 25, 270);
            }
            var p = sender as Panel;
            if (p.Name == "mapA")
                DrawShip(g, e, 0);
            else
                DrawShip(g, e, 1);

            g.Dispose();
        }

        private void AddLabels()
        {
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            for (int i = 0; i < 10; i++)
            {
                Label markLetterA = new Label();
                markLetterA.Size = new Size(15, 15);
                markLetterA.Location = new Point(25 + i * 25, 0);
                markLetterA.Text = letters[i].ToString();
                mapA.Controls.Add(markLetterA);

                Label markLetterB = new Label();
                markLetterB.Size = new Size(15, 15);
                markLetterB.Location = new Point(25 + i * 25, 0);
                markLetterB.Text = letters[i].ToString();
                mapB.Controls.Add(markLetterB);

                Label markLetterC = new Label();
                markLetterC.Size = new Size(15, 15);
                markLetterC.Location = new Point(25 + i * 25, 0);
                markLetterC.Text = letters[i].ToString();
                gridA.Controls.Add(markLetterC);

                Label markLetterD = new Label();
                markLetterD.Size = new Size(15, 15);
                markLetterD.Location = new Point(25 + i * 25, 0);
                markLetterD.Text = letters[i].ToString();
                gridB.Controls.Add(markLetterD);

                Label markNumberA = new Label();
                markNumberA.Size = new Size(19, 15);
                markNumberA.Location = new Point(0, 25 + i * 25);
                markNumberA.Text = (i + 1).ToString();
                mapA.Controls.Add(markNumberA);

                Label markNumberB = new Label();
                markNumberB.Size = new Size(19, 15);
                markNumberB.Location = new Point(0, 25 + i * 25);
                markNumberB.Text = (i + 1).ToString();
                mapB.Controls.Add(markNumberB);

                Label markNumberC = new Label();
                markNumberC.Size = new Size(19, 15);
                markNumberC.Location = new Point(0, 25 + i * 25);
                markNumberC.Text = (i + 1).ToString();
                gridA.Controls.Add(markNumberC);

                Label markNumberD = new Label();
                markNumberD.Size = new Size(19, 15);
                markNumberD.Location = new Point(0, 25 + i * 25);
                markNumberD.Text = (i + 1).ToString();
                gridB.Controls.Add(markNumberD);

            }
        }

        private void AddButtons()
        {
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            for (int i = 0; i<10; i++)
            {
                for(int x = 0; x<10; x++)
                {
                    Button tileA = new Button();
                    tileA.Size = new Size(25, 25);
                    tileA.Location = new Point(20 + i*25, 20 + x * 25);
                    tileA.Name = "0" + letters[i].ToString() + (x+1).ToString();
                    tileA.Click += new EventHandler(this.TileClicked_Click);
                    gridA.Controls.Add(tileA);

                    Button tileB = new Button();
                    tileB.Size = new Size(25, 25);
                    tileB.Location = new Point(20 + i * 25, 20 + x * 25);
                    tileB.Name = "1" + letters[i].ToString() + (x+1).ToString();
                    tileB.Click += new EventHandler(this.TileClicked_Click);
                    gridB.Controls.Add(tileB);
                }
            }
        }

        private void TileClicked_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            //turnLabel.Text = button.Name;

            if (turn && button.Name[0] == '0')
            {
                if (TryHit(button.Name))
                    button.BackColor = Color.Red;
                else
                {
                    button.BackColor = Color.Yellow;
                    turn = !turn;
                    turnLabel.Text = "Player B Turn";
                }
                button.Enabled = false;
                
            }
            else if (!turn && button.Name[0] == '1')
            {
                if (TryHit(button.Name))
                    button.BackColor = Color.Red;
                else
                {
                    button.BackColor = Color.Yellow;
                    turn = !turn;
                    turnLabel.Text = "Player A Turn";
                }
                button.Enabled = false;
            }
            else
                MessageBox.Show("Its not your turn!");
        }

        private bool TryHit(string coords)
        {
            int player = Int32.Parse(coords[0].ToString());
            char x = coords[1];
            int y = Int32.Parse(coords.Substring(2));

            if(player == 0)
            {
                foreach(var a in shipsB)
                {
                    char X = a.Key[0];
                    int Y = Int32.Parse(a.Key.Substring(1));
                    if (x == X && y == Y)
                    {
                        shipsB[a.Key] = 2;
                        mapB.Invalidate();
                        if (CheckForWin(player))
                            MessageBox.Show("Player A has won!");
                        return true;
                    }
                }
            }
            else
            {
                foreach (var a in shipsA)
                {
                    char X = a.Key[0];
                    int Y = Int32.Parse(a.Key.Substring(1));
                    if (x == X && y == Y)
                    {
                        shipsA[a.Key] = 2;
                        mapA.Invalidate();
                        if (CheckForWin(player))
                            MessageBox.Show("Player B has won!");
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckForWin(int player)
        {
            if(player == 0)
            {
                foreach (var a in shipsB)
                    if (a.Value == 1)
                        return false;
            }
            else
            {
                foreach (var a in shipsA)
                    if (a.Value == 1)
                        return false;
            }
            return true;
        }

        private void DrawShip(Graphics g, PaintEventArgs e, int map)
        {
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            if(map == 0)
            foreach (var a in shipsA)
            {
                char x = a.Key[0];
                int y = Int32.Parse(a.Key.Substring(1))-1;
                for (int i = 0; i < 10; i++)
                {
                    if (letters[i] == x)
                    {
                        Rectangle rect = new Rectangle(20 + i*25, 20 + y*25, 25, 25);
                        if(a.Value == 1)
                            e.Graphics.FillRectangle(greenBrush, rect);
                        if(a.Value == 2)
                            e.Graphics.FillRectangle(redBrush, rect);
                    }
                }
            }
            if(map == 1)
            foreach (var a in shipsB)
            {
                char x = a.Key[0];
                int y = Int32.Parse(a.Key.Substring(1)) - 1;
                for (int i = 0; i < 10; i++)
                {
                    if (letters[i] == x)
                    {
                        Rectangle rect = new Rectangle(20 + i * 25, 20 + y * 25, 25, 25);

                        if (a.Value == 1)
                            e.Graphics.FillRectangle(greenBrush, rect);
                        if (a.Value == 2)
                            e.Graphics.FillRectangle(redBrush, rect);
                    }
                }
            }
            g.Dispose();
        }
        //lf - letterFrom      lt - letterTo       nf - numberFrom       nt - numberTo
        private bool SetShip(int player, int size, char lf, char lt, int nf, int nt)
        {
            if (nf > 10 || nf < 1 || nt > 10 || nt < 1 || lt > 'J' || lt < 'A' || lf > 'J' || lt < 'A')
                return false;
            if ((Math.Abs(lt - lf) == (size - 1) && nf == nt) || (Math.Abs(nt - nf) == (size - 1) && lt == lf))
            {
                Dictionary<string, int> ship = new Dictionary<string, int>();
                if (lt == lf)
                {
                    for (int i = nf; i <= nt; i++)
                    {
                        ship.Add(lt.ToString() + i.ToString(), 1);
                    }
                }
                else
                {
                    for (int i = lf; i <= lt; i++)
                    {
                        ship.Add(((char)i).ToString() + nf.ToString(), 1);
                    }
                }
                bool col = false;
                if (player == 0)
                {
                    foreach (var a in shipsA)
                        foreach (var b in ship)
                        {
                            if (a.Key == b.Key && a.Value == b.Value)
                            {
                                col = true;
                            }
                        }
                    if (!col)
                    {
                        foreach (var a in ship)
                            shipsA.Add(a.Key, a.Value);
                        mapA.Invalidate();
                    }
                    else
                        return false;
                }
                else
                {
                    foreach (var a in shipsB)
                        foreach (var b in ship)
                        {
                            if (a.Key == b.Key && a.Value == b.Value)
                            {
                                col = true;
                            }
                        }
                    if (!col)
                    {
                        foreach (var a in ship)
                            shipsB.Add(a.Key, a.Value);
                        mapB.Invalidate();
                    }
                    else
                        return false;
                }
            }
            else
            {
                //MessageBox.Show("Incorrect size");
                return false;
            }

            return true;
        }

        private void HideA_Click(object sender, EventArgs e)
        {
            mapA.Visible = false;
            showA.Visible = true;
        }

        private void ShowA_Click(object sender, EventArgs e)
        {
            if (playerAPassword.Text == passwordA)
            {
                mapA.Visible = true;
                showA.Visible = false;
                playerAPassword.Text = "";
            }
            else
                MessageBox.Show("Password Incorrect!");
        }

        private void HideB_Click(object sender, EventArgs e)
        {
            mapB.Visible = false;
            showB.Visible = true;
        }

        private void ShowB_Click(object sender, EventArgs e)
        {
            if (playerBPassword.Text == passwordB)
            {
                mapB.Visible = true;
                showB.Visible = false;
                playerBPassword.Text = "";
            }
            else
                MessageBox.Show("Password Incorrect!");
        }

        private void Ship5A_Click(object sender, EventArgs e)
        {
            using (ShipSetter ss = new ShipSetter())
            {
                ss.ShowDialog();
                if (SetShip(0, 5, ss.GetLetterFrom(), ss.GetLetterTo(), ss.GetNumberFrom(), ss.GetNumberTo()))
                {
                    ship5A.Enabled = false;
                    ship5A.Text = "5 Ship (0)";
                }
                else
                    MessageBox.Show("Incorrect Values!");
            }
        }

        private void Ship4A_Click(object sender, EventArgs e)
        {
            using (ShipSetter ss = new ShipSetter())
            {
                ss.ShowDialog();
                if (SetShip(0, 4, ss.GetLetterFrom(), ss.GetLetterTo(), ss.GetNumberFrom(), ss.GetNumberTo()))
                    if (ship4A.Text == "4 Ship (1)")
                    {
                        ship4A.Enabled = false;
                        ship4A.Text = "4 Ship (0)";
                    }
                    else
                        ship4A.Text = "4 Ship (1)";
                else
                    MessageBox.Show("Incorrect Values!");
            }
        }

        private void ship3A_Click(object sender, EventArgs e)
        {
            using (ShipSetter ss = new ShipSetter())
            {
                ss.ShowDialog();
                if (SetShip(0, 3, ss.GetLetterFrom(), ss.GetLetterTo(), ss.GetNumberFrom(), ss.GetNumberTo()))
                    if (ship3A.Text == "3 Ship (1)")
                    {
                        ship3A.Enabled = false;
                        ship3A.Text = "3 Ship (0)";
                    }
                    else if (ship3A.Text == "3 Ship (3)")
                        ship3A.Text = "3 Ship (2)";
                    else
                        ship3A.Text = "3 Ship (1)";

                else
                    MessageBox.Show("Incorrect Values!");
            }
        }

        private void ship2A_Click(object sender, EventArgs e)
        {
            using (ShipSetter ss = new ShipSetter())
            {
                ss.ShowDialog();
                if (SetShip(0, 2, ss.GetLetterFrom(), ss.GetLetterTo(), ss.GetNumberFrom(), ss.GetNumberTo()))
                    if (ship2A.Text == "2 Ship (1)")
                    {
                        ship2A.Enabled = false;
                        ship2A.Text = "2 Ship (0)";
                    }
                    else if (ship2A.Text == "2 Ship (4)")
                        ship2A.Text = "2 Ship (3)";
                    else if (ship2A.Text == "2 Ship (3)")
                        ship2A.Text = "2 Ship (2)";
                    else
                        ship2A.Text = "2 Ship (1)";

                else
                    MessageBox.Show("Incorrect Values!");
            }
        }

        private void ship5B_Click(object sender, EventArgs e)
        {
            using (ShipSetter ss = new ShipSetter())
            {
                ss.ShowDialog();
                if (SetShip(1, 5, ss.GetLetterFrom(), ss.GetLetterTo(), ss.GetNumberFrom(), ss.GetNumberTo()))
                {
                    ship5B.Enabled = false;
                    ship5B.Text = "5 Ship (0)";
                }
                else
                    MessageBox.Show("Incorrect Values!");
            }
        }

        private void ship4B_Click(object sender, EventArgs e)
        {
            using (ShipSetter ss = new ShipSetter())
            {
                ss.ShowDialog();
                if (SetShip(1, 4, ss.GetLetterFrom(), ss.GetLetterTo(), ss.GetNumberFrom(), ss.GetNumberTo()))
                    if (ship4B.Text == "4 Ship (1)")
                    {
                        ship4B.Enabled = false;
                        ship4B.Text = "4 Ship (0)";
                    }
                    else
                        ship4B.Text = "4 Ship (1)";
                else
                    MessageBox.Show("Incorrect Values!");
            }
        }

        private void ship3B_Click(object sender, EventArgs e)
        {
            using (ShipSetter ss = new ShipSetter())
            {
                ss.ShowDialog();
                if (SetShip(1, 3, ss.GetLetterFrom(), ss.GetLetterTo(), ss.GetNumberFrom(), ss.GetNumberTo()))
                    if (ship3B.Text == "3 Ship (1)")
                    {
                        ship3B.Enabled = false;
                        ship3B.Text = "3 Ship (0)";
                    }
                    else if (ship3B.Text == "3 Ship (3)")
                        ship3B.Text = "3 Ship (2)";
                    else
                        ship3B.Text = "3 Ship (1)";

                else
                    MessageBox.Show("Incorrect Values!");
            }
        }

        private void ship2B_Click(object sender, EventArgs e)
        {
            using (ShipSetter ss = new ShipSetter())
            {
                ss.ShowDialog();
                if (SetShip(1, 2, ss.GetLetterFrom(), ss.GetLetterTo(), ss.GetNumberFrom(), ss.GetNumberTo()))
                    if (ship2B.Text == "2 Ship (1)")
                    {
                        ship2B.Enabled = false;
                        ship2B.Text = "2 Ship (0)";
                    }
                    else if (ship2B.Text == "2 Ship (4)")
                        ship2B.Text = "2 Ship (3)";
                    else if (ship2B.Text == "2 Ship (3)")
                        ship2B.Text = "2 Ship (2)";
                    else
                        ship2B.Text = "2 Ship (1)";

                else
                    MessageBox.Show("Incorrect Values!");
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string temp = "";
            foreach (var a in shipsA)
            {
                temp += a.Key + " ";
            }
            MessageBox.Show(temp);

            string tempB = "";
            foreach (var a in shipsB)
            {
                tempB += a.Key + " ";
            }
            MessageBox.Show(tempB);
        }

        private void readyAButton_Click(object sender, EventArgs e)
        {
            if (ship5A.Enabled == false && ship4A.Enabled == false && ship3A.Enabled == false && ship2A.Enabled == false)
                if (readyB)
                {
                    StartGame();
                    disableA();
                    mapA.Visible = false;
                    showA.Visible = true;
                }
                else
                {
                    readyA = true;
                    readyAButton.Enabled = false;
                    disableA();
                    mapA.Visible = false;
                    showA.Visible = true;
                }
            else if (shipsA.Count == 0)
                MessageBox.Show("You can't start game with 0 ships!");
            else if (MessageBox.Show("Are you sure you want to start without all ships?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (readyB)
                {
                    StartGame();
                    disableA();
                    mapA.Visible = false;
                    showA.Visible = true;
                }
                else
                {
                    readyA = true;
                    readyAButton.Enabled = false;
                    disableA();
                    mapA.Visible = false;
                    showA.Visible = true;
                }
            }
        }

        private void readyBButton_Click(object sender, EventArgs e)
        {
            if (ship5B.Enabled == false && ship4B.Enabled == false && ship3B.Enabled == false && ship2B.Enabled == false)
                if (readyA)
                {
                    StartGame();
                    disableB();
                    mapB.Visible = false;
                    showB.Visible = true;
                }
                else
                {
                    readyB = true;
                    readyBButton.Enabled = false;
                    disableB();
                    mapB.Visible = false;
                    showB.Visible = true;
                }
            else if(shipsB.Count == 0)
                MessageBox.Show("You can't start game with 0 ships!");
            else if (MessageBox.Show("Are you sure you want to start without all ships?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (readyA)
                {
                    StartGame();
                    disableB();
                    mapB.Visible = false;
                    showB.Visible = true;
                }
                else
                {
                    readyB = true;
                    readyBButton.Enabled = false;
                    disableB();
                    mapB.Visible = false;
                    showB.Visible = true;
                }
            }
        }
        private void disableA()
        {
            ship2A.Visible = false;
            ship3A.Visible = false;
            ship4A.Visible = false;
            ship5A.Visible = false;
            passwordA = playerAPasswordSet.Text;
            playerAPasswordSet.Visible = false;
            passLabelA.Visible = false;

        }
        private void disableB()
        {
            ship2B.Visible = false;
            ship3B.Visible = false;
            ship4B.Visible = false;
            ship5B.Visible = false;
            passwordB = playerBPasswordSet.Text;
            playerBPasswordSet.Visible = false;
            passLabelB.Visible = false;

        }
        private void StartGame()
        {
            readyAButton.Visible = false;
            readyBButton.Visible = false;
            gridA.Visible = true;
            gridB.Visible = true;
            turnLabel.Visible = true;
             playerBPassword.Visible = true;
            playerAPassword.Visible = true;
            hideA.Enabled = true;
            hideB.Enabled = true;
            showA.Enabled = true;
            showB.Enabled = true;
        }

        private void restartGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newGame = new Form1();
            newGame.Location = this.Location;
            newGame.ShowDialog();
            this.Close();
        }
    }
}
