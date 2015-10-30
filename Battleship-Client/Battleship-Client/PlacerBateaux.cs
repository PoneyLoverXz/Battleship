using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_Client
{
    public partial class PlacerBateaux : Form
    {
        const int ROWS_COUNT = 10;
        const int COLUMNS_COUNT = 10;

        bool PlacedP = false;
        bool PlacedC = false;
        bool PlacedCT = false;
        bool PlacedS = false;
        bool PlacedT = false;

        Ships PorteAvion = new Ships("PorteAvion", 5, "P");
        Ships Croiseur = new Ships("Croiseur", 4, "C");
        Ships ContreTourpilleur = new Ships("ContreTorpilleur", 3, "CT");
        Ships SousMarin = new Ships("SousMarin", 3, "S");
        Ships Tourpilleur = new Ships("Tourpilleur", 2, "T");

        public string[,] dgv = new string[ROWS_COUNT, COLUMNS_COUNT];

        public PlacerBateaux()
        {
            InitializeComponent();
            ClearSea();
            SetCBIndexToZero();
        }

        //Initialiser les combobx à 0
        private void SetCBIndexToZero()
        {
            CB_OrientationP.SelectedIndex = 0;
            CB_OrientationCT.SelectedIndex = 0;
            CB_OrientationC.SelectedIndex = 0;
            CB_OrientationS.SelectedIndex = 0;
            CB_OrientationT.SelectedIndex = 0;

            CB_LigneP.SelectedIndex = 0;
            CB_LigneCT.SelectedIndex = 0;
            CB_LigneC.SelectedIndex = 0;
            CB_LigneS.SelectedIndex = 0;
            CB_LigneT.SelectedIndex = 0;

            CB_ColonneP.SelectedIndex = 0;
            CB_ColonneCT.SelectedIndex = 0;
            CB_ColonneC.SelectedIndex = 0;
            CB_ColonneS.SelectedIndex = 0;
            CB_ColonneT.SelectedIndex = 0;
        }

        //Vider le board (le mettre blanc)
        private void ClearSea()
        {
            for (int i = 0; i < ROWS_COUNT; i++)
            {
                DGV_Demo.Rows.Add("", "", "", "", "", "", "", "", "", "");
            }
        }

        //Bouton Quitter
        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Bouton Terminer
        private void BTN_Terminer_Click(object sender, EventArgs e)
        {
            if(PlacedC && PlacedCT && PlacedP && PlacedS && PlacedT)
            {
                FillStringArray();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tous les bateaux doivent être placés avant de commencer");
            }
        }

        //Remplir l'array de string pour transmettre au form principal
        private void FillStringArray()
        {
            for (int i = 0; i < ROWS_COUNT; i++)
            {
                for (int j = 0; j < COLUMNS_COUNT; j++)
                {
                    dgv[i, j] = DGV_Demo.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        //BOUTONS PLACER ***
        #region 
        private void BTN_Placer_P_Click(object sender, EventArgs e)
        {
            int row = CB_LigneP.SelectedIndex;
            int col = CB_ColonneP.SelectedIndex;
            ShipOrientation o = GetOrientation(CB_OrientationP.SelectedItem.ToString());

            if(!CheckIfStomping(PorteAvion,o,row,col))
            {
                PlaceShip(PorteAvion, o, row, col);
                PlacedP = true;
            }
            else
            {
                MessageBox.Show("Le porte-avion écraserait un autre bateau");
            }
        }

        private void BTN_Placer_CT_Click(object sender, EventArgs e)
        {
            int row = CB_LigneCT.SelectedIndex;
            int col = CB_ColonneCT.SelectedIndex;
            ShipOrientation o = GetOrientation(CB_OrientationCT.SelectedItem.ToString());


            if (!CheckIfStomping(ContreTourpilleur, o, row, col))
            {
                PlaceShip(ContreTourpilleur, o, row, col);
                PlacedCT = true;
            }
            else
            {
                MessageBox.Show("Le contre-tourpilleur écraserait un autre bateau");
            }
        }

        private void BTN_Placer_T_Click(object sender, EventArgs e)
        {
            int row = CB_LigneT.SelectedIndex;
            int col = CB_ColonneT.SelectedIndex;
            ShipOrientation o = GetOrientation(CB_OrientationT.SelectedItem.ToString());

            if (!CheckIfStomping(Tourpilleur, o, row, col))
            {
                PlaceShip(Tourpilleur, o, row, col);
                PlacedT = true;
            }
            else
            {
                MessageBox.Show("Le tourpilleur écraserait un autre bateau");
            }
        }

        private void BTN_Placer_C_Click(object sender, EventArgs e)
        {
            int row = CB_LigneC.SelectedIndex;
            int col = CB_ColonneC.SelectedIndex;
            ShipOrientation o = GetOrientation(CB_OrientationC.SelectedItem.ToString());

            if (!CheckIfStomping(Croiseur, o, row, col))
            {
                PlaceShip(Croiseur, o, row, col);
                PlacedC = true;
            }
            else
            {
                MessageBox.Show("Le croiseur écraserait un autre bateau");
            }
        }

        private void BTN_Placer_S_Click(object sender, EventArgs e)
        {
            int row = CB_LigneS.SelectedIndex;
            int col = CB_ColonneS.SelectedIndex;
            ShipOrientation o = GetOrientation(CB_OrientationS.SelectedItem.ToString());

            if (!CheckIfStomping(SousMarin, o, row, col))
            {
                PlaceShip(SousMarin, o, row, col);
                PlacedS = true;
            }
            else
            {
                MessageBox.Show("Le sous-marin écraserait un autre bateau");
            }
        }
        #endregion

        //Avoir l'orientation selon l'item sélectionné dans le combobox
        private ShipOrientation GetOrientation(string p)
        {
            if (p == "Vertical")
                return ShipOrientation.Vertical;
            else
                return ShipOrientation.Horizontal;
        }

        //Placer un bateau selon les données entrées
        private void PlaceShip(Ships ship, ShipOrientation orientation, int rowStart, int colStart)
        {
            ClearSeaFromShip(ship);
          
            if (orientation == ShipOrientation.Vertical)
            {
                for (int i = rowStart; i < rowStart + ship.GetLength(); i++)
                {
                    DGV_Demo.Rows[i].Cells[colStart].Value = ship.GetCode();
                }
            }
            else if (orientation == ShipOrientation.Horizontal)
            {
                for (int i = colStart; i < colStart + ship.GetLength(); i++)
                {
                    DGV_Demo.Rows[rowStart].Cells[i].Value = ship.GetCode();
                }
            }
        }

        //Vider le board d'un bateau en particulier
        private void ClearSeaFromShip(Ships ship)
        {
            string c = ship.GetCode();
            for(int i = 0; i < DGV_Demo.Rows.Count; i++)
            {
                for(int j = 0; j < DGV_Demo.ColumnCount; j++)
                {
                    if(DGV_Demo.Rows[i].Cells[j].Value.ToString() == c)
                    {
                        DGV_Demo.Rows[i].Cells[j].Value = "";
                    }
                }
            }
        }

        //Voir si ça va écraser un bateau
        private bool CheckIfStomping(Ships ship, ShipOrientation orientation, int rowStart, int colStart)
        {
            bool Stomping = false;

            if (orientation == ShipOrientation.Vertical)
            {
                for (int i = rowStart; i < rowStart + ship.GetLength() && !Stomping; i++)
                {
                    string val = DGV_Demo.Rows[i].Cells[colStart].Value.ToString();
                    if (val != "" &&  val != ship.GetCode())
                    {
                        Stomping = true;
                    }
                }
            }
            else if (orientation == ShipOrientation.Horizontal)
            {
                for (int i = colStart; i < colStart + ship.GetLength() && !Stomping; i++)
                {
                    string val = DGV_Demo.Rows[rowStart].Cells[i].Value.ToString();
                    if (val != "" && val != ship.GetCode())
                    {
                        Stomping = true;
                    }
                }
            }
            return Stomping;
        }


        //CHANGER LES ITEMS DES COMBOBOX SELON L'ORIENTATION
        #region 
        private void CB_OrientationP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_OrientationP.SelectedIndex == 1)
            {
                CB_LigneP.Items.Clear();
                CB_LigneP.Items.Add("A");
                CB_LigneP.Items.Add("B");
                CB_LigneP.Items.Add("C");
                CB_LigneP.Items.Add("D");
                CB_LigneP.Items.Add("E");
                CB_LigneP.Items.Add("F");

                CB_ColonneP.Items.Clear();
                CB_ColonneP.Items.Add("1");
                CB_ColonneP.Items.Add("2");
                CB_ColonneP.Items.Add("3");
                CB_ColonneP.Items.Add("4");
                CB_ColonneP.Items.Add("5");
                CB_ColonneP.Items.Add("6");
                CB_ColonneP.Items.Add("7");
                CB_ColonneP.Items.Add("8");
                CB_ColonneP.Items.Add("9");
                CB_ColonneP.Items.Add("10");
            }
            else
            {
                CB_LigneP.Items.Clear();
                CB_LigneP.Items.Add("A");
                CB_LigneP.Items.Add("B");
                CB_LigneP.Items.Add("C");
                CB_LigneP.Items.Add("D");
                CB_LigneP.Items.Add("E");
                CB_LigneP.Items.Add("F");
                CB_LigneP.Items.Add("G");
                CB_LigneP.Items.Add("H");
                CB_LigneP.Items.Add("I");
                CB_LigneP.Items.Add("J");

                CB_ColonneP.Items.Clear();
                CB_ColonneP.Items.Add("1");
                CB_ColonneP.Items.Add("2");
                CB_ColonneP.Items.Add("3");
                CB_ColonneP.Items.Add("4");
                CB_ColonneP.Items.Add("5");
                CB_ColonneP.Items.Add("6");
            }
            CB_ColonneP.SelectedIndex = 0;
            CB_LigneP.SelectedIndex = 0;
        }

        private void CB_OrientationC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_OrientationC.SelectedIndex == 1)
            {
                CB_LigneC.Items.Clear();
                CB_LigneC.Items.Add("A");
                CB_LigneC.Items.Add("B");
                CB_LigneC.Items.Add("C");
                CB_LigneC.Items.Add("D");
                CB_LigneC.Items.Add("E");
                CB_LigneC.Items.Add("F");
                CB_LigneC.Items.Add("G");

                CB_ColonneC.Items.Clear();
                CB_ColonneC.Items.Add("1");
                CB_ColonneC.Items.Add("2");
                CB_ColonneC.Items.Add("3");
                CB_ColonneC.Items.Add("4");
                CB_ColonneC.Items.Add("5");
                CB_ColonneC.Items.Add("6");
                CB_ColonneC.Items.Add("7");
                CB_ColonneC.Items.Add("8");
                CB_ColonneC.Items.Add("9");
                CB_ColonneC.Items.Add("10");
            }
            else
            {
                CB_LigneC.Items.Clear();
                CB_LigneC.Items.Add("A");
                CB_LigneC.Items.Add("B");
                CB_LigneC.Items.Add("C");
                CB_LigneC.Items.Add("D");
                CB_LigneC.Items.Add("E");
                CB_LigneC.Items.Add("F");
                CB_LigneC.Items.Add("G");
                CB_LigneC.Items.Add("H");
                CB_LigneC.Items.Add("I");
                CB_LigneC.Items.Add("J");

                CB_ColonneC.Items.Clear();
                CB_ColonneC.Items.Add("1");
                CB_ColonneC.Items.Add("2");
                CB_ColonneC.Items.Add("3");
                CB_ColonneC.Items.Add("4");
                CB_ColonneC.Items.Add("5");
                CB_ColonneC.Items.Add("6");
                CB_ColonneC.Items.Add("7");
            }
            CB_ColonneC.SelectedIndex = 0;
            CB_LigneC.SelectedIndex = 0;
        }

        private void CB_OrientationCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_OrientationCT.SelectedIndex == 1)
            {
                CB_LigneCT.Items.Clear();
                CB_LigneCT.Items.Add("A");
                CB_LigneCT.Items.Add("B");
                CB_LigneCT.Items.Add("C");
                CB_LigneCT.Items.Add("D");
                CB_LigneCT.Items.Add("E");
                CB_LigneCT.Items.Add("F");
                CB_LigneCT.Items.Add("G");
                CB_LigneCT.Items.Add("H");

                CB_ColonneCT.Items.Clear();
                CB_ColonneCT.Items.Add("1");
                CB_ColonneCT.Items.Add("2");
                CB_ColonneCT.Items.Add("3");
                CB_ColonneCT.Items.Add("4");
                CB_ColonneCT.Items.Add("5");
                CB_ColonneCT.Items.Add("6");
                CB_ColonneCT.Items.Add("7");
                CB_ColonneCT.Items.Add("8");
                CB_ColonneCT.Items.Add("9");
                CB_ColonneCT.Items.Add("10");
            }
            else
            {
                CB_LigneCT.Items.Clear();
                CB_LigneCT.Items.Add("A");
                CB_LigneCT.Items.Add("B");
                CB_LigneCT.Items.Add("C");
                CB_LigneCT.Items.Add("D");
                CB_LigneCT.Items.Add("E");
                CB_LigneCT.Items.Add("F");
                CB_LigneCT.Items.Add("G");
                CB_LigneCT.Items.Add("H");
                CB_LigneCT.Items.Add("I");
                CB_LigneCT.Items.Add("J");

                CB_ColonneCT.Items.Clear();
                CB_ColonneCT.Items.Add("1");
                CB_ColonneCT.Items.Add("2");
                CB_ColonneCT.Items.Add("3");
                CB_ColonneCT.Items.Add("4");
                CB_ColonneCT.Items.Add("5");
                CB_ColonneCT.Items.Add("6");
                CB_ColonneCT.Items.Add("7");
                CB_ColonneCT.Items.Add("8");
            }
            CB_ColonneCT.SelectedIndex = 0;
            CB_LigneCT.SelectedIndex = 0;
        }

        private void CB_OrientationS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_OrientationS.SelectedIndex == 1)
            {
                CB_LigneS.Items.Clear();
                CB_LigneS.Items.Add("A");
                CB_LigneS.Items.Add("B");
                CB_LigneS.Items.Add("C");
                CB_LigneS.Items.Add("D");
                CB_LigneS.Items.Add("E");
                CB_LigneS.Items.Add("F");
                CB_LigneS.Items.Add("G");
                CB_LigneS.Items.Add("H");

                CB_ColonneS.Items.Clear();
                CB_ColonneS.Items.Add("1");
                CB_ColonneS.Items.Add("2");
                CB_ColonneS.Items.Add("3");
                CB_ColonneS.Items.Add("4");
                CB_ColonneS.Items.Add("5");
                CB_ColonneS.Items.Add("6");
                CB_ColonneS.Items.Add("7");
                CB_ColonneS.Items.Add("8");
                CB_ColonneS.Items.Add("9");
                CB_ColonneS.Items.Add("10");
            }
            else
            {
                CB_LigneS.Items.Clear();
                CB_LigneS.Items.Add("A");
                CB_LigneS.Items.Add("B");
                CB_LigneS.Items.Add("C");
                CB_LigneS.Items.Add("D");
                CB_LigneS.Items.Add("E");
                CB_LigneS.Items.Add("F");
                CB_LigneS.Items.Add("G");
                CB_LigneS.Items.Add("H");
                CB_LigneS.Items.Add("I");
                CB_LigneS.Items.Add("J");

                CB_ColonneS.Items.Clear();
                CB_ColonneS.Items.Add("1");
                CB_ColonneS.Items.Add("2");
                CB_ColonneS.Items.Add("3");
                CB_ColonneS.Items.Add("4");
                CB_ColonneS.Items.Add("5");
                CB_ColonneS.Items.Add("6");
                CB_ColonneS.Items.Add("7");
                CB_ColonneS.Items.Add("8");
            }

            CB_ColonneS.SelectedIndex = 0;
            CB_LigneS.SelectedIndex = 0;
        }

        private void CB_OrientationT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_OrientationT.SelectedIndex == 1)
            {
                CB_LigneT.Items.Clear();
                CB_LigneT.Items.Add("A");
                CB_LigneT.Items.Add("B");
                CB_LigneT.Items.Add("C");
                CB_LigneT.Items.Add("D");
                CB_LigneT.Items.Add("E");
                CB_LigneT.Items.Add("F");
                CB_LigneT.Items.Add("G");
                CB_LigneT.Items.Add("H");
                CB_LigneT.Items.Add("I");

                CB_ColonneT.Items.Clear();
                CB_ColonneT.Items.Add("1");
                CB_ColonneT.Items.Add("2");
                CB_ColonneT.Items.Add("3");
                CB_ColonneT.Items.Add("4");
                CB_ColonneT.Items.Add("5");
                CB_ColonneT.Items.Add("6");
                CB_ColonneT.Items.Add("7");
                CB_ColonneT.Items.Add("8");
                CB_ColonneT.Items.Add("9");
                CB_ColonneT.Items.Add("10");
            }
            else
            {
                CB_LigneT.Items.Clear();
                CB_LigneT.Items.Add("A");
                CB_LigneT.Items.Add("B");
                CB_LigneT.Items.Add("C");
                CB_LigneT.Items.Add("D");
                CB_LigneT.Items.Add("E");
                CB_LigneT.Items.Add("F");
                CB_LigneT.Items.Add("G");
                CB_LigneT.Items.Add("H");
                CB_LigneT.Items.Add("I");
                CB_LigneT.Items.Add("J");

                CB_ColonneT.Items.Clear();
                CB_ColonneT.Items.Add("1");
                CB_ColonneT.Items.Add("2");
                CB_ColonneT.Items.Add("3");
                CB_ColonneT.Items.Add("4");
                CB_ColonneT.Items.Add("5");
                CB_ColonneT.Items.Add("6");
                CB_ColonneT.Items.Add("7");
                CB_ColonneT.Items.Add("8");
                CB_ColonneT.Items.Add("9");

            }

            CB_ColonneT.SelectedIndex = 0;
            CB_LigneT.SelectedIndex = 0;
        }
#endregion
    }
}
