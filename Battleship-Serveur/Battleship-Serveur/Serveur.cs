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

namespace Battleship_Serveur
{
    public partial class Serveur : Form
    {
        static byte[] Buffer { get; set; }
        static TcpListener serversocket;

        bool end;

        byte[] bytes = new byte[1024];
        Thread t;
        Player p1 = new Player();
        Player p2 = new Player();
        TcpClient tcpP1;
        TcpClient tcpP2;
        int tour = 1;
        string message = "";

        public Serveur()
        {
            InitializeComponent();
        }

        public void WriteMessage(String msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteMessage), new object[] { msg });
                return;
            }
            TB_Affichage.Text += msg + Environment.NewLine;
        }

        public void ReceiveActions()
        {
            try
            {
                serversocket = new TcpListener(new IPEndPoint(IPAddress.Any, 1234));
                serversocket.Start();

                tcpP1 = serversocket.AcceptTcpClient();
                NetworkStream P1stream = tcpP1.GetStream();
                InstancierBateaux(p1, P1stream);
                WriteMessage("Premier Joueur accepté");

                tcpP2 = serversocket.AcceptTcpClient();
                NetworkStream P2stream = tcpP2.GetStream();
                InstancierBateaux(p2, P2stream);
                WriteMessage("Deuxième Joueur accepté");

                WriteMessage("Tous les bateaux sont prêts");

                while (!end)
                {
                    ReceiveAttack(p1, P2stream, P1stream);
                    ReceiveAttack(p2, P1stream, P2stream);
                }
            }
            catch(Exception se)
            {
                MessageBox.Show(se.Message + " Vous avez perdu le contact avec un socket!");
            }
        }

        private void ReceiveAttack(Player p, NetworkStream Pstream, NetworkStream PstreamAttacker)
        {
            bool hit = false;
            int numberOfBytesRead = 0;
            message = "Missed";

            do
            {
                numberOfBytesRead = Pstream.Read(bytes, 0, bytes.Length);
            } while (numberOfBytesRead != 2);

            string attack = Encoding.ASCII.GetString(bytes, 0, 2);
            WriteMessage(attack);

            if (p.alive_PorteAvion && !hit)
            {
                hit = VerifierTouche(p.PorteAvion, attack);
            }

            if (p.alive_Croiseur && !hit)
            {
                hit = VerifierTouche(p.Croiseur, attack);
            }

            if (p.alive_ContreTourpilleur && !hit)
            {
                hit = VerifierTouche(p.ContreTourpilleur, attack);
            }

            if (p.alive_SousMarin && !hit)
            {
                hit = VerifierTouche(p.SousMarin, attack);
            }

            if (p.alive_Tourpilleur && !hit)
            {
                hit = VerifierTouche(p.Tourpilleur, attack);
            }
            
            if(VerifierFin(p))
            {
                message = "Gagne";
            }

            if(Pstream.CanWrite)
            {
                Buffer = Encoding.ASCII.GetBytes(message);
                Pstream.Write(Buffer, 0, Buffer.Length);
                Pstream.Flush();
            }
            else
            {
                WriteMessage("cant write");
            }

            //if (PstreamAttacker.CanWrite)
            //{
            //    Buffer = Encoding.ASCII.GetBytes(message);
            //    Pstream.Write(Buffer, 0, Buffer.Length);
            //    Pstream.Flush();
            //}
            //else
            //{
            //    WriteMessage("cant write");
            //}
            
        }

        private bool VerifierTouche(string[] p, string attack)
        {
            bool hit = false;
            for (int i = 0; i < p.Length && !hit; i++)
            {
                if (attack == p[i])
                {
                    hit = true;
                    p[i] = "";
                    message = "Hit!";
                }
            }
            if (hit)
            {
                if (VerifierCoule(p))
                {
                    message = "HitDunked!";
                }
            }
            return hit;
        }

        private bool VerifierCoule(string[] p)
        {
            bool Coule = true;
            for (int i = 0; i < p.Length && Coule; i++)
            {
                if (p[i] != "")
                    Coule = false;
            }
            return Coule;
        }

        private bool VerifierFin(Player p)
        {
            end = true;
            if(end)
                end = VerifierCoule(p.PorteAvion);
            if(end)
                end = VerifierCoule(p.Croiseur);
            if(end)
                end = VerifierCoule(p.ContreTourpilleur);
            if(end)
                end = VerifierCoule(p.SousMarin);
            if(end)
                end = VerifierCoule(p.Tourpilleur);
            return end;
        }

        private void InstancierBateaux(Player p, NetworkStream Pstream)
        {
            string ship = "";
            do
            {
                int numberOfBytesRead = Pstream.Read(bytes, 0, bytes.Length);
                if (numberOfBytesRead >= 44)
                {
                    int index = 0;
                    ship = Encoding.ASCII.GetString(bytes, index, 2);
                    index += 2;
                    if (ship == "CT")
                    {
                        p.ContreTourpilleur[0] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.ContreTourpilleur[1] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.ContreTourpilleur[2] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;

                        p.bContreTourpilleur = true;
                        ship = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                    }
                    if (ship == "PA")
                    {
                        p.PorteAvion[0] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.PorteAvion[1] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.PorteAvion[2] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.PorteAvion[3] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.PorteAvion[4] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;

                        p.bPorteAvion = true;
                        ship = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                    }
                    if (ship == "CR")
                    {
                        p.Croiseur[0] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.Croiseur[1] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.Croiseur[2] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.Croiseur[3] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;

                        p.bCroiseur = true;
                        ship = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                    }
                    if (ship == "TO")
                    {
                        p.Tourpilleur[0] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.Tourpilleur[1] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;

                        p.bTourpilleur = true;
                        ship = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                    }
                    if (ship == "SM")
                    {
                        p.SousMarin[0] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.SousMarin[1] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                        p.SousMarin[2] = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;

                        p.bSousMarin = true;
                        ship = Encoding.ASCII.GetString(bytes, index, 2);
                        index += 2;
                    }
                }

            } while (!p.bContreTourpilleur || !p.bCroiseur || !p.bPorteAvion || !p.bSousMarin || !p.bTourpilleur);
        }

        private void BTN_Lancer_Click(object sender, EventArgs e)
        {
            LB_Statut.Text = "Ouvert";

            t = new Thread(new ThreadStart(ReceiveActions));
            t.IsBackground = true;
            t.Start();
            TB_Affichage.Text += "Recherche des joueurs" + Environment.NewLine;
        }
    }
}
