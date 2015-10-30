namespace Battleship_Client
{
    partial class Jeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Joueurs = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.BTN_NouvellePartie = new System.Windows.Forms.Button();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.DGV_Adversaire = new System.Windows.Forms.DataGridView();
            this.BTN_Envoyer = new System.Windows.Forms.Button();
            this.TB_Results = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Colonne = new System.Windows.Forms.ComboBox();
            this.CB_Ligne = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Lancer = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adversaire)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Joueurs
            // 
            this.DGV_Joueurs.AllowUserToAddRows = false;
            this.DGV_Joueurs.AllowUserToDeleteRows = false;
            this.DGV_Joueurs.AllowUserToResizeColumns = false;
            this.DGV_Joueurs.AllowUserToResizeRows = false;
            this.DGV_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Joueurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Col1,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DGV_Joueurs.EnableHeadersVisualStyles = false;
            this.DGV_Joueurs.Location = new System.Drawing.Point(26, 22);
            this.DGV_Joueurs.MultiSelect = false;
            this.DGV_Joueurs.Name = "DGV_Joueurs";
            this.DGV_Joueurs.ReadOnly = true;
            this.DGV_Joueurs.RowHeadersVisible = false;
            this.DGV_Joueurs.RowHeadersWidth = 20;
            this.DGV_Joueurs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Joueurs.Size = new System.Drawing.Size(253, 238);
            this.DGV_Joueurs.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(20, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "A";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(20, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "B";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 84);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(20, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "C";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 106);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(20, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "D";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 128);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(20, 22);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "E";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 150);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(20, 22);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "F";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 172);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(20, 22);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "G";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 194);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(20, 22);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "H";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 216);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(20, 22);
            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "I";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(6, 238);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(20, 22);
            this.textBox11.TabIndex = 11;
            this.textBox11.Text = "J";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_NouvellePartie
            // 
            this.BTN_NouvellePartie.Location = new System.Drawing.Point(12, 292);
            this.BTN_NouvellePartie.Name = "BTN_NouvellePartie";
            this.BTN_NouvellePartie.Size = new System.Drawing.Size(129, 34);
            this.BTN_NouvellePartie.TabIndex = 12;
            this.BTN_NouvellePartie.Text = "Nouvelle Partie";
            this.BTN_NouvellePartie.UseVisualStyleBackColor = true;
            this.BTN_NouvellePartie.Click += new System.EventHandler(this.BTN_NouvellePartie_Click);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(831, 292);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(129, 34);
            this.BTN_Quitter.TabIndex = 13;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(15, 232);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(20, 22);
            this.textBox10.TabIndex = 24;
            this.textBox10.Text = "J";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(15, 210);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(20, 22);
            this.textBox12.TabIndex = 23;
            this.textBox12.Text = "I";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(15, 188);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(20, 22);
            this.textBox13.TabIndex = 22;
            this.textBox13.Text = "H";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(15, 166);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(20, 22);
            this.textBox14.TabIndex = 21;
            this.textBox14.Text = "G";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(15, 144);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(20, 22);
            this.textBox15.TabIndex = 20;
            this.textBox15.Text = "F";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(15, 122);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(20, 22);
            this.textBox16.TabIndex = 19;
            this.textBox16.Text = "E";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(15, 100);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(20, 22);
            this.textBox17.TabIndex = 18;
            this.textBox17.Text = "D";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(15, 78);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(20, 22);
            this.textBox18.TabIndex = 17;
            this.textBox18.Text = "C";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(15, 56);
            this.textBox19.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(20, 22);
            this.textBox19.TabIndex = 16;
            this.textBox19.Text = "B";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(15, 34);
            this.textBox20.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(20, 22);
            this.textBox20.TabIndex = 15;
            this.textBox20.Text = "A";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV_Adversaire
            // 
            this.DGV_Adversaire.AllowUserToAddRows = false;
            this.DGV_Adversaire.AllowUserToDeleteRows = false;
            this.DGV_Adversaire.AllowUserToResizeColumns = false;
            this.DGV_Adversaire.AllowUserToResizeRows = false;
            this.DGV_Adversaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Adversaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.DGV_Adversaire.EnableHeadersVisualStyles = false;
            this.DGV_Adversaire.Location = new System.Drawing.Point(35, 16);
            this.DGV_Adversaire.MultiSelect = false;
            this.DGV_Adversaire.Name = "DGV_Adversaire";
            this.DGV_Adversaire.ReadOnly = true;
            this.DGV_Adversaire.RowHeadersVisible = false;
            this.DGV_Adversaire.RowHeadersWidth = 20;
            this.DGV_Adversaire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Adversaire.Size = new System.Drawing.Size(253, 238);
            this.DGV_Adversaire.TabIndex = 14;
            this.DGV_Adversaire.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Adversaire_CellDoubleClick);
            // 
            // BTN_Envoyer
            // 
            this.BTN_Envoyer.Location = new System.Drawing.Point(334, 94);
            this.BTN_Envoyer.Name = "BTN_Envoyer";
            this.BTN_Envoyer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Envoyer.TabIndex = 25;
            this.BTN_Envoyer.Text = "Envoyer";
            this.BTN_Envoyer.UseVisualStyleBackColor = true;
            this.BTN_Envoyer.Click += new System.EventHandler(this.BTN_Envoyer_Click);
            // 
            // TB_Results
            // 
            this.TB_Results.Location = new System.Drawing.Point(760, 33);
            this.TB_Results.Multiline = true;
            this.TB_Results.Name = "TB_Results";
            this.TB_Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Results.Size = new System.Drawing.Size(200, 252);
            this.TB_Results.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Colonne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ligne";
            // 
            // CB_Colonne
            // 
            this.CB_Colonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Colonne.FormattingEnabled = true;
            this.CB_Colonne.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CB_Colonne.Location = new System.Drawing.Point(361, 47);
            this.CB_Colonne.Name = "CB_Colonne";
            this.CB_Colonne.Size = new System.Drawing.Size(75, 21);
            this.CB_Colonne.TabIndex = 28;
            // 
            // CB_Ligne
            // 
            this.CB_Ligne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Ligne.FormattingEnabled = true;
            this.CB_Ligne.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.CB_Ligne.Location = new System.Drawing.Point(361, 19);
            this.CB_Ligne.Name = "CB_Ligne";
            this.CB_Ligne.Size = new System.Drawing.Size(75, 21);
            this.CB_Ligne.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Joueurs);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 273);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joueur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Lancer);
            this.groupBox2.Controls.Add(this.DGV_Adversaire);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox18);
            this.groupBox2.Controls.Add(this.CB_Colonne);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.CB_Ligne);
            this.groupBox2.Controls.Add(this.textBox16);
            this.groupBox2.Controls.Add(this.BTN_Envoyer);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Location = new System.Drawing.Point(308, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 267);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adversaire";
            // 
            // BTN_Lancer
            // 
            this.BTN_Lancer.Location = new System.Drawing.Point(334, 142);
            this.BTN_Lancer.Name = "BTN_Lancer";
            this.BTN_Lancer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Lancer.TabIndex = 31;
            this.BTN_Lancer.Text = "Lancer(Test)";
            this.BTN_Lancer.UseVisualStyleBackColor = true;
            this.BTN_Lancer.Click += new System.EventHandler(this.BTN_Lancer_Click);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "0";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 25;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 25;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "4";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 25;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "5";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 25;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "6";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 25;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "7";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 25;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "8";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 25;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "9";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 25;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "0";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 25;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "1";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Width = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "2";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 25;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 25;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 25;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 25;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 25;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TB_Results);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_NouvellePartie);
            this.Name = "Jeu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adversaire)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Joueurs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button BTN_NouvellePartie;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.DataGridView DGV_Adversaire;
        private System.Windows.Forms.Button BTN_Envoyer;
        private System.Windows.Forms.TextBox TB_Results;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Colonne;
        private System.Windows.Forms.ComboBox CB_Ligne;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Lancer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;


    }
}

