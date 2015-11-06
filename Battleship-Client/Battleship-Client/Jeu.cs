using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Battleship_Client
{
    public partial class Jeu : Form
    {
        const int ROWS_COUNT = 10;
        const int COLUMNS_COUNT = 10;

        bool Place = false;

        int rowIndex;
        int colIndex;
        byte[] bytes = new byte[10];
        TcpClient sck = new TcpClient();
        public Jeu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearSea();
            CB_Ligne.SelectedIndex = 0;
            CB_Colonne.SelectedIndex = 0;
        }

        //Vider le board (le mettre blanc)
        private void ClearSea()
        {
            for (int i = 0; i < ROWS_COUNT; i++)
            {
                DGV_Joueurs.Rows.Add("", "", "", "", "", "", "", "", "", "");
            }

            for (int i = 0; i < ROWS_COUNT; i++)
            {
                DGV_Adversaire.Rows.Add("", "", "", "", "", "", "", "", "", "");
            }
        }

        //Bouton NouvellePartie
        private void BTN_NouvellePartie_Click(object sender, EventArgs e)
        {
            PlacerBateaux form = new PlacerBateaux();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FillDGV(form.dgv);
                Place = true;
            }
        }

        //Remplir le datagridview avec le array de "NouvellePartie"
        private void FillDGV(string[,] p)
        {
            for (int i = 0; i < ROWS_COUNT; i++)
            {
                for (int j = 0; j < COLUMNS_COUNT; j++)
                {
                    DGV_Joueurs.Rows[i].Cells[j].Value = p[i, j];
                }
            }
        }

        //Bouton Quitter
        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sur?", "Quitter", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Bouton Envoyer
        private void BTN_Envoyer_Click(object sender, EventArgs e)
        {
            if (sck.Connected)
            {
                NetworkStream stream = sck.GetStream();
                string text = CB_Ligne.SelectedItem.ToString() + CB_Colonne.SelectedItem.ToString();
                byte[] data = Encoding.ASCII.GetBytes(text);
                stream.Write(data, 0, data.Length);
                if (stream.CanRead && sck.Connected)
                {
                    int readBytes = stream.Read(bytes, 0, bytes.Length);
                    string result = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    TB_Results.Text += result + Environment.NewLine;
                }
            }
        }

        private void ConnecterServeur()
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            try
            {

                if (Place)
                {
                    if (!sck.Connected)
                    {
                        sck.Connect(localEndPoint);
                        TB_Results.Text += "Client connected!" + Environment.NewLine;
                    }

                    NetworkStream stream = sck.GetStream();
                    string Ships = GetShips();
                    byte[] data = Encoding.ASCII.GetBytes(Ships);
                    stream.Write(data, 0, data.Length);

                    //Thread t = new Thread(new ThreadStart(WaitforResponse));
                    //t.IsBackground = true;
                    //t.Start();
                }
                else
                {
                    MessageBox.Show("Vous devez commencer une nouvelle partie avant de se connecter au serveur!");
                }
            }
            catch
            {
                TB_Results.Text = "Unable to connect to remote end point!" + Environment.NewLine;
            }
        }

        private void WaitforResponse()
        {
            NetworkStream stream = sck.GetStream();
            string text = GetRowCode(rowIndex) + (colIndex).ToString();
            byte[] data = Encoding.ASCII.GetBytes(text);
            stream.Write(data, 0, data.Length);
            int readBytes = stream.Read(bytes, 0, bytes.Length);
            string result = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

            int Row = GetRowNum(result[0]);
            int Column = result[1];


        }

        private string GetShips()
        {
            string CT = "CT";
            string PA = "PA";
            string CR = "CR";
            string TO = "TO";
            string SM = "SM";

            // Parcourir le DGV
            for (int i = 0; i < ROWS_COUNT; i++)
            {
                for (int j = 0; j < COLUMNS_COUNT; j++)
                {
                    // Regarder si la case appartient à un bateau
                    if(DGV_Joueurs.Rows[i].Cells[j].Value != "")
                    {
                        // Regarder c'est quel Bateau
                        if (DGV_Joueurs.Rows[i].Cells[j].Value == "CT")
                            CT += GetRowCode(i) + j.ToString();
                        else if(DGV_Joueurs.Rows[i].Cells[j].Value == "P")
                            PA += GetRowCode(i) + j.ToString();
                        else if(DGV_Joueurs.Rows[i].Cells[j].Value == "C")
                            CR += GetRowCode(i) + j.ToString();
                        else if(DGV_Joueurs.Rows[i].Cells[j].Value == "T")
                            TO += GetRowCode(i) + j.ToString();
                        else if(DGV_Joueurs.Rows[i].Cells[j].Value == "S")
                            SM += GetRowCode(i) + j.ToString();
                    }
                }
            }

            return CT + PA + CR + TO + SM;
        }

        private void BTN_Lancer_Click(object sender, EventArgs e)
        {
            ConnecterServeur();
        }

        private string GetRowCode(int p)
        {
            switch (p)
            {
                case 0: return "A";
                case 1: return "B";
                case 2: return "C";
                case 3: return "D";
                case 4: return "E";
                case 5: return "F";
                case 6: return "G";
                case 7: return "H";
                case 8: return "I";
                case 9: return "J";
                default: return "";
            }
        }

        private int GetRowNum(char p)
        {
            if (p == 'A')
                return 0;
            else if (p == 'B')
                return 1;
            else if (p == 'C')
                return 2;
            else if (p == 'D')
                return 3;
            else if (p == 'E')
                return 4;
            else if (p == 'F')
                return 5;
            else if (p == 'G')
                return 6;
            else if (p == 'H')
                return 7;
            else if (p == 'I')
                return 8;
            else if (p == 'J')
                return 9;
            else
                return -1;
        }

        private void DGV_Adversaire_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (sck.Connected)
                {
                    rowIndex = e.RowIndex;
                    colIndex = e.ColumnIndex;
                    Thread t = new Thread(new ThreadStart(Attaquer));
                    t.IsBackground = true;
                    t.Start();
                }
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message + " Vous avez perdu la connexion avec le serveur");
            }
        }

        private void Attaquer()
        {
            NetworkStream stream = sck.GetStream();
            string text = GetRowCode(rowIndex) + (colIndex).ToString();
            byte[] data = Encoding.ASCII.GetBytes(text);
            stream.Write(data, 0, data.Length);
            int readBytes = stream.Read(bytes, 0, bytes.Length);
            string result = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
            if (result.StartsWith("HitDunked"))
            {
                WriteMessage("Dunked!");
                ChangeColor(Color.Red);
            }
            else if (result.StartsWith("Missed"))
            {
                WriteMessage("Missed!");
                ChangeColor(Color.Blue);
            }
            else if(result.StartsWith("Hit"))
            {
                WriteMessage("Hit!");
                ChangeColor(Color.Red);
            }
            else if(result.StartsWith("Gagne"))
            {
                DGV_Joueurs.Enabled = false;
                DGV_Adversaire.Enabled = false;
                MessageBox.Show("Partie Terminée, vous avez gagné!");
                WriteMessage("THE GAME IS DONEEEEE");
                ChangeColor(Color.Red);
            }

        }

        public void WriteMessage(String msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteMessage), new object[] { msg });
                return;
            }
            TB_Results.Text += msg + Environment.NewLine;
        }

        public void ChangeColor(Color color)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Color>(ChangeColor), new object[] { color });
                return;
            }
            DGV_Adversaire.Rows[rowIndex].Cells[colIndex].Style.BackColor = color;
        }
    }
}
